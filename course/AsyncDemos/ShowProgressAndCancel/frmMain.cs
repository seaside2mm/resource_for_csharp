using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowProgressAndCancel
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// 用于显示工作进度的组件
        /// </summary>
        Progress<int> progressReport = null;
        /// <summary>
        /// 用于设定要查找数的范围上限
        /// </summary>
        private int limit = 0;
        /// <summary>
        /// 用于提前取消操作
        /// </summary>
        CancellationTokenSource cts = null;

        public frmMain()
        {
            InitializeComponent();

            //以下两个初始化Progress组件的方式，可以任选一种
            InitProgressUseEvent();
            //InitProgressWithDelegate();


            limit = new Random().Next(Int32.MaxValue);

        }
        #region "初始化Progresss组件"
        /// <summary>
        /// 在构建Progress组件时直接指定ProgressChanged事件的回调方法
        /// </summary>
        private void InitProgressWithDelegate()
        {
            //显示进度的代码会自动推送到UI线程中执行
            progressReport = new Progress<int>((status) =>
            {
                //在此可以直接地编写代码访问UI控件
                lblInfo.Text = "己完成：" + status + "%";

            });
        }
        /// <summary>
        /// 基于事件响应的方式报告进度
        /// </summary>
        private void InitProgressUseEvent()
        {
            progressReport = new Progress<int>();
            progressReport.ProgressChanged += progressReport_ProgressChanged;
        }

        void progressReport_ProgressChanged(object sender, int e)
        {
            //在此可以直接地编写代码访问UI控件
            lblInfo.Text = "己完成：" + e + "%";
        }

        #endregion

        /// <summary>
        /// 计算指定范围内的偶数数量
        /// </summary>
        /// <param name="limit">要计算的区间上限</param>
        /// <param name="onProgressChanged">用于报告进度的组件</param>
        /// <param name="cancelToken">用于检测外界是否请求取消的取消令牌</param>
        public async void ShowEvenNumbers(int limit, IProgress<int> onProgressChanged, 
            CancellationToken cancelToken)
        {
            Func<int> calculateTask = () =>
            {
                int lastProgressValue = 0;
                int currentProgressValue = 0;
                int count = 0;
                for (int i = 1; i < limit; i++)
                {
                    if (i % 2 == 0)
                    {
                        count++;
                        currentProgressValue = (int)(((double)i / limit) * 100);
                        if (lastProgressValue != currentProgressValue)
                        {
                            //报造进度
                            onProgressChanged.Report(currentProgressValue);
                            lastProgressValue = currentProgressValue;
                        }
                    }
                    //检测外界是否发出了取消请求，如果发出了此请求，
                    //抛出OperationCanceledException
                    cancelToken.ThrowIfCancellationRequested();
                }
                return count;

            };
            //允许被取消的计算任务
            Task<int> evenNumbersTask = Task.Run(calculateTask, cancelToken); 
            try
            {
                //异步等待任务完成
                int evenNumberCount = await evenNumbersTask;
                //可以直接访问UI控件，这是异步调用带给我们的方便
                lblInfo.Text = string.Format("计算结果：从{0}到{1}中共有偶数{2}个。", 
                    1, limit, evenNumberCount);

            }
            catch (OperationCanceledException)
            {
                lblInfo.Text = "计算任务己被取消。";
            }
            //允许重新启动一个新任务
            btnCancel.Enabled = false;
            btnStart.Enabled = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Start();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();

        }
        /// <summary>
        /// 启动任务
        /// </summary>
        private void Start()
        {
            cts = new CancellationTokenSource();
            ShowEvenNumbers(limit, progressReport, cts.Token);
            btnCancel.Enabled = true;
            lblInfo.Text = "计算任务己经启动并在后台运行，等其工作完成，结果会自动显示";
        }
        /// <summary>
        /// 取消任务
        /// </summary>
        private void Cancel()
        {
            if (cts != null)
            {
                cts.Cancel();
            }
        }


    }
}

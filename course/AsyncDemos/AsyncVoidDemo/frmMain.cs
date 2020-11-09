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

namespace AsyncVoidDemo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            ResetLabel();
        }

        private int left = 0;
        private int right = 0;
        private int result = 0;

        private Random ran = new Random();

        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine("UI Thread:{0}", Thread.CurrentThread.ManagedThreadId);
            ResetLabel();

            if (rdoAsyncVoid.Checked)
            {
                TestAsyncVoid();
            }
            else
            {
                TestAsyncTask();
            }

        }

        private void ResetLabel()
        {
            lblResult.Text = "？";
            lblLeft.Text = "？";
            lblRight.Text = "？";
            //立即刷新
            lblResult.Refresh();
            lblLeft.Refresh();
            lblResult.Refresh();
        }

        #region "测试async void的异步方法"

        //生成第一个数
        private async void GeneratorLeftOperand()
        {
            await Task.Delay(new Random().Next(1, 1000));
            left = new Random().Next(1, 1000);
        }
        //生成第二个数
        private async void GeneratorRightOperand()
        {
            await Task.Delay(new Random().Next(1, 1000));
            right = new Random().Next(1, 1000);
        }
        //完成计算功能
        private async void Calculate()
        {
            await Task.Delay(new Random().Next(1, 1000));
            result = left + right;
        }

        //当异步方法返回async void时，由于它在独立的线程中执行，所以不但结果不对
        //就连显示都不一定正常
        private void TestAsyncVoid()
        {
            //(1)生成第一个数
            GeneratorLeftOperand();
            lblLeft.Text = left.ToString();
            //(2)生成第二个数
            GeneratorRightOperand();
            lblRight.Text = right.ToString();
            //(3)完成计算功能
            Calculate();
            lblResult.Text = result.ToString();
        }

        #endregion

        #region "使用async Task"

      
        //生成第一个数
        private async Task GeneratorLeftOperandTask()
        {

            await Task.Run(async () =>
            {

                await Task.Delay(ran.Next(1, 1000));
                left = ran.Next(1, 1000);

            });
            lblLeft.Text = left.ToString();

        }
        //生成第二个数
        private async Task GeneratorRightOperandTask()
        {
            await Task.Run(async () =>
            {
                await Task.Delay(ran.Next(1, 1000));
                right = ran.Next(1, 1000);

            });
            lblRight.Text = right.ToString();
        }
        //完成计算
        private async Task CalculateTask()
        {
            //并行执行两个异步方法，生成两个数
            await Task.WhenAll(GeneratorLeftOperandTask(), GeneratorRightOperandTask());
            //执行计算
            result = left + right;
        }

        //对于不需要返回值的异步方法，让其返回async Task
        //在调用它的地方使用await，就能保证工作正常
        private async void TestAsyncTask()
        {
            await CalculateTask();
            lblResult.Text = result.ToString();
        }

        #endregion
    }
}

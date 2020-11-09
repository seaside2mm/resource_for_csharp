using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncVsTPLForWinForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            //UseTPL();
            UseAsync();
        }
        #region "TPL版本"
        private void UseTPL()
        {
            btnLaunch.Enabled = false;
            lblInfo.Text = "提示信息";
            //定义两个Task顺次工作
            Task.Factory.StartNew(
                //启动后台工作
                () => SayHelloTo("张三"))
                .ContinueWith(
                    task =>
                    {
                        lblInfo.Text = task.Result;
                        btnLaunch.Enabled = true;
                    },
                    //通知TPL，需要捕获线程同步上下文
                    TaskScheduler.FromCurrentSynchronizationContext());
        }

        private string SayHelloTo(string person)
        {
            Thread.Sleep(2000);
            return person + ",你好！";
        }
        #endregion

        #region "async版本"
        private async void UseAsync()
        {
            btnLaunch.Enabled = false;
            lblInfo.Text = "等待后台任务完成……";
            var result = await SayHelloToAsync("张三");
            lblInfo.Text = result;
            btnLaunch.Enabled = true;
        }
        private Task<String> SayHelloToAsync(string person)
        {
            return Task.Factory.StartNew(() => SayHelloTo(person));
        }
        #endregion
    }
}

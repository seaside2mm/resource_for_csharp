using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartialDemo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        //定义一个分部方法
        partial void MyPartialMethod();

        private void btnClick_Click(object sender, EventArgs e)
        {
            //调用分部方法
            MyPartialMethod();
        }
    }
}

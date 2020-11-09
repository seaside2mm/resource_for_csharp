using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialDemo
{
    //一个分部类，放置分部方法的具体实现代码
    //当这里面的分部方法代码被注释掉时，程序仍然能够编译运行
    partial class frmMain
    {
        private int count = 0;
        //分部方法的实现
        partial void MyPartialMethod()
        {
            count++;
            lblInfo.Text = String.Format("单击了{0}次", count);
        }

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体应用测试
{
    public class Class1
    {
        public Class1()
        {

        }

        public void Test()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo("D://1");
            foreach (DirectoryInfo directory in directoryInfo.GetDirectories())
            {
                MessageBox.Show(directory.FullName);

            }
        }
    }
}

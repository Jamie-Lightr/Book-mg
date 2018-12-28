using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BookManage
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Model.Reader k= new Model.Reader();
            k.rdID = 1;
            k.rdName = "马设废";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new admain_frm(k));
            //Application.Run(new borrow_frm(k));
            Application.Run(new login_frm());
        }
    }
}

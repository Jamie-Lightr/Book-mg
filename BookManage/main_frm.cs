using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BookManage.Model;
using BookManage.BLL;

namespace BookManage
{
    public partial class main_frm : Form
    {
        Reader rd = new Reader();
        
        //Reader admin = new Reader();
        Form ffrm = null;
        admain_frm adfrm = null;
        borrow_frm brfrm = null;
        public main_frm(login_frm f)
        {
            ffrm = f;
            InitializeComponent();
            rd = f.rd;
            Reader_ad.fill(rd);
            admin_identy.Text = string.Format("Welcome {0} !!!!!", rd.rdName);
        }


        protected override void WndProc(ref Message m)
        {

            const int WM_SYSCOMMAND = 0x0112;
            const int SC_CLOSE = 0xF060;
            if (m.Msg == WM_SYSCOMMAND && (int)m.WParam == SC_CLOSE)
            {

                this.Close();
                ffrm.Show();
                //Console.Write("hide success;");
                return;
            }
            base.WndProc(ref m);
        }

        private void admin_btn_Click_1(object sender, EventArgs e)
        {
            Form test = Application.OpenForms["admain_frm"];
            if ((test == null) || (test.IsDisposed))
            {
                adfrm = new admain_frm(rd);
                adfrm.MdiParent = this;
                adfrm.Show();


            }
        }

        private void borrow_btn_Click(object sender, EventArgs e)
        {
            Form test = Application.OpenForms["borrow_frm"];
            if ((test == null) || (test.IsDisposed))
            {
                brfrm = new borrow_frm(rd);
                brfrm.MdiParent = this;
                brfrm.Show();


            }
        }

        private void admin_identy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此功能尚未开发", "qoq", MessageBoxButtons.OK);
        }
    }
}

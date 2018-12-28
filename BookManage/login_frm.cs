using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BookManage.BLL;
using BookManage.Model;


namespace BookManage
{
    public partial class login_frm : Form
    {
        public login_frm()
        {
            InitializeComponent();
        }
        public Reader rd = new Reader();
        Reader_ad ways = new Reader_ad();
        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_input.Text == "" || pwd_input.Text == "")
            {
                MessageBox.Show("请输入用户名或密码", "blabla", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                rd.rdID = login_input.Text;
                rd.rdPwd = pwd_input.Text;
                if (ways.check_login(rd))
                {
                    rd = ways.rd_fill(rd);
                    Form f_c = Application.OpenForms["admin_frm"];
                    if ((f_c == null) || (f_c.IsDisposed))
                    {
                        main_frm af = new main_frm(this);
                        this.Hide();
                        af.Show();
                    }
                   

                    //MessageBox.Show("success", "blabla", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("failure", "blabla", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}

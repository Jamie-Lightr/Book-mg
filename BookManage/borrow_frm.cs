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
using System.Text.RegularExpressions;


namespace BookManage
{
    public partial class borrow_frm : Form
    {
        
        public borrow_frm(Reader rd)
        {
            InitializeComponent();
            rd_refresh_Click(null, null);
            bk_refresh_Click(null, null);
            rb_borrow_bk.Checked = true;
            admin = rd;
            tb_OperatorRet.Text = admin.rdName.ToString();
            tb_OperatorLend.Text = admin.rdName.ToString();
        }
        private static Reader admin = null;
        Borrow br_b = new Borrow();
        Borrow br = new Borrow();
        Book bk = new Book();
        Reader rd = new Reader();
        static string datepattern = @"(\d*\/\d*\/\d*)";
        //--------------------------------------------日期格式化------------------------------------------------//
        public static string match(object t)
        {
            string k = null;
            foreach (Match m in Regex.Matches(Convert.ToString(t), datepattern))
            {
                k = k + m.Value;
            }
            return k;
        }



        //------------------------------------------------bookpanel---------------------------------------------------------
        private void rb_borrow_bk_CheckedChanged(object sender, EventArgs e)
        {
            p_borrow_message.Visible = true;
            p_return_message.Visible = false;
            tb_BorrowID.Clear();
            tb_rdID.Clear();
            tb_bkID.Clear();
            tb_ldDateOut.Clear();
            get_date_Click(null, null);

        }
        private void rb_return_bk_CheckedChanged(object sender, EventArgs e)
        {
            p_borrow_message.Visible = false;
            p_return_message.Visible = true;
            tb_BorrowID_b.Clear();
            tb_rdID_b.Clear();
            tb_bkID_b.Clear();
            tb_ldDateRetAct.Clear();
            get_date_b_Click(null, null);
        }
        private void bk_data_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            bk = Book_ad.Row2bk((bk_data.CurrentRow.DataBoundItem as DataRowView).Row);
            bk2tbox(bk);
            
        }
        private void bk2tbox(Book bk)
        {
            if (rb_borrow_bk.Checked == true)
                tb_bkID.Text = bk.bkID.ToString();
            else
                tb_bkID_b.Text = bk.bkID.ToString();
        }
        private void get_date_Click(object sender, EventArgs e)
        {
            tb_ldDateOut.Text = getdate(0);
        }

        private void get_date_b_Click(object sender, EventArgs e)
        {
            
            tb_ldDateRetAct.Text = getdate(0);
        }
       
        private string getdate(int day)
        {
            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now.AddDays(day);

            return string.Format("{0}/{1}/{2}", currentTime.Year, currentTime.Month, currentTime.Day);
        }



         private void bk_refresh_Click(object sender, EventArgs e)
         {
            //bk_data.AutoGenerateColumns = false;
            bk_data.DataBindings.Clear();
            bk_data.DataSource = Borrow_ad.bk_data();
            bk_data_format();
          }
        private void bk_data_format()
        {
            bk_data.Columns["bkCode"].Visible = false;
            bk_data.Columns["bkPages"].Visible = false;
            bk_data.Columns["bkPrice"].Visible = false;
            bk_data.Columns["bkDateIn"].Visible = false;
            bk_data.Columns["bkBrief"].Visible = false;
            bk_data.Columns["bkID"].HeaderCell.Value = "书本号";
            bk_data.Columns["bkName"].HeaderCell.Value = "书本名";
            bk_data.Columns["bkAuthor"].HeaderCell.Value = "作者";
            bk_data.Columns["bkPress"].HeaderCell.Value = "出版社";
            bk_data.Columns["bkDatePress"].HeaderCell.Value = "出版日期";
            bk_data.Columns["bkLanguage"].HeaderCell.Value = "语言";
            bk_data.Columns["bkStatus"].HeaderCell.Value = "书本状态";
            bk_data.Columns["bkCover"].HeaderCell.Value = "封面";
            /*
            bk_data.Columns[""]
             bk_data.Columns[""].HeaderCell.Value = "";
            bk_data.Columns[""].Visible = false;
            */
        }
        private void bk_excute_btn_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select * from dbo.book where {0} like '{1}'", bk_choose_btn.Text, bk_input.Text);
            bk_data.DataBindings.Clear();
            bk_data.DataSource = Borrow_ad.runsql(sql);
            bk_data_format();
        }
        //------------------------------------------------bookpanel---------------------------------------------------------

        //------------------------------------------------readerpanel---------------------------------------------------------
        //获取rd_data选中数据框
        private void rd_data_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rd = Reader_ad.Row2rd((rd_data.CurrentRow.DataBoundItem as DataRowView).Row);
            rd2tbox(rd);
            
        }
        //Reader对象填充到数据框
        private void rd2tbox(Reader rd)
        {
            if(rb_borrow_bk.Checked)
                tb_rdID.Text = rd.rdID.ToString();
            else
                tb_rdID_b.Text = rd.rdID.ToString();
        }
        

        private void rd_excute_btn_Click(object sender, EventArgs e)
        {
            //rd_input rd_choose_btn
            string sql = string.Format("select * from dbo.reader where {0} like '{1}'",rd_choose_btn.Text,rd_input.Text);
            rd_data.DataBindings.Clear();
            rd_data.DataSource =  Borrow_ad.runsql(sql);
            rd_data_format();
        }
        private void rd_refresh_Click(object sender, EventArgs e)
        {
            rd_data.DataBindings.Clear();
            rd_data.DataSource = Borrow_ad.rd_data();
            rd_data_format();
            
        }
        private void rd_data_format()
        {
            
            rd_data.Columns["rdDept"].Visible = false;
            rd_data.Columns["rdPwd"].Visible = false;
            rd_data.Columns["rdDateReg"].Visible = false;
            rd_data.Columns["rdAdminRoles"].Visible = false;
            rd_data.Columns["rdPhoto"].Visible = false;
            rd_data.Columns["rdType"].HeaderCell.Value = "读者类型";
            rd_data.Columns["rdID"].HeaderCell.Value = "读者号";
            rd_data.Columns["rdName"].HeaderCell.Value = "读者名";
            rd_data.Columns["rdSex"].HeaderCell.Value = "性别";
            rd_data.Columns["rdStatus"].HeaderCell.Value = "状态";
            rd_data.Columns["rdEmail"].HeaderCell.Value = "邮箱";
            rd_data.Columns["rdPhone"].HeaderCell.Value = "手机";
            rd_data.Columns["rdQQ"].HeaderCell.Value = "QQ";
            rd_data.Columns["rdBorrowQty"].HeaderCell.Value = "已借书数";



            /*
            rd_data.Columns[""]
             rd_data.Columns[""].HeaderCell.Value = "";
            rd_data.Columns[""].Visible = false;
            */
        }
        //------------------------------------------------readerpanel---------------------------------------------------------





        //------------------------------------------------borrowbook---------------------------------------------------------
        private void fill_borrow()
        {
            br.BorrowID = tb_BorrowID.Text;
            br.bkID = tb_bkID.Text;
            br.rdID = tb_rdID.Text;
            if (br.BorrowID.Equals("") == true || br.bkID.Equals("") == true || br.rdID.Equals("") == true)
            { return; }
            else
            {
                br.ldDateOut = tb_ldDateOut.Text;
                br.IsHasReturn = false;
                br.OperatorLend = admin.rdID;
                string sql_lendday = string.Format("select dbo.ReaderType.CanLendDay from dbo.ReaderType where ReaderType.rdType = (select rdType from dbo.Reader where rdID = '{0}')", rd.rdID);
                int ledday = Convert.ToInt32(Borrow_ad.runsql(sql_lendday).Rows[0][0]);
                br.ldDateRetPlan = getdate(Convert.ToInt32(ledday));
                //Console.WriteLine(br.ldDateRetPlan);
            }
        }
       
        private void borrow_btn_Click(object sender, EventArgs e)
        {
            fill_borrow();
            if (rb_borrow_bk.Checked == false)
            {
                rb_borrow_bk.Checked = true;
                MessageBox.Show("请重新选择读者和书本", "qoq", MessageBoxButtons.OK);
            }
            DialogResult br_power = DialogResult.Cancel;
            if (rd.rdStatus.Equals("有效")&&bk.bkStatus.Equals("在馆"))
            {
                br_power = MessageBox.Show("可以借书，确定借阅？(Y?N)", "lol", MessageBoxButtons.OKCancel);
            }else if(rd.rdStatus.Equals("有效"))
            {
                MessageBox.Show("很抱歉书本不在馆，不能借阅", "qoq", MessageBoxButtons.OK);
            }else if(bk.bkStatus.Equals("在馆"))
            {
                MessageBox.Show("很抱歉读者证已失效，不能借阅", "qoq", MessageBoxButtons.OK);
            }


            if(br_power == DialogResult.OK)
            {
                string sql_canlendbk = string.Format("select dbo.ReaderType.CanLendQty from dbo.ReaderType where ReaderType.rdType = (select rdType from dbo.Reader where rdID = '{0}')", rd.rdID);
                int rd_canlendbk = Convert.ToInt32(Reader_ad.rd_sel(sql_canlendbk));
                string sql_allendbk = string.Format("select rdBorrowQty from dbo.reader where rdID = '{0}'", rd.rdID);
                int rd_allendbk = Convert.ToInt32(Reader_ad.rd_sel(sql_allendbk));
                
                if (rd_allendbk<rd_canlendbk)
                {
                    bk.bkStatus = "借出";//Book对象状态
                    rd.rdBorrowQty = string.Format("{0}", ++rd_allendbk);//Reader对象更改后书籍数量
                    if (Borrow_ad.run_insql(br, 0))
                    {
                        Reader_ad.run_insql(rd, 2);//更新读者已借书本数
                        Book_ad.run_insql(bk, 1);//更新Reader rd书本状态
                        MessageBox.Show(string.Format("\"{0}\"借阅\"{1}\"成功!", rd.rdName, bk.bkName), "lol", MessageBoxButtons.OK);
                    }
                    rd_refresh_Click(null, null);
                    bk_refresh_Click(null, null);
                }
                else
                    MessageBox.Show(string.Format("\"{0}\"借阅\"{1}\"失败!", rd.rdName, bk.bkName), "lol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            br = new Borrow();// 清空borrow对象数据


        }
        //------------------------------------------------borrowbook---------------------------------------------------------
        //------------------------------------------------returnbook---------------------------------------------------------

        private void fill_borrow_b()
        {
            br.BorrowID = tb_BorrowID_b.Text;
            br.bkID = tb_bkID_b.Text;
            br.rdID = tb_rdID_b.Text;
            DataRow dr = null;
            if (br.BorrowID.Equals("") != true)
            {
                string sql = string.Format("select * from dbo.borrow where BorrowID = '{0}'", br.BorrowID);
                br.bkID = dr["bkID"].ToString();
                br.rdID = dr["rdID"].ToString();
            }
            else if (br.bkID.Equals("") != true)
            {
                string sql = string.Format("select * from dbo.borrow where bkID = '{0}'", br.bkID);
                dr = Borrow_ad.runsql(sql).Rows[0];
                br.BorrowID = dr["BorrowID"].ToString();
                br.rdID = dr["rdID"].ToString();
            }
            else if (br.rdID.Equals("") != true)
            {
                string sql = string.Format("select * from dbo.borrow where rdID = '{0}'", br.rdID);
                dr = Borrow_ad.runsql(sql).Rows[0];
                br.bkID = dr["bkID"].ToString();
                br.BorrowID = dr["BorrowID"].ToString();
            }
            else
            { return; }

            br.IdContinueTimes = dr["IdContinueTimes"].ToString();
            br.ldDateOut = dr["ldDateOut"].ToString();
            br.ldDateRetPlan = dr["ldDateRetPlan"].ToString();
            br.OperatorLend = dr["OperatorLend"].ToString();

            br.ldDateRetAct = tb_ldDateRetAct.Text;
            br.IsHasReturn = true;
            br.OperatorRet = admin.rdID;

            DateTime rtd = Convert.ToDateTime(match(tb_ldDateRetAct.Text));
            string sql_ldd = string.Format("Select ldDateOut from dbo.borrow where BorrowID = '{0}'", br.BorrowID);
            DateTime ldd = Convert.ToDateTime(match(Borrow_ad.runsql(sql_ldd).Rows[0][0]));
            br.ldOverDay = DateTime.Compare(rtd, ldd) > 0 ? rtd.Subtract(ldd).ToString() : "0";




        }
        private void return_btn_Click(object sender, EventArgs e)
        {

            if (rb_return_bk.Checked == false)
            {
                rb_return_bk.Checked = true;
                MessageBox.Show("请重新选择读者和书本", "qoq", MessageBoxButtons.OK);
            }
            else
            {
                fill_borrow_b();
                if (br.BorrowID.Equals("") || br.bkID.Equals("") || br.rdID.Equals(""))
                {
                    MessageBox.Show("请输入(借阅号 或 书本号 或 读者号)", "qoq", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                DialogResult rt_power = DialogResult.Cancel;
                rt_power = MessageBox.Show("可以还书，确定退还？(Y?N)", "lol", MessageBoxButtons.OKCancel);
                if (rt_power == DialogResult.OK)
                {
                    if (Borrow_ad.run_insql(br, 1))
                    {
                        bk.bkStatus = "在馆";
                        string sql_allendbk = string.Format("select rdBorrowQty from dbo.reader where rdID = '{0}'", rd.rdID);
                        int rd_allendbk = Convert.ToInt32(Reader_ad.rd_sel(sql_allendbk));
                        rd.rdBorrowQty = string.Format("{0}", --rd_allendbk);
                        Console.WriteLine(string.Format("{0}", --rd_allendbk));
                        Book_ad.run_insql(bk, 1);//更新Reader rd书本状态
                        Reader_ad.run_insql(rd, 2);//更新读者已借书本数
                        MessageBox.Show(string.Format("\"{0}\"退还\"{1}\"成功!", rd.rdName, bk.bkName), "lol", MessageBoxButtons.OK);
                        rd_refresh_Click(null, null);
                        bk_refresh_Click(null, null);
                    }
                    else
                        MessageBox.Show(string.Format("\"{0}\"退还\"{1}\"失败!", rd.rdName, bk.bkName), "lol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                br = new Borrow();// 清空borrow对象数据
                                  
            }
        }
        //------------------------------------------------returnbook---------------------------------------------------------

        //添加借阅号快捷事件
        private void tb_BorrowID_MouseDown(object sender, MouseEventArgs e)
        {
            String sql = "select count(*) from dbo.borrow";
            int k = Convert.ToInt32(Borrow_ad.runsql(sql).Rows[0][0]) + 1;
            tb_BorrowID.Text = string.Format("{0}",k);
            Console.WriteLine(k);
        }
    }
}

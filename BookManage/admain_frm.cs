using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using BookManage.Model;
using BookManage.BLL;
using System.Text.RegularExpressions;


namespace BookManage
{
    public partial class admain_frm : Form
    {
        Reader admin = null;
        //login_frm ffrm = null;
        DataTable reader_data = null;
        Reader_ad reader_ad = new Reader_ad();
        Reader rd = new Reader();
        Borrow br = new Borrow();
        ReaderType rt = new ReaderType();
        //private string datepattern = @"(\d*\/\d*\/\d*)";


        public admain_frm(Reader rd)
        {
            InitializeComponent();
            //admin_pic.BackgroundImage = Image.FromFile(admin.rdPhoto);
            admin = rd;
            //ffrm = frm;
            btn_reader_Click(null,null);
        }
        //功能按钮选择
        //---------------------------------------------------------------------------------------读者管理---------------------------------------------------------------------------------------
        private void btn_reader_Click(object sender, EventArgs e)
        {
            p_main_bookmg.Visible = false;
            p_main_borrowmg.Visible = false;
            p_main_readermg.Visible = true;
            p_main_readertypemg.Visible = false;
            this.Text = "读者管理";
            rd_choose.Text = "查询";
            rd_refresh_btn_Click(null, null);
        }
        /*读者面板点击事件
                            rd = Reader_ad.Row2rd((data_rd.CurrentRow.DataBoundItem as DataRowView).Row);
                            rd2tbox(rd);*/
        private void data_rd_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rd = Reader_ad.Row2rd((data_rd.CurrentRow.DataBoundItem as DataRowView).Row);
            rd2tbox(rd);
        }
        //Reader对象填充到数据框
        private void rd2tbox(Reader rd)
        {
            tb_rdID.Text = rd.rdID.ToString();
            tb_rdPwd.Text = rd.rdPwd.ToString();
            tb_rdType.Text = rd.rdType.ToString();
            tb_rdName.Text = rd.rdName.ToString();
            tb_rdSex.Text = rd.rdSex.ToString();
            tb_rdDept.Text = rd.rdDept.ToString();
            tb_rdStatus.Text = rd.rdStatus.ToString();
            l_rdPhoto.Image = rd.rdPhoto.Equals("") ? null : Image.FromFile(rd.rdPhoto.ToString());
            tb_rdPhoto.Text = rd.rdPhoto.ToString();
            tb_rdDateReg.Text = rd.rdDateReg.ToString();
            tb_rdEmail.Text = rd.rdEmail.ToString();
            tb_rdPhone.Text = rd.rdPhone.ToString();
            tb_rdQQ.Text = Convert.ToString(rd.rdQQ);
            tb_rdAdminRoles.Text = Convert.ToString(rd.rdAdminRoles);
        }
        //数据框内容转Reader对象
        private void tbox2rd()
        {
            try
            {
                rd.rdID = tb_rdID.Text;
                rd.rdPwd = tb_rdPwd.Text;
                rd.rdType = tb_rdType.Text;
                rd.rdName = tb_rdName.Text;
                rd.rdSex = tb_rdSex.Text;
                rd.rdDept = tb_rdDept.Text;
                rd.rdStatus = tb_rdStatus.Text;
                rd.rdPhoto = tb_rdPhoto.Text;
                rd.rdDateReg = tb_rdDateReg.Text;
                rd.rdEmail = tb_rdEmail.Text;
                rd.rdPhone = tb_rdPhone.Text;
                rd.rdQQ = tb_rdQQ.Text;
                rd.rdBorrowQty = Reader_ad.rd_sel("select CanLendQty from dbo.ReaderType where rdType = '" + rd.rdType + "'");
                rd.rdAdminRoles = tb_rdAdminRoles.Text;
            }catch
            {
                
                MessageBox.Show("fail","qoq",MessageBoxButtons.OK);
            } 
        }
        //刷新按钮
        private void rd_refresh_btn_Click(object sender, EventArgs e)
        {
            reader_data = Reader_ad.data_rd_fill();
            data_rd.DataSource = reader_data;
            rd_select_choose.Text = "rdID";
        }
        //执行按钮
        private void r_btn_Click(object sender, EventArgs e)
        {
            
            tbox2rd();
            string choose = rd_choose.Text;
            try
            {
                
                switch (choose)
                {
                    case "插入": Reader_ad.run_insql(rd, 0); rd_refresh_btn_Click(null, null); MessageBox.Show("Success", "lol", MessageBoxButtons.OK); break;
                    case "删除": Reader_ad.run_insql(rd, 1); rd_refresh_btn_Click(null, null); MessageBox.Show("Success", "lol", MessageBoxButtons.OK); break;
                    case "更新": Reader_ad.run_insql(rd, 2); rd_refresh_btn_Click(null, null); MessageBox.Show("Success", "lol", MessageBoxButtons.OK); break;
                    case "查询": r_select(string.Format("select * from dbo.reader where {0} like '{1}'",rd_select_choose.Text,rd_select_text.Text));break;
                }
                
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message,"qoq",MessageBoxButtons.OK);
                
            }
            

        }
        private void r_select(string sql)
        {
            reader_data = Reader_ad.rd_select(sql);
            
            data_rd.DataSource = reader_data;
        }
        //上传照片按钮
        private void rd_pic_btn_Click(object sender, EventArgs e)
        {
            string path = "";
            string fileName = "";
            OpenFileDialog fd = new OpenFileDialog();

            fd.Filter = "(*.jpg,*.png,*.jpeg,*.bmp,*.gif)|*.jpg;*.png;*.jpeg;*.bmp;*.gif";
            DialogResult result = fd.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = fd.FileName;
                fileName = fd.SafeFileName;
                l_rdPhoto.Image = Image.FromFile(path);
                tb_rdPhoto.Text = path;
                
                
            }
        }
        //---------------------------------------------------------------------------------------读者管理---------------------------------------------------------------------------------------
        
        //---------------------------------------------------------------------------------------借阅管理---------------------------------------------------------------------------------------
        private void btn_borrow_Click(object sender, EventArgs e)
        {
            p_main_bookmg.Visible = false;
            p_main_borrowmg.Visible = true;
            p_main_readermg.Visible = false;
            p_main_readertypemg.Visible = false;
            this.Text = "借阅管理";

            br_refresh_Click(null,null);
        }


        private void br_refresh_Click(object sender, EventArgs e)
        {
            data_br.DataBindings.Clear();
            data_br.DataSource = Borrow_ad.br_data();
            br_select_choose.Text = "BorrowID";
            br_choose.Text = "查询";
        }

        private void data_br_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            br = Borrow_ad.Row2rd((data_br.CurrentRow.DataBoundItem as DataRowView).Row);
            br2tbox(br);
        }

        private void br2tbox(Borrow br)
        {

            tb_BorrowID.Text = br.BorrowID.ToString();
            b_tb_rdID.Text = br.rdID.ToString();
            b_tb_bkID.Text = br.bkID.ToString();
            
            tb_IdContinueTimes.Text = br.IdContinueTimes.ToString();
            tb_ldDateOut.Text = br.ldDateOut.ToString();
            tb_ldDateRetPlan.Text = br.ldDateRetPlan.ToString();
            tb_ldDateRetAct.Text = br.ldDateRetAct.ToString();
            tb_ldOverDay.Text = br.ldOverDay.ToString();
            tb_ldOverMoney.Text = br.ldOverMoney.ToString();
            tb_IsHasReturn.Text = br.IsHasReturn.ToString();
            tb_OperatorLend.Text = br.OperatorLend.ToString();
            tb_OperatorRet.Text = br.OperatorRet.ToString();


        }
        private void tbox2br()
        {
            br.BorrowID = tb_BorrowID.Text;
            br.rdID = b_tb_rdID.Text;
            br.bkID = b_tb_bkID.Text;
            br.IdContinueTimes = tb_IdContinueTimes.Text;
            br.ldDateOut = tb_ldDateOut.Text;
            br.ldDateRetPlan = tb_ldDateRetPlan.Text;
            br.ldDateRetAct = tb_ldDateRetAct.Text;
            br.ldOverDay = tb_ldOverDay.Text;
            br.ldOverMoney = tb_ldOverMoney.Text;
            br.ldPunishMoney = null;
            br.IsHasReturn = tb_IsHasReturn.Text;
            br.OperatorLend = tb_OperatorLend.Text;
            br.OperatorRet = tb_OperatorRet.Text;
        }
        private void br_select(string sql)
        {
            data_br.DataBindings.Clear();
            data_br.DataSource = Borrow_ad.runsql(sql);
        }
        private void excutebtn_btn_Click(object sender, EventArgs e)
        {
            tbox2br();
            string choose = br_choose.Text;
            try
            {

                switch (choose)
                {
                    case "插入": Borrow_ad.run_insql(br, 0); br_refresh_Click(null, null); MessageBox.Show("Success", "lol", MessageBoxButtons.OK); break;
                    case "更新": Borrow_ad.run_insql(br, 1); br_refresh_Click(null, null); MessageBox.Show("Success", "lol", MessageBoxButtons.OK); break;
                    case "删除": Borrow_ad.run_insql(br, 2); br_refresh_Click(null, null); MessageBox.Show("Success", "lol", MessageBoxButtons.OK); break;
                    case "查询": br_select(string.Format("select * from dbo.borrow where {0} like '{1}'", br_select_choose.Text, br_select_text.Text)); break;
                }

            }
            catch
            {
                MessageBox.Show("Fail", "qoq", MessageBoxButtons.OK);
            }

        }
        //---------------------------------------------------------------------------------------借阅管理---------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------读者类型管理---------------------------------------------------------------------------------------
        private void btn_readertype_Click(object sender, EventArgs e)
        {
            p_main_bookmg.Visible = false;
            p_main_borrowmg.Visible = false;
            p_main_readermg.Visible = false;
            p_main_readertypemg.Visible = true;
            this.Text = "读者类型管理";
            rdtp_choose.Text = "查询";
            rdtp_refresh_Click(null, null);
        }

        private void data_readertype_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void rdtp_select(string sql)
        {
            data_readertype.DataBindings.Clear();
            data_readertype.DataSource = ReaderType_ad.runsql(sql);
        }

        private void rdtp_excutebtn_Click(object sender, EventArgs e)
        {
            tbox2rdtp();
            string choose = rdtp_choose.Text;
            try
            {

                switch (choose)
                {
                    case "插入": ReaderType_ad.run_insql(rt, 0); rdtp_refresh_Click(null, null); MessageBox.Show("Success", "lol", MessageBoxButtons.OK); break;
                    case "更新": ReaderType_ad.run_insql(rt, 1); rdtp_refresh_Click(null, null); MessageBox.Show("Success", "lol", MessageBoxButtons.OK); break;
                    case "删除": ReaderType_ad.run_insql(rt, 2); rdtp_refresh_Click(null, null); MessageBox.Show("Success", "lol", MessageBoxButtons.OK); break;
                    case "查询": rdtp_select(string.Format("select * from dbo.readertype where {0} like '{1}'", rdtp_select_choose.Text, rdtp_select_text.Text)); break;
                }

            }
            catch
            {
                MessageBox.Show("Fail", "qoq", MessageBoxButtons.OK);
            }
        }

        private void rdtp_refresh_Click(object sender, EventArgs e)
        {
            data_readertype.DataBindings.Clear();
            data_readertype.DataSource = ReaderType_ad.br_data();
            rdtp_select_choose.Text = "rdType";
            rdtp_choose.Text = "查询";
        }
        private void tbox2rdtp()
        {

            rt.rdType = tb_rdtp_rdType.Text;
            rt.rdTypeName = tb_rdTypeName.Text;
            rt.CanLendQty = tb_CanLendQty;
            rt.CanLendDay = tb_CanLendDay;
            rt.CanContinueTimes = tb_CanContinueTimes;
            rt.PunishRate = tb_PunishRate;
            rt.DateValid = tb_DateValid;
        }
        private void rdtp2tbox(ReaderType rt)
        {
            tb_rdtp_rdType.Text = rt.rdType.ToString() ;
            tb_rdTypeName.Text = rt.rdTypeName.ToString() ;
            tb_CanLendQty.Text = rt.CanLendQty.ToString();
            tb_CanLendDay.Text = rt.CanLendDay.ToString() ;
            tb_CanContinueTimes.Text = rt.CanContinueTimes.ToString() ;
            tb_PunishRate.Text = rt.PunishRate.ToString() ;
            tb_DateValid.Text = rt.DateValid.ToString() ;
        }

        private void data_readertype_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rt = ReaderType_ad.Row2rdtp((data_readertype.CurrentRow.DataBoundItem as DataRowView).Row);
            rdtp2tbox(rt);
        }

        //---------------------------------------------------------------------------------------读者类型管理---------------------------------------------------------------------------------------


        //---------------------------------------------------------------------------------------书本管理---------------------------------------------------------------------------------------
        private void btn_book_Click(object sender, EventArgs e)
        {
            p_main_bookmg.Visible = true;
            p_main_borrowmg.Visible = false;
            p_main_readermg.Visible = false;
            p_main_readertypemg.Visible = false;
            this.Text = "书本管理";
            bk_refresh_Click(null,null);

        }


        private void bk_refresh_Click(object sender, EventArgs e)
        {
            //bk_data.AutoGenerateColumns = false;
            data_bk.DataBindings.Clear();
            data_bk.DataSource = Book_ad.bk_data();
        }
    }
}

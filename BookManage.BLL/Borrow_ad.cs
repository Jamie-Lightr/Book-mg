using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BookManage.DAL;
using BookManage.Model;

namespace BookManage.BLL
{
    public class Borrow_ad
    {
        private static Sq_h sq = new Sq_h();
        public static DataTable rd_data()
        {
            //rdID,rdName,rdSex,rdStatus,rdEmail,rdPhone,rdQQ,rdBorrowQty
            string sql = "select * from dbo.reader"; ;
            return sq.od_run_t(sql);
        }
        public static Object bk_check(Book bk)
        {
            string sql = string.Format("select bkStatus from dbo.book where bkID = '{0}'", bk.bkID);
            return Sq_h.run_ro(sql);
        }
        
        public static DataTable bk_data()
        {
            //bkID 书本号,bkName 书本名,bkAuthor 作者,bkPress 出版社,bkDatePress 出版日期,bkLanguage 语言,bkStatus 书本状态,bkCover 封面 
            string sql = "select * from dbo.book";
            return sq.od_run_t(sql);
        }
        public static DataTable runsql(string sql)
        {
            return sq.od_run_t(sql);
        }

        public static DataTable br_data()
        {
            string sql = "select * from dbo.Borrow";
            return sq.od_run_t(sql);
        }
        public static bool run_insql(Borrow br, int i)
        {
            switch (i)
            {
                case 0: return BorrowDAL.ex_insert_insql(br);
                case 1: return BorrowDAL.ex_update_insql(br);
                case 2: return BorrowDAL.ex_delete_insql(br);
                default: return false;
            }
        }
        public static Borrow Row2rd(DataRow t)
        {

            Borrow br = new Borrow();
            br.BorrowID = t["BorrowID"].ToString();
            br.rdID = t["rdID"].ToString();
            br.bkID = t["bkID"].ToString();
            br.IdContinueTimes = t["IdContinueTimes"].ToString();
            br.ldDateOut = t["ldDateOut"].ToString();
            br.ldDateRetPlan = t["ldDateRetPlan"].ToString();
            br.ldDateRetAct = t["ldDateRetAct"].ToString();
            br.ldOverDay = t["ldOverDay"].ToString();
            br.ldOverMoney = t["ldOverMoney"].ToString();
            br.ldPunishMoney = t["ldPunishMoney"].ToString();
            br.IsHasReturn = t["IsHasReturn"].ToString();
            br.OperatorLend = t["OperatorLend"].ToString();
            br.OperatorRet = t["OperatorRet"].ToString(); 
            //t[""].ToString();
            return br;
        }

    }
}

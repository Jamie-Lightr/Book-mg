using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookManage.DAL;
using BookManage.Model;
using System.Data.SqlClient;
using System.Data;

namespace BookManage.BLL
{
    public class Book_ad
    {
        private static Sq_h sq = new Sq_h();
        public static Book Row2bk(DataRow t)
        {
            
            Book bk = new Book();


            bk.bkID = t["bkID"].ToString();
            bk.bkCode = t["bkCode"].ToString();
            bk.bkName = t["bkName"].ToString();
            bk.bkAuthor = t["bkAuthor"].ToString();
            bk.bkPress = t["bkPress"].ToString();
            bk.bkDatePress = t["bkDatePress"].ToString();
            bk.bkLanguage = t["bkLanguage"].ToString();
            bk.bkPages = t["bkPages"].ToString();
            bk.bkPrice = t["bkPrice"].ToString();
            bk.bkDateIn = t["bkDateIn"].ToString();
            bk.bkBrief = t["bkBrief"].ToString();
            bk.bkCover = t["bkCover"].ToString();
            bk.bkStatus = t["bkStatus"].ToString();
            return bk;
        }
        public static bool run_insql(Book bk, int i)
        {
            switch (i)
            {
                case 0: return BookDAL.ex_insert_insql(bk);
                case 1: return BookDAL.ex_update_insql(bk);
                case 2: return BookDAL.ex_delete_insql(bk);
                default: return false;
            }
        }
        public static DataTable bk_data()
        {
            //bkID 书本号,bkName 书本名,bkAuthor 作者,bkPress 出版社,bkDatePress 出版日期,bkLanguage 语言,bkStatus 书本状态,bkCover 封面 
            string sql = "select * from dbo.book";
            return sq.od_run_t(sql);
        }
    }
}

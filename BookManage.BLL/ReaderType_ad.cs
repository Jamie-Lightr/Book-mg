using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookManage.DAL;
using BookManage.Model;
using System.Data;
using System.Data.SqlClient;

namespace BookManage.BLL
{
    public class ReaderType_ad
    {
        static Sq_h sq = new Sq_h();
        public static ReaderType Row2rdtp(DataRow t)
        {
            ReaderType rt = new ReaderType();
            rt.rdType = t["rdType"].ToString();
            rt.rdTypeName = t["rdTypeName"].ToString();
            rt.CanLendQty = t["CanLendQty"].ToString();
            rt.CanLendDay = t["CanLendDay"].ToString();
            rt.CanContinueTimes = t["CanContinueTimes"].ToString();
            rt.PunishRate = t["PunishRate"].ToString();
            rt.DateValid = t["DateValid"].ToString(); 

            return rt;
        }
        public static DataTable runsql(string sql)
        {
            return sq.od_run_t(sql);
        }

        public static DataTable br_data()
        {
            string sql = "select * from dbo.readertype";
            return sq.od_run_t(sql);
        }

        public static bool run_insql(ReaderType rt, int i)
        {
            switch (i)
            {
                case 0: return ReaderTypeDAL.ex_insert_insql(rt);
                case 1: return ReaderTypeDAL.ex_update_insql(rt);
                case 2: return ReaderTypeDAL.ex_delete_insql(rt);
                default: return false;
            }
        }
    }
}

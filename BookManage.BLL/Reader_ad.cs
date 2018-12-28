using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookManage.Model;
using BookManage.DAL;
using BookManage.BLL;
using System.Data;

namespace BookManage.BLL
{
    public class Reader_ad
    {
        ReaderDAL rd_dal = new ReaderDAL();
        static Reader rd = new Reader();
        //static Reader_o rdo = new Reader_o();
        static DAL.Sq_h a = new DAL.Sq_h();
        public bool check_login(Reader c)
        {
            rd_dal.fill(Convert.ToInt32(c.rdID));
            if (rd_dal.rd.rdPwd.Equals(c.rdPwd))
            {

                return true;
            }
            else
            {
                return false;
            }

        }
        public static Reader fill(Reader rd)
        {
            ReaderDAL rdal = new ReaderDAL();
            
            return rdal.fill(Convert.ToInt32(rd.rdID));
        }
        /*
    public bool check_login(Reader c)
    {
        rd_dal.fill(c.rdID);

        if (rd_dal.rd.rdPwd == c.rdPwd)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    */

        public Dictionary<string, object> rd2dic(Reader r)
        {
            Dictionary<string, object> k = new Dictionary<string, object>();
            k.Add("rdID", r.rdID);
            k.Add("rdPwd", r.rdPwd);
            k.Add("rdType", r.rdType);
            k.Add("rdName", r.rdName);
            k.Add("rdSex", r.rdSex);
            k.Add("rdDept", r.rdDept);
            k.Add("rdStatus", r.rdStatus);
            k.Add("rdPhoto", r.rdPhoto);
            k.Add("rdDateReg", r.rdDateReg);
            k.Add("rdEmail", r.rdEmail);
            k.Add("rdPhone", r.rdPhone);
            k.Add("rdQQ", r.rdQQ);
            k.Add("rdBorrowQty", r.rdBorrowQty);
            k.Add("rdAdminRoles", r.rdAdminRoles);
            return k;
        }

        public Reader rd_fill(Reader c)
        {
            return rd_dal.fill(Convert.ToInt32(c.rdID));
        }

        public static DataTable data_rd_fill()
        {
            return a.od_run_re("select * from dbo.Reader").Tables[0];
        }

        public static Reader Row2rd(DataRow t)
        {
           
            Reader rd = new Reader();
            rd.rdID = Convert.ToInt32(t["rdID"]);
            rd.rdPwd = t["rdPwd"].ToString();
            rd.rdType = Convert.ToInt32(t["rdType"]);
            rd.rdName = t["rdName"].ToString();
            rd.rdSex = t["rdSex"].ToString();
            rd.rdDept = t["rdDept"].ToString();
            rd.rdStatus = t["rdStatus"].ToString();
            rd.rdPhoto = t["rdPhoto"].ToString();
            rd.rdDateReg = Convert.ToDateTime(t["rdDateReg"]);
            rd.rdEmail = t["rdEmail"].ToString();
            rd.rdPhone = t["rdPhone"].ToString();
            rd.rdQQ = Convert.ToInt32(t["rdQQ"]);
            rd.rdBorrowQty = Convert.ToInt32(t["rdBorrowQty"]);
            rd.rdAdminRoles = Convert.ToInt32(t["rdAdminRoles"]);
            return rd;
        }

        public static object rd_sel(string k)
        {
            return Sq_h.run_ro(k);
        }

        public static DataTable rd_select(string k)
        {
            return a.od_run_re(k).Tables[0];
        }

        public static bool run_insql(Reader rd,int k)
        {
            switch (k)
            {
                case 0: return ReaderDAL.rd_insert_insql(rd); 
                case 1: return ReaderDAL.rd_delete_insql(rd); 
                case 2: return ReaderDAL.rd_update_insql(rd);
                default:return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookManage.Model;
using System.Data;
using System.Text.RegularExpressions;

namespace BookManage.DAL
{
    public class ReaderDAL
    {
        public Reader rd = new Reader();

        Sq_h sq = new Sq_h();
        static string datepattern = @"(\d*\/\d*\/\d*)";
        public ReaderDAL()
        {
            
        }
        /*
        /// <summary>
        /// 根据Reader的id，填充Reader对象各值
        /// </summary>
        /// <param name="id">Reader id</param>
        /// <returns>返回Reader对象</returns>
        public Reader fill(int id)
        {
            string sql = "select * from dbo.reader where rdID = '"+id+"'";      
            DataTable t = sq.od_run_t(sql);
            rd.rdID = Convert.ToInt32(t.Rows[0]["rdID"]);
            rd.rdPwd = t.Rows[0]["rdPwd"].ToString();
            rd.rdType = Convert.ToInt32(t.Rows[0]["rdType"]);
            rd.rdName = t.Rows[0]["rdName"].ToString();
            rd.rdSex = t.Rows[0]["rdSex"].ToString();
            rd.rdDept = t.Rows[0]["rdDept"].ToString();
            rd.rdStatus = t.Rows[0]["rdStatus"].ToString();
            rd.rdPhoto = t.Rows[0]["rdPhoto"].ToString();
            rd.rdDateReg = Convert.ToDateTime(t.Rows[0]["rdDateReg"]);
            rd.rdEmail = t.Rows[0]["rdEmail"].ToString();
            rd.rdPhone = t.Rows[0]["rdPhone"].ToString();
            rd.rdQQ = Convert.ToInt32(t.Rows[0]["rdQQ"]);
            rd.rdBorrowQty = Convert.ToInt32(t.Rows[0]["rdBorrowQty"]);
            rd.rdAdminRoles = Convert.ToInt32(t.Rows[0]["rdAdminRoles"]);

            return rd;
        }
        */
        public Reader fill(int id)
        {
            
            string sql = string.Format("select * from dbo.reader where rdID = '{0}'", id);
            DataTable t = sq.od_run_t(sql);
            rd.rdID = t.Rows[0]["rdID"];
            rd.rdPwd = t.Rows[0]["rdPwd"];
            rd.rdType = t.Rows[0]["rdType"];
            rd.rdName = t.Rows[0]["rdName"];
            rd.rdSex = t.Rows[0]["rdSex"];
            rd.rdDept = t.Rows[0]["rdDept"];
            rd.rdStatus = t.Rows[0]["rdStatus"];
            rd.rdPhoto = t.Rows[0]["rdPhoto"];
            rd.rdDateReg = t.Rows[0]["rdDateReg"];
            rd.rdEmail = t.Rows[0]["rdEmail"];
            rd.rdPhone = t.Rows[0]["rdPhone"];
            rd.rdQQ = t.Rows[0]["rdQQ"];
            rd.rdBorrowQty = t.Rows[0]["rdBorrowQty"];
            rd.rdAdminRoles = t.Rows[0]["rdAdminRoles"];

            return rd;
        }
        public static string match(object t)
        {
            string k = null;
            foreach (Match m in Regex.Matches(Convert.ToString(t), datepattern))
            {
                k = k + m.Value;
            }
            return k;
        }

        public static DataSet rd_select_insql(string k)
        {
            DataSet re = null ;



            return re;
        }

        public static bool rd_insert_insql(Reader r)
        {

            string sql = "Insert into dbo.reader (rdID,rdPwd,rdType,rdName,rdSex,rdDept,rdStatus,rdPhoto,rdDateReg,rdEmail,rdPhone,rdQQ,rdBorrowQty,rdAdminRoles) values ('"
                +r.rdID+"','"
                +r.rdPwd+"','"
                +r.rdType+"','"
                +r.rdName+"','"
                +r.rdSex+"','"
                +r.rdDept+"','"
                +r.rdStatus+"','"
                +r.rdPhoto+"','"
                +ReaderDAL.match(r.rdDateReg)+"','"
                +r.rdEmail+"','"
                +r.rdPhone+"','"
                +r.rdQQ+"','"
                +r.rdBorrowQty+"','" 
                +r.rdAdminRoles
                +"')";
            return Sq_h.run_rn(sql)==1 ? true : false;

        }

        public static bool rd_update_insql(Reader r)
        {
            
            string sql = string.Format(
                "Update dbo.reader set rdPwd='{0}',rdType='{1}',rdName='{2}',rdSex='{3}',rdDept='{4}',rdStatus='{5}',rdPhoto='{6}',rdDateReg='{7}',rdEmail='{8}',rdPhone='{9}',rdQQ='{10}',rdBorrowQty='{11}',rdAdminRoles='{12}' where rdID='{13}'",
                r.rdPwd,r.rdType, r.rdName, r.rdSex, r.rdDept, r.rdStatus, r.rdPhoto, ReaderDAL.match(r.rdDateReg), r.rdEmail, r.rdPhone, r.rdQQ, r.rdBorrowQty, r.rdAdminRoles, r.rdID);
            //Console.WriteLine(sql);
            return Sq_h.run_rn(sql) == 1 ? true : false;

        }

        public static bool rd_delete_insql(Reader r)
        {
            string sql = "Delete from dbo.reader where rdID = '" + r.rdID + "'";
            return Sq_h.run_rn(sql) != 1 ? false : true;
        }

    }
}

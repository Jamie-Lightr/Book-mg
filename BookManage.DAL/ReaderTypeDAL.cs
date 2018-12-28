using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BookManage.Model;


namespace BookManage.DAL
{
    public class ReaderTypeDAL
    {
        public static bool ex_insert_insql(ReaderType rt)
        {
            try
            {
                Sq_h.run_rn(string.Format(
                    "Insert into dbo.readertype (rdType,rdTypeName,CanLendQty,CanLendDay,CanContinueTimes,PunishRate,DateValid) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                    rt.rdType,rt.rdTypeName,rt.CanLendQty,rt.CanLendDay,rt.CanContinueTimes,rt.PunishRate,rt.DateValid
                    ));
                    return true;
            }
            catch (SqlException e)
            {
                return false;
                throw new Exception(e.Message);
            }
        }
        public static bool ex_update_insql(ReaderType rt)
        {
            try
            {
                Sq_h.run_rn(string.Format(
                    "Update dbo.readertype set rdTypeName = '{0}' , CanLendQty = '{1}',CanLendDay = '{2}',CanContinueTimes = '{3}',PunishRate = '{4}',DateValid = '{5}',where rdType = '{6}'",
                    rt.rdTypeName, rt.CanLendQty, rt.CanLendDay, rt.CanContinueTimes, (float)Convert.ToSingle(rt.PunishRate), rt.DateValid, rt.rdType
                     ));
                return true;
            }
            catch (SqlException e)
            {
                return false;
                throw new Exception(e.Message);
            }
        }
        public static bool ex_delete_insql(ReaderType rt)
        {
            try
            {
                Sq_h.run_rn(string.Format(
                    "Delete from dbo.ReaderType where rdType = '{0}')",
                    rt.rdType));
                return true;
            }
            catch (SqlException e)
            {
                return false;
                throw new Exception(e.Message);
            }
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BookManage.Model;

namespace BookManage.DAL
{
    public class BorrowDAL
    {
        public static bool ex_insert_insql(Borrow br)
        {
           
            try
            {
                Sq_h.run_rn(string.Format(
                    "Insert into dbo.borrow (BorrowID,rdID,bkID,IdContinueTimes,ldDateOut,ldDateRetPlan,ldDateRetAct,ldOverDay,ldOverMoney,ldPunishMoney,IsHasReturn,OperatorLend,OperatorRet) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')",
                    br.BorrowID,br.rdID,br.bkID,br.IdContinueTimes,Sq_h.match(br.ldDateOut), Sq_h.match(br.ldDateRetPlan), Sq_h.match(br.ldDateRetAct),br.ldOverDay,br.ldOverMoney,br.ldPunishMoney,br.IsHasReturn,br.OperatorLend,br.OperatorRet));
                return true;
            }
            catch(SqlException e)
            {
                return false;
                throw new Exception(e.Message);
            }
            
        }
        public static bool ex_update_insql(Borrow br)
        {
            try
            {
                Sq_h.run_rn(string.Format(
                    "Update dbo.borrow set rdID = '{0}',bkID = '{1}',IdContinueTimes = '{2}',ldDateOut = '{3}',ldDateRetPlan = '{4}',ldDateRetAct  = '{5}',ldOverDay  = '{6}',ldOverMoney  = '{7}',ldPunishMoney = '{8}',IsHasReturn = '{9}',OperatorLend = '{10}',OperatorRet = '{11}' where BorrowID = '{12}'",
                     br.rdID, br.bkID, br.IdContinueTimes, Sq_h.match(br.ldDateOut), Sq_h.match(br.ldDateRetPlan), Sq_h.match(br.ldDateRetAct), br.ldOverDay, br.ldOverMoney, br.ldPunishMoney, br.IsHasReturn, br.OperatorLend, br.OperatorLend, br.BorrowID));
                return true;
            }
            catch (SqlException e)
            {
                return false;
                throw new Exception(e.Message);
            }
        }

        public static bool ex_delete_insql(Borrow br)
        {
            try
            {
                Sq_h.run_rn(string.Format(
                    "Delete from dbo.borrow where BorrowID = '{0}')",
                    br.BorrowID));
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

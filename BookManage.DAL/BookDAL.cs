using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BookManage.Model;

namespace BookManage.DAL
{
    public class BookDAL
    {
        public static bool ex_insert_insql(Book bk)
        {
            try
            {
                Sq_h.run_rn(string.Format(
                    "Insert into dbo.book (bkID,bkCode,bkName,bkAuthor,bkPress ,bkDatePress,bkLanguage,bkPages,bkPrice, bkDateIn,bkBrief,bkCover,bkStatus) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')",
                   bk.bkID,bk.bkCode,bk.bkName,bk.bkAuthor,bk.bkPress , Sq_h.match(bk.bkDatePress),bk.bkLanguage,bk.bkPages,bk.bkPrice, Sq_h.match(bk.bkDateIn),bk.bkBrief,bk.bkCover, bk.bkStatus
                    ));
                return true;
            }
            catch (SqlException e)
            {
                return false;
                throw new Exception(e.Message);
            }

        }
        public static bool ex_update_insql(Book bk)
        {
            try
            {
                Sq_h.run_rn(string.Format(
                    "Update dbo.book Set bkCode='{0}',bkName='{1}',bkAuthor='{2}',bkPress ='{3}',bkDatePress='{4}',bkLanguage='{5}',bkPages='{6}',bkPrice='{7}', bkDateIn='{8}',bkBrief='{9}',bkCover='{10}',bkStatus = '{11}' where bkID = '{12}'",
                    bk.bkCode, bk.bkName, bk.bkAuthor, bk.bkPress, Sq_h.match(bk.bkDatePress),  bk.bkLanguage, bk.bkPages, bk.bkPrice, Sq_h.match(bk.bkDateIn), bk.bkBrief, bk.bkCover, bk.bkStatus, bk.bkID
                    ));
                return true;
            }
            catch (SqlException e)
            {
                return false;
                throw new Exception(e.Message);
            }

        }
        public static bool ex_delete_insql(Book bk)
        {
            try
            {
                Sq_h.run_rn(string.Format(
                    "Delete from dbo.book where bkID = '{0}'",bk.bkID
                    ));
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

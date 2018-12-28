using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace BookManage.DAL
{
    public class Sq_h
    {
        static String connsql = "server=.;database=BooksDB;integrated security=true";
        private static String _constr = "server=.;database=BooksDB;integrated security=true";
        private static SqlConnection conn = new SqlConnection(_constr);

        public static SqlDataAdapter sda = null;
        static DataSet re = null;
        static DataTable dt = null;
        static SqlCommand SCD = null;

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

        //--------------------------------------------old-------------------------------------------------//
        /// <summary>
        /// 运行sql语句并返回Dataset对象
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>DataSet对象</returns>
        public DataSet od_run_re(string sql)
        {
            try
            {
                sda = new SqlDataAdapter(sql, connsql);
                re = new DataSet();
                sda.Fill(re);
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            return re;
        }
        /// <summary>
        /// 运行sql语句并返回DataTable对象
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>DataSet对象</returns>
        public DataTable od_run_t(string sql)
        {
            try
            {
                sda = new SqlDataAdapter(sql, connsql);
                re = new DataSet();
                sda.Fill(re);
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            
            return re.Tables[0];
        }

        public void od_cls_conn()
        {
            conn_C();
        }
        
        //--------------------------------------------old-------------------------------------------------//
        

        
        /// <summary>
        /// 打开数据库连接
        /// </summary>
        private static void conn_O()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch
            {
                throw new Exception("数据库连接失败");
            }
        }
        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        private static void conn_C()
        {
            if(conn != null)
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
        }


        /// <summary>
        /// 无参数运行sql语句
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>受影响记录数据</returns>
        public static int run_rn(string sql)
        {
            int rows = 0;
            try
            {
                conn_O();
                SqlCommand cmd = new SqlCommand(sql, conn);
                rows = cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
                
            }
            finally
            {
                conn_C();
            }
            return rows;
        }
        /// <summary>
        /// 带参数运行sql语句
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="values">参数集合</param>
        /// <returns>受影响记录数据</returns>
        public static int run_rn(string sql, SqlParameter[] values)
        {
            int rows = 0;
            if (values != null)
            {
                try
                {
                    conn_O();
                    SqlCommand cmd = new SqlCommand(sql,conn);
                    foreach(SqlParameter v in values)
                    {
                        cmd.Parameters.Add(v);
                    }
                    rows = cmd.ExecuteNonQuery();
                }
                catch(SqlException e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    conn_C();
                }
            }
            return rows;
        }
        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>结果集中的首行首列</returns>
        public static Object run_ro(string sql)
        {
            Object result = null;
            try
            {
                conn_O();
                SqlCommand cmd = new SqlCommand(sql,conn);
                result = cmd.ExecuteScalar();
            }
            catch(SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conn_C();
            }
            return result;
        }
        /// <summary>
        /// 运行带参数sql语句
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="value">参数集合</param>
        /// <returns>结果集首行首列</returns>
        public static Object run_ro(string sql, SqlParameter[] value)
        {
            Object result = null;
            try
            {
                conn_O();
                SqlCommand cmd = new SqlCommand(sql, conn);
                if(value != null)
                {
                    foreach(SqlParameter v in value)
                    {
                        cmd.Parameters.Add(v);
                    }
                }
                result = cmd.ExecuteScalar();
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conn_C();
            }
          
            return result;
        }


























    }
}


























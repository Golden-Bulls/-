using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace 三菱查询系统
{
    class SQL_Helper
    {
        private string sqlconnectstring;//定义数据库连接字符串
        /// <summary>
        /// 构造函数
        /// 初始化连接数据库参数
        /// </summary>
        public SQL_Helper()
        {
            sqlconnectstring = "server=192.168.1.154;database=Mitsubishi_System;uid=sa; pwd=123456;Timeout=3";
        }

        /// <summary>
        /// 数据库打开
        /// </summary>
        /// <param name="sql"></param>
        public void Open(SqlConnection sql)
        {
            if (sql.State == ConnectionState.Closed)
            {
                sql.Open();
            }
        }

        /// <summary>
        /// 数据库关闭
        /// </summary>
        /// <param name="sql"></param>
        public void Close(SqlConnection sql)
        {
            if (sql != null)
            {
                if (sql.State == ConnectionState.Open)
                {
                    sql.Close();
                }
                sql.Dispose();

            }
        }

        /// <summary>
        /// 检查查询数据是否存在
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool Result_Exist(string str)
        {
            SqlConnection sql = new SqlConnection(sqlconnectstring);
            SqlCommand command = new SqlCommand();
            try
            {
                Open(sql);
                command = new SqlCommand(str, sql);
                return command.ExecuteReader().Read();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            finally
            {
                command.Dispose();
                Close(sql);
            }
        }

        /// <summary>
        /// 查询数据的第一行第一列数据
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string Frist_Data(string str)
        {
            SqlConnection sql = new SqlConnection(sqlconnectstring);
            SqlCommand command = new SqlCommand();
            try
            {
                Open(sql);
                command = new SqlCommand(str, sql);
                return command.ExecuteScalar().ToString().Trim();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            finally
            {
                command.Dispose();
                Close(sql);

            }
        }

        /// <summary>
        /// 查询数据库返回数据集
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public SqlDataReader SqlData(string str)
        {
            SqlConnection sql = new SqlConnection(sqlconnectstring);
            SqlCommand command = new SqlCommand();
            try
            {
                Open(sql);
                command = new SqlCommand(str, sql);
                return command.ExecuteReader(CommandBehavior.CloseConnection);//如果想要返回对象前不关闭数据库连接，须要用CommandBehavior.CloseConnection
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            finally
            {
                command.Dispose();
                Close(sql);

            }
        }

        /// <summary>
        /// 返回查询结果
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public DataSet DataSet(string str)
        {
            SqlConnection sql = new SqlConnection(sqlconnectstring);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            try
            {
                Open(sql);
                dataAdapter = new SqlDataAdapter(str, sql);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                return ds;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                dataAdapter.Dispose();
                Close(sql);

            }
        }

        /// <summary>
        /// 返回查询结果
        /// </summary>
        /// <param name="str"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public DataSet DataSet(string str, string tableName)
        {
            SqlConnection sql = new SqlConnection(sqlconnectstring);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            try
            {
                Open(sql);
                dataAdapter = new SqlDataAdapter(str, sql);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, tableName);
                return ds;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                dataAdapter.Dispose();
                Close(sql);
            }
        }

        /// <summary>
        /// 查询（DataTable）
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public DataTable GetDT(string str)
        {
            return DataSet(str).Tables[0];
        }

        /// <summary>
        /// 查询（DataView）
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public DataView GetDV(string str)
        {
            return DataSet(str).Tables[0].DefaultView;
        }

        /// <summary>
        /// 影响的行数
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int RunSql(string str)
        {
            SqlConnection sql = new SqlConnection(sqlconnectstring);
            SqlCommand command = new SqlCommand();
            try
            {
                Open(sql);
                command = new SqlCommand(str, sql);
                return command.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            finally
            {
                command.Dispose();
                Close(sql);
            }
        }

        /// <summary>
        /// 增改，有图片
        /// </summary>
        /// <param name="strSql"></param>
        /// <param name="picbyte"></param>
        /// <returns></returns>
        public int RunSql(string strSql, byte[] picbyte)
        {
            SqlConnection cn = new SqlConnection(sqlconnectstring);
            SqlCommand cmd = new SqlCommand();
            try
            {
                Open(cn);
                cmd = new SqlCommand(strSql, cn);
                cmd.Parameters.Add("@Image", SqlDbType.Image);
                cmd.Parameters["@Image"].Value = picbyte;
                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cmd.Dispose();
                Close(cn);
            }
        }

    }
}

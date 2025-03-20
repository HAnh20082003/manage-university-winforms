using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MangerUniversity
{
    public class SQL
    {
        public static string strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=ManageUniversity;Integrated Security=True";
        private static SqlConnection sqlCon;
        private static void CreateConnect()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strConnection);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }
        public static void CloseConnect()
        {
            sqlCon.Close();
        }
        public static object Excute_A_Value(string codeSQL,List<string> parameters,List<object> values)
        {
            CreateConnect();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = codeSQL;
            if (parameters != null)
            {
                for (int i = 0;i<parameters.Count;i++)
                {
                    sqlcmd.Parameters.AddWithValue(parameters[i], values[i]);
                }
            }
            sqlcmd.Connection = sqlCon;
            return sqlcmd.ExecuteScalar();
        }
        public static DataTable Excute_Values(string codeSQL, List<string> parameters, List<object> values)
        {
            CreateConnect();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = codeSQL;
            if (parameters != null)
            {
                for (int i = 0; i < parameters.Count; i++)
                {
                    sqlcmd.Parameters.AddWithValue(parameters[i], values[i]);
                }
            }
            sqlcmd.Connection = sqlCon;
            SqlDataReader reader = sqlcmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            return table;
        }
        public static void Excute_Non_Value(string codeSQL, List<string> parameters, List<object> values)
        {
            CreateConnect();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = codeSQL;
            if (parameters != null)
            {
                for (int i = 0; i < parameters.Count; i++)
                {
                    sqlcmd.Parameters.AddWithValue(parameters[i], values[i]);
                }
            }
            sqlcmd.Connection = sqlCon;
            sqlcmd.ExecuteNonQuery();
        }
    }
}

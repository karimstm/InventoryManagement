using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace InventoryManagment.DAL
{
    class DataAccessLayer
    {
        public static String stringConnection = @"Data Source = .; Initial Catalog=INVENTORY; integrated security = SSPI";
        public static SqlConnection cn;

        //Open Connection
        public static void Open()
        {
            cn = new SqlConnection(stringConnection);
            cn.Open();
        }

        //Close Connection
        public static void Close()
        {
            cn = new SqlConnection(stringConnection);
            cn.Close();
        }

        //Return One value
        public static object ExecuteScalar(String Query, CommandType type, params SqlParameter[] arr)
        {
            SqlCommand cmd = new SqlCommand(Query, cn);
            cmd.Parameters.AddRange(arr);
            cmd.CommandType = type;
            object o = cmd.ExecuteScalar();
            return o;

        }

        //Return the number of line affected
        public static int ExecuteNonQuery(String Query, CommandType type, params SqlParameter[] arr)
        {
            SqlCommand cmd = new SqlCommand(Query, cn);
            cmd.Parameters.AddRange(arr);
            cmd.CommandType = type;
            int count = cmd.ExecuteNonQuery();
            return count;
        }

        //Return a table
        public static DataTable ExecuteTable(String Query, CommandType type, params SqlParameter[] arr)
        {
            SqlCommand cmd = new SqlCommand(Query, cn);
            cmd.Parameters.AddRange(arr);
            cmd.CommandType = type;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        
        //Return the params
        public static SqlParameter CreateParameter(String Name, SqlDbType type, object value)
        {
            SqlParameter pr = new SqlParameter();
            pr.ParameterName = Name;
            pr.SqlDbType = type;
            pr.SqlValue = value;
            return pr;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using InventoryManagment.DAL;



namespace InventoryManagment.BL
{
    class LoginClass
    {
        /// <summary>
        /// Return a table containing authentication
        /// </summary>
        /// <param name="username">User Name</param>
        /// <param name="password">Password</param>
        /// <returns>return a datatable</returns>
        public static DataTable SP_SELECTLOGIN(string username, string password)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_LOGINSELECT", CommandType.StoredProcedure, 
                DataAccessLayer.CreateParameter("@username", SqlDbType.NVarChar, username),
                DataAccessLayer.CreateParameter("@password", SqlDbType.NVarChar, password));
            DataAccessLayer.Close();
            return dt;

        }
    }
}

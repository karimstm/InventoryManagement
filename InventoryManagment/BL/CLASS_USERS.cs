using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagment.DAL;
using System.Data;

namespace InventoryManagment.BL
{
    class CLASS_USERS
    {
        public static int SP_ADDNEWUSER(string username, string password, string fullname, int per_id)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_ADDNEWUSER", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@USERNAME", SqlDbType.NVarChar, username),
                DataAccessLayer.CreateParameter("@PASSWORD", SqlDbType.NVarChar, password),
                DataAccessLayer.CreateParameter("@FULLNAME", SqlDbType.NVarChar, fullname),
                DataAccessLayer.CreateParameter("@PERM_ID", SqlDbType.Int, per_id));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable SP_FULLCMBPERM()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_FULLCMBPERM", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SP_DISPLAYALLUSERS()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_DISPLAYALLUSERS", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SP_SEARCHUSERS(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SEARCHUSERS", CommandType.StoredProcedure, 
                DataAccessLayer.CreateParameter("@SEARCH", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();
            return dt;
        }

        public static int SP_DELETEUSER(int id)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_DELETEUSER", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }

        public static int SP_UPDATEUSERS(int id, string username, string password, string fullname, int permission)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_UPDATEUSERS", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID", SqlDbType.Int, id),
                DataAccessLayer.CreateParameter("@USERNAME", SqlDbType.NVarChar, username),
                DataAccessLayer.CreateParameter("@USERPASSWORD", SqlDbType.NVarChar, password),
                DataAccessLayer.CreateParameter("@FULLNAME", SqlDbType.NVarChar, fullname),
                DataAccessLayer.CreateParameter("@permission", SqlDbType.Int, permission));
            DataAccessLayer.Close();
            return i;

        }

        public static DataTable SP_DISPLAYALLUSERSBYID(int ID)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_DISPLAYALLUSERSBYID", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID", SqlDbType.Int, ID));
            DataAccessLayer.Close();
            return dt;
        }
    }
}

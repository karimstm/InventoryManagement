using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagment.DAL;
using System.Data;
namespace InventoryManagment.BL
{
    class CLASS_MARQUE
    {

        public static int SP_ADDNEWBRAND(String Nom)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_ADDNEWBRAND", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Nom", SqlDbType.NVarChar, Nom));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable SP_DISPLAYBRANDALL()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_DISPLAYBRANDALL", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SP_SEARCHBRAND(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SEARCHBRAND", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SEARCH", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();
            return dt;
        }

        public static int SP_UPDATEBRAND(int ID ,string Name)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_UPDATEBRAND", CommandType.StoredProcedure, 
                DataAccessLayer.CreateParameter("@Brand_ID", SqlDbType.Int, ID),
                DataAccessLayer.CreateParameter("@Brand_Name", SqlDbType.NVarChar, Name));
            DataAccessLayer.Close();
            return i;
        }

        public static int SP_DELETEBRAND(int ID)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_DELETEBRAND", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Brand_ID", SqlDbType.Int, ID));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable SP_SELECTBRANDBYID(int ID)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SELECTBRANDBYID", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Brand_ID", SqlDbType.Int, ID));
            DataAccessLayer.Close();
            return dt;
        }

    }
}

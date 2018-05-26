using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagment.DAL;
using System.Data;

namespace InventoryManagment.BL
{
    class CLASS_CATEGORY
    {
        public static int SP_ADDCATEGORY(string nom)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_ADDCATEGORY", CommandType.StoredProcedure, 
                DataAccessLayer.CreateParameter("@Cat_Name", SqlDbType.NVarChar, nom));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable SP_CATEGORYSELECTALL()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_CATEGORYSELECTALL", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SP_CATEGORYSEARSH(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_CATEGORYSEARSH", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SEARCH", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();
            return dt;
        }

        public static int SP_CATEGORYUPDATE(int id, string nom)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_CATEGORYUPDATE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID_Cat", SqlDbType.BigInt, id),
                DataAccessLayer.CreateParameter("@Nom_Cat", SqlDbType.NVarChar, nom));
            DataAccessLayer.Close();
            return i;

        }

        public static int SP_CATEGORYDELTE(int id)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_CATEGORYDELTE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID_Cat", SqlDbType.BigInt, id));
            DataAccessLayer.Close();
            return i;
        }
    }
}

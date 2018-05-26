using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagment.DAL;
using System.Data;

namespace InventoryManagment.BL
{
    class CLASS_ETAT
    {
        public static int SP_ADDNEWETAT(string Nom_etat)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_ADDNEWETAT", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@NOM_ETAT", SqlDbType.NVarChar, Nom_etat));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable SP_DISPLAYALLETAT()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_DISPLAYALLETAT", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SP_SELECTETATBYID(int Ref)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SELECTETATBYID", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@REF", SqlDbType.BigInt, Ref));
            DataAccessLayer.Close();
            return dt;
        }
        public static int SP_UPDATEETAT(int Ref, string Nom)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_UPDATEETAT", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@REF", SqlDbType.BigInt, Ref),
                DataAccessLayer.CreateParameter("@NOM_ETAT", SqlDbType.NVarChar, Nom));
            DataAccessLayer.Close();
            return i;

        }

        public static int SP_DELETEETAT(int Ref)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_DELETEETAT", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@REF", SqlDbType.BigInt, Ref));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable SP_SEARCHETAT(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SEARCHETAT", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SEARCH", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
    }
}

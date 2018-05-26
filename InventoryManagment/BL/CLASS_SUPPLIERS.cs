using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagment.DAL;
using System.Data;
namespace InventoryManagment.BL
{
    class CLASS_SUPPLIERS
    {
        public static int SP_ADDNEWSUPPLIER(string name, string phone, string fax, string email, string adress, string country)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_ADDNEWSUPPLIER", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Supplier_Name", SqlDbType.NVarChar, name),
                DataAccessLayer.CreateParameter("@Supplier_Phone", SqlDbType.NVarChar, phone),
                DataAccessLayer.CreateParameter("@Supplier_Fax", SqlDbType.NVarChar, fax),
                DataAccessLayer.CreateParameter("@Supplier_Email", SqlDbType.NVarChar, email),
                DataAccessLayer.CreateParameter("@ADRESS", SqlDbType.NVarChar, adress),
                DataAccessLayer.CreateParameter("@Supplier_Country", SqlDbType.NVarChar, country));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable SP_SUPPLIERSELECTALL()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SUPPLIERSELECTALL", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static int SP_SUPPLIERUPDATE(int ID, string name, string phone, string fax, string email, string adress, string country)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_SUPPLIERUPDATE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Supplier_ID", SqlDbType.Int, ID),
                DataAccessLayer.CreateParameter("@Supplier_Name", SqlDbType.NVarChar, name),
                DataAccessLayer.CreateParameter("@Supplier_Phone", SqlDbType.NVarChar, phone),
                DataAccessLayer.CreateParameter("@Supplier_Fax", SqlDbType.NVarChar, fax),
                DataAccessLayer.CreateParameter("@Supplier_Email", SqlDbType.NVarChar, email),
                DataAccessLayer.CreateParameter("@ADRESS", SqlDbType.NVarChar, adress),
                DataAccessLayer.CreateParameter("@Supplier_Country", SqlDbType.NVarChar, country));
            DataAccessLayer.Close();
            return i;
        }

        public static int SP_SUPPLIERDELETE(int id)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_SUPPLIERDELETE", CommandType.StoredProcedure, 
                DataAccessLayer.CreateParameter("@Supplier_ID", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable SP_SUPPLIERSEARCH(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SUPPLIERSEARCH", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SEARCH", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();
            return dt;
            
        }
    }
}

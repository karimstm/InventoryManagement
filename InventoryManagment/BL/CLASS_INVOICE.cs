using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagment.DAL;
using System.Data;

namespace InventoryManagment.BL
{
    class CLASS_INVOICE
    {
        public static int SP_INVOICEINSERT(string I_REF, DateTime date, Decimal total, int supplierID, string buyername, DataTable invoicedetail)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_INVOICEINSERT", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@I_REF", SqlDbType.NVarChar, I_REF),
                DataAccessLayer.CreateParameter("@I_Date", SqlDbType.DateTime, date),
                DataAccessLayer.CreateParameter("@I_Total", SqlDbType.Decimal, total),
                DataAccessLayer.CreateParameter("@Supplie_ID", SqlDbType.Int, supplierID),
                DataAccessLayer.CreateParameter("@Buyer_Name", SqlDbType.NVarChar, buyername),
                DataAccessLayer.CreateParameter("@INVOICEDET", SqlDbType.Structured, invoicedetail));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable SP_DISPLAYALLINVOICE()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_DISPLAYALLINVOICE", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static int SP_DELETEINVOICE(int id)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_DELETEINVOICE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable SP_SEARCHINVOICE(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SEARCHINVOICE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SEARCH", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();
            return dt;
        }

        public static int SP_MAXIDINVOICE()
        {
            DataAccessLayer.Open();
            int i = Convert.ToInt32(DataAccessLayer.ExecuteScalar("SP_MAXINVOICE", CommandType.StoredProcedure));
            DataAccessLayer.Close();
            return i;
        }
    }
}

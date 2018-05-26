using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagment.DAL;
using System.Data;

namespace InventoryManagment.BL
{
    class CLASS_PRODUCTS
    {
        public static DataTable SP_FILLCMBCATEGORY()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_FILLCMBCATEGORY", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SP_FILLCMBBRAND()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_FILLCMBBRAND", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SP_FILLCMBETAT()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_FILLCMBETAT", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable SP_FILLCMBWAREHOUSE()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_FILLCMBWAREHOUSE", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SP_FILLCMSUPPLIER()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_FILLCMSUPPLIER", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static int SP_ADDNEWPRODUCTS(int Brand_ID,int Cat_ID, byte[] P_Image, string P_Name,
           string P_Description, double P_Price, string Serial_Number, string U_Name, int WareHouse_ID,
           bool leased, object lease_Expire, string Delivered_BY, DateTime Acquisition_Date, DateTime EXPIRE_DATE, int State_ID)
        {

            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_ADDNEWPRODUCTS", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Brand_ID", SqlDbType.Int, Brand_ID),
                DataAccessLayer.CreateParameter("@Cat_ID", SqlDbType.Int, Cat_ID),
                DataAccessLayer.CreateParameter("@P_Image", SqlDbType.Image, P_Image),
                DataAccessLayer.CreateParameter("@P_Name", SqlDbType.NVarChar, P_Name),
                DataAccessLayer.CreateParameter("@P_Description", SqlDbType.NVarChar, P_Description),
                DataAccessLayer.CreateParameter("@P_Price", SqlDbType.Decimal, P_Price),
                DataAccessLayer.CreateParameter("@Serial_Number", SqlDbType.NVarChar, Serial_Number),
                DataAccessLayer.CreateParameter("@U_Name", SqlDbType.NVarChar, U_Name),
                DataAccessLayer.CreateParameter("@WareHouse_ID", SqlDbType.Int, WareHouse_ID),
                DataAccessLayer.CreateParameter("@leased", SqlDbType.Bit, leased),
                DataAccessLayer.CreateParameter("@lease_Expire", SqlDbType.DateTime, lease_Expire),
                DataAccessLayer.CreateParameter("@Delivered_BY", SqlDbType.NVarChar, Delivered_BY),
                DataAccessLayer.CreateParameter("@Acquisition_Date", SqlDbType.DateTime, Acquisition_Date),
                DataAccessLayer.CreateParameter("@EXPIRE_DATE", SqlDbType.DateTime, EXPIRE_DATE),
                DataAccessLayer.CreateParameter("@State_ID", SqlDbType.Int, State_ID));
            DataAccessLayer.Close();
            return i;
                
        }


       

        public static DataTable SP_DISPLAYALLPRODUCTSBYID(int ID)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_DISPLAYALLPRODUCTSBYID", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID", SqlDbType.Int, ID));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SP_DISPLAYALLPRODUCTS_LESSDETAILS()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_DISPLAYALLPRODUCTS_LESSDETAILS", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable SP_SEARCHPRODUCT(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SEARCHPRODUCT", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SEARCH", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();
            return dt;
        }

        public static byte[] SP_PRODUCTGETIMAGE(int id)
        {
            DataAccessLayer.Open();
            byte[] Arr = (byte[])DataAccessLayer.ExecuteScalar("SP_PRODUCTGETIMAGE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return Arr;
        }

        public static int SP_UPDATEPRODUCTS(int Brand_ID, int Cat_ID, byte[] P_Image, string P_Name,
           string P_Description, double P_Price, string Serial_Number, string U_Name, int WareHouse_ID,
           bool leased, object lease_Expire, string Delivered_BY, DateTime Acquisition_Date, DateTime EXPIRE_DATE, int State_ID)
        {

            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_UPDATEPRODUCTS", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Brand_ID", SqlDbType.Int, Brand_ID),
                DataAccessLayer.CreateParameter("@Cat_ID", SqlDbType.Int, Cat_ID),
                DataAccessLayer.CreateParameter("@P_Image", SqlDbType.Image, P_Image),
                DataAccessLayer.CreateParameter("@P_Name", SqlDbType.NVarChar, P_Name),
                DataAccessLayer.CreateParameter("@P_Description", SqlDbType.NVarChar, P_Description),
                DataAccessLayer.CreateParameter("@P_Price", SqlDbType.Decimal, P_Price),
                DataAccessLayer.CreateParameter("@Serial_Number", SqlDbType.NVarChar, Serial_Number),
                DataAccessLayer.CreateParameter("@U_Name", SqlDbType.NVarChar, U_Name),
                DataAccessLayer.CreateParameter("@WareHouse_ID", SqlDbType.Int, WareHouse_ID),
                DataAccessLayer.CreateParameter("@leased", SqlDbType.Bit, leased),
                DataAccessLayer.CreateParameter("@lease_Expire", SqlDbType.DateTime, lease_Expire),
                DataAccessLayer.CreateParameter("@Delivered_BY", SqlDbType.NVarChar, Delivered_BY),
                DataAccessLayer.CreateParameter("@Acquisition_Date", SqlDbType.DateTime, Acquisition_Date),
                DataAccessLayer.CreateParameter("@EXPIRE_DATE", SqlDbType.DateTime, EXPIRE_DATE),
                DataAccessLayer.CreateParameter("@State_ID", SqlDbType.Int, State_ID));
            DataAccessLayer.Close();
            return i;

        }

        public static int SP_DELETEPRODUCTS(int id)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_DELETEPRODUCTS", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable SP_DISPLAYALLPRODUCTSBYQUANTITY()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_DISPLAYALLPRODUCTSBYQUANTITY", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SP_DISPLAYALLPRODUCTS()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_DISPLAYALLPRODUCTS", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
    }
}

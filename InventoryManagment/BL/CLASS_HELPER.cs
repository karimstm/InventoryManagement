using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using InventoryManagment.DAL;

namespace InventoryManagment.BL
{
    class CLASS_HELPER
    {
        public static void Backup_DB(string path)
        {
            DataAccessLayer.Open();
            string Query = string.Format("BACKUP DATABASE INVENTORY TO DISK = '{0}'", path);
            DataAccessLayer.ExecuteNonQuery(Query, CommandType.Text);
            DataAccessLayer.Close();

        }

        public static void Restore(string path)
        {
            DataAccessLayer.stringConnection = @"Data Source = SORASENPAI; Initial Catalog=master; integrated security = SSPI";
            DataAccessLayer.Open();
            string Query = string.Format("ALTER DATABASE INVENTORY SET OFFLINE WITH ROLLBACK IMMEDIATE; RESTORE DATABASE INVENTORY FROM DISK = '{0}'", path);
            DataAccessLayer.ExecuteNonQuery(Query, CommandType.Text);
            DataAccessLayer.Close();
        }
    }
}

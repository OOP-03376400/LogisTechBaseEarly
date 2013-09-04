using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace InventoryMSystem
{
    public class dbInitializer
    {
        static bool bDBInitialized = false;
        public static string dbPath = "Data Source=personCheck.db3";


        public static bool InitialDB()
        {
            if (!bDBInitialized)
            {
                ConfigManager.InitialConfigDB();
                bDBInitialized = true;
            }
            return true;
        }

    }
}

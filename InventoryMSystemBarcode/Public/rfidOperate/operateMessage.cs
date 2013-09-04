using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMSystemBarcode
{
    public class operateMessage
    {
        public string status;
        public string message;
        public operateMessage(string status,string message)
        {
            this.status = status;
            this.message = message;
        }
    }
}

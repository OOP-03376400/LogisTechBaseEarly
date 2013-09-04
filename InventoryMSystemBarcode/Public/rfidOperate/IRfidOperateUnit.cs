using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMSystemBarcode
{
    public interface IRfidOperateUnit
    {
        void registeCallback(deleRfidOperateCallback callback);
        void OperateStart();
    }
}

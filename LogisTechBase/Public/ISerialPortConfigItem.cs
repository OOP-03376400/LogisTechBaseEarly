﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LogisTechBase
{
    public interface ISerialPortConfigItem
    {
        string GetItemValue(string itemName);
        //void SaveConfigItem();
        void SaveConfigItem(
            string portName, string baudRate, 
            string parity, string dataBits, string stopBits);
    }
}

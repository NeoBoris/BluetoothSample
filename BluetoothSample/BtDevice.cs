using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BluetoothSample
{
    public class BtDevice
    {
        public String Name { get; set; }
        public String Address { get; set; }

        public BtDevice (String inName, String inAddress)
        {
            Name = inName;
            Address = inAddress;
        }
    }
}
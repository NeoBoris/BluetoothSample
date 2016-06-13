using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluetoothSample
{
    public interface IBtManager
    {
        void Init();
        List<BtDevice> GetPairedDevices();
        List<BtDevice> GetAvailableDevices();
        void StartDiscovery();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluetoothSample
{
    public interface IBluetoothChatter
    {
        void Init();
        List<String> GetPairedDevices();
        void StartDiscovery();
    }
}

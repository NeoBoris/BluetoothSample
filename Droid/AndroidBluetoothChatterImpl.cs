using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Bluetooth;

namespace BluetoothSample.Droid
{
    public class AndroidBluetoothChatterImpl : IBluetoothChatter
    {
        // éQçl: https://github.com/xamarin/monodroid-samples/blob/master/BluetoothChat/DeviceListActivity.cs
        private BluetoothAdapter m_btAdapter;
        private static List<string> m_pairedDevicesArrayAdapter;
        private static List<string> m_newDevicesArrayAdapter;
        private Receiver m_receiver;

        public void Init()
        {
            m_btAdapter = BluetoothAdapter.DefaultAdapter;
            m_pairedDevicesArrayAdapter = new List<string> ();
            m_newDevicesArrayAdapter = new List<string>();
            //m_receiver = new Receiver();

        }

        public List<String> GetPairedDevices()
        {
            List<String> devices = new List<String>();

            var pairedDevices = m_btAdapter.BondedDevices;
            foreach (var device in pairedDevices)
            {
                devices.Add(device.Name + "\n" + device.Address);
            }
            return devices;
        }

        public void StartDiscovery()
        {
            if (m_btAdapter.IsDiscovering)
            {
                m_btAdapter.CancelDiscovery();
            }

            m_btAdapter.StartDiscovery();
        }

        public class Receiver : BroadcastReceiver
        {
            //Activity _chat;

            public Receiver() //(Activity chat)
            {
                //_chat = chat;
            }

            public override void OnReceive(Context context, Intent intent)
            {
                string action = intent.Action;

                // When discovery finds a device
                if (action == BluetoothDevice.ActionFound)
                {
                    // Get the BluetoothDevice object from the Intent
                    BluetoothDevice device = (BluetoothDevice)intent.GetParcelableExtra(BluetoothDevice.ExtraDevice);
                    // If it's already paired, skip it, because it's been listed already
                    if (device.BondState != Bond.Bonded)
                    {
                        m_newDevicesArrayAdapter.Add(device.Name + "\n" + device.Address);
                    }
                    // When discovery is finished, change the Activity title
                }
                else if (action == BluetoothAdapter.ActionDiscoveryFinished)
                {
                    //_chat.SetProgressBarIndeterminateVisibility(false);
                    //_chat.SetTitle(Resource.String.select_device);
                    if (m_newDevicesArrayAdapter.Count == 0)
                    {
                        //var noDevices = _chat.Resources.GetText(Resource.String.none_found).ToString();
                        var noDevices = "NO DEVICES";
                        m_newDevicesArrayAdapter.Add(noDevices);
                    }
                }
            }
        }
    }
}
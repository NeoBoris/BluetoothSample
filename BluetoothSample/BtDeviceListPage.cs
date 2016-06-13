using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace BluetoothSample
{
    public class BtDeviceListPage : ContentPage
    {
        private BtDeviceListView m_BtDeviceListView;
        private IBtManager m_Bluetooth;

        public BtDeviceListPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "これは２番目の画面です。戻るにはナビゲーションバーの左矢印をタップしてね。" },
                    (m_BtDeviceListView = new BtDeviceListView())
                }
            };

            //  ネイティブの実装クラスを取得
            m_Bluetooth = DependencyService.Get<IBtManager>();


            for (int i = 0; i < 10; i++)
            {
                m_BtDeviceListView.DeviceList.Add(new BtDevice("Test" + i, "Address" + i));
            }
        }
    }
}

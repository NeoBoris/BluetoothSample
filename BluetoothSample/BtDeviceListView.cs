using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BluetoothSample
{
    public class BtDeviceListView : ListView
    {
        List<BtDevice> m_DeviceList;
        public List<BtDevice> DeviceList { get { return m_DeviceList; } }
        public BtDeviceListView ()
        {
            m_DeviceList =  new List<BtDevice>();
            ItemsSource = m_DeviceList;

            ItemTemplate = new DataTemplate(() =>
            {
                Label nameLabel = new Label();
                nameLabel.SetBinding(Label.TextProperty, "Name");

                Label addressLabel = new Label();
                addressLabel.SetBinding(Label.TextProperty, "Address");

                BoxView boxView = new BoxView();
                boxView.Color = new Color (1, 0, 0);

                // Return an assembled ViewCell.
                return new ViewCell
                {
                    View = new StackLayout
                    {
                        Padding = new Thickness(0, 5),
                        Orientation = StackOrientation.Horizontal,
                        Children =
                                {
                                    boxView,
                                    new StackLayout
                                    {
                                        VerticalOptions = LayoutOptions.Center,
                                        Spacing = 0,
                                        Children =
                                        {
                                            nameLabel,
                                            addressLabel
                                        }
                                    }
                                }
                    }
                };
            });

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace BluetoothSample
{
    public class MyFirstPage : ContentPage
    {
        public MyFirstPage()
        {
            var btnTest1 = new Button { Text = "ボタンのテスト（２番目の画面へ）" };
            btnTest1.Clicked += OnButtonTestClicked;

            Content = new StackLayout
            {
                Children = {
                    new Label {
                        XAlign = TextAlignment.Center,
                        Text = "Welcome to Xamarin Forms!"
                    },
                    new Label { Text = "これは最初の画面です。" },
                    btnTest1
                }
            };
        }

        public void OnButtonTestClicked (object o, EventArgs e)
        {
            Navigation.PushAsync(new MySecondPage());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace BluetoothSample
{
    public class MySecondPage : ContentPage
    {
        IBluetoothChatter m_Chatter;

        public MySecondPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "これは２番目の画面です。戻るにはナビゲーションバーの左矢印をタップしてね。" }
                }
            };

            //  ネイティブの実装クラスを取得
            m_Chatter = DependencyService.Get<IBluetoothChatter>();

        }
    }
}

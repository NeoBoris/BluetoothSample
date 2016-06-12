using System;

using Xamarin.Forms;

namespace BluetoothSample
{
	public class App : Application
	{
        public const string NativeNavigationMessage = "BluetoothSample.NativeNavigationMessage";

        public App ()
		{
            // 参考: https://github.com/xamarin/xamarin-forms-samples/tree/master/Forms2Native

            NavigationPage mainNav = new NavigationPage(new MyFirstPage());

            MainPage = mainNav;
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}


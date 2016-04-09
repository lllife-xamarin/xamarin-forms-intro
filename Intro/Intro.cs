using System;

using Xamarin.Forms;

namespace Intro
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			var content = new ContentPage {
				Content = new Label {
					Text = "Hello, Form!",
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand
				}
			};

			MainPage = new NavigationPage (new StackLayoutExample());
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


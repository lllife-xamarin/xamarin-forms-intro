using System;
using Xamarin.Forms;

namespace Intro
{
	public class ListViewExample: ContentPage
	{
		public ListViewExample ()
		{
			var listView = new ListView ();
			listView.ItemsSource = new string [] {
				"Buy pears", "Buy oranges", "Buy mangos", "Buy apples", "Buy bananas"
			};

			Content = new StackLayout {
				Children = { listView }
			};
		}
	}
}


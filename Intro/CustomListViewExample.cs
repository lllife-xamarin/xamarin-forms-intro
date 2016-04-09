using System;
using Xamarin.Forms;

namespace Intro
{
	public class CustomListViewExample: ContentPage
	{
		public CustomListViewExample ()
		{
			var listView = new ListView ();
			listView.ItemsSource = new TodoItem [] {
				new TodoItem { Name = "Buy pears" },
				new TodoItem { Name = "Buy oranges", Done=true} ,
				new TodoItem { Name = "Buy mangos" },
				new TodoItem { Name = "Buy apples", Done=true },
				new TodoItem { Name = "Buy bananas", Done=true }
			};
			listView.ItemTemplate = new DataTemplate (typeof (TextCell));
			listView.ItemTemplate.SetBinding (TextCell.TextProperty, "Name");
			listView.ItemSelected += async (s, e) => {
				var todoItem = (TodoItem)e.SelectedItem;
				await DisplayAlert ("Tapped!", todoItem.Name + " was tapped.", "OK");
			};

			Content = new StackLayout {
				Children = { listView }
			};
		}
	}

	class TodoItem
	{
		public string Name { set; get; }
		public bool Done { set; get; }
	}
}


using System.Collections.Generic;
using Xamarin.Forms;

namespace Intro
{
	public class CustomListViewCellExample : ContentPage {
		public CustomListViewCellExample()
		{
			var customers = GetCustomers ();
			var listView = new ListView {
				RowHeight = 40,
				ItemsSource = customers,
				ItemTemplate = new DataTemplate (typeof (CustomerCell))
			};

			Content = listView;
		}

		private List<Customer> GetCustomers()
		{
			return new List<Customer> {
				new Customer {
					DisplayName = "Jannine Weigel",
					ImageUri = "https://pbs.twimg.com/profile_images/716123364813721600/igCb7gS1_400x400.jpg",
					Twitter = "@JanninaWMusic"
				},
				new Customer {
					DisplayName = "Jannine Weigel",
					ImageUri = "https://pbs.twimg.com/profile_images/716123364813721600/igCb7gS1_400x400.jpg",
					Twitter = "@JanninaWMusic"
				}, 
				new Customer {
					DisplayName = "Jannine Weigel",
					ImageUri = "https://pbs.twimg.com/profile_images/716123364813721600/igCb7gS1_400x400.jpg",
					Twitter = "@JanninaWMusic"
				}
			};
		}
	}

	public class CustomerCell : ViewCell  {
		public CustomerCell() {
			var image = new Image {
				HorizontalOptions = LayoutOptions.Start
			};

			image.SetBinding (Image.SourceProperty, new Binding ("ImageUri"));
			image.WidthRequest = image.HeightRequest = 40;

			var nameLayout = CreateNameLayout ();
			var viewLayout = new StackLayout () {
				Orientation = StackOrientation.Horizontal,
				Children = { image, nameLayout }
			};

			View = viewLayout;
		}

		static StackLayout CreateNameLayout () {
			var nameLabel = new Label {
				HorizontalOptions = LayoutOptions.Fill
			};
			nameLabel.SetBinding (Label.TextProperty, "DisplayName");

			var twitterLabel = new Label {
				HorizontalOptions = LayoutOptions.Fill,
				HeightRequest = 12,
				FontSize = 12
			};
			twitterLabel.SetBinding (Label.TextProperty, "Twitter");

			var nameLayout = new StackLayout () {
				HorizontalOptions = LayoutOptions.StartAndExpand,
				Orientation = StackOrientation.Vertical,
				Children = { nameLabel, twitterLabel }
			};

			return nameLayout;
		}
	}

	public class Customer {
		public string DisplayName { set; get; }
		public string Twitter { set; get; }
		public string ImageUri { set; get; }
	}
}


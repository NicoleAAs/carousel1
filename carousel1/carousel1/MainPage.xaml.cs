using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace carousel1
{
	public partial class MainPage : CarouselPage
	{

		Button btn;
		Uri ur;
		public MainPage()
		{
			BackgroundColor = Color.Coral;
			Button btn= new Button { Text = "Узнать больше информации", BackgroundColor = Color.AliceBlue, HorizontalOptions = LayoutOptions.Center };
			Button btn1 = new Button { Text = "Узнать больше информации", BackgroundColor = Color.AliceBlue, HorizontalOptions = LayoutOptions.Center };
			Button btn2 = new Button { Text = "Узнать больше информации", BackgroundColor = Color.AliceBlue, HorizontalOptions = LayoutOptions.Center };
			Button btn3 = new Button { Text = "Узнать больше информации", BackgroundColor = Color.AliceBlue, HorizontalOptions = LayoutOptions.Center };

			btn.Clicked += Btn_Clicked;
			btn1.Clicked += Btn1_Clicked;
			btn2.Clicked += Btn2_Clicked;
			btn3.Clicked += Btn3_Clicked;

			var googlepixelContentPage = new ContentPage
			{
				Content = new StackLayout
				{
					Children =
					{
						new Label{TextColor=Color.Black,
							Text = "GooglePixel 4a",
							FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
							HorizontalOptions = LayoutOptions.Center,
			},
						new Label
						{TextColor=Color.Black,
							Text="You might be surprised to find Google's midrange Pixel, the Pixel 4a, at the top of our list of the best Android phones. \nBut at just $349, the Pixel 4a is a remarkably complete smartphone, the likes of which we've never before seen at this price.",
						},
					new Image
					{
						Source = "pix.jpg",
						WidthRequest = 300,
						HeightRequest = 300,
					},
					btn3,
				}
				}
			};
			var googleContentPage = new ContentPage
			{
				Content = new StackLayout
				{
					Children =
					{
						new Label{TextColor=Color.Black,
							Text = "Samsung Galaxy Note 20 ultra",
							FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
							HorizontalOptions = LayoutOptions.Center,
			},
						new Label
						{TextColor=Color.Black,
							Text ="The Galaxy Note 20 Ultra takes the crown as the best Android phone for those willing to pay an ultra-premium price. \nAnd that’s because this device is much more than a phone. It’s a powerful note-taking tool with lots of S Pen upgrades; it’s a pro-level camera with a 108MP sensor and 50x zoom; and it’s a mini game console with the ability to stream Xbox games. \nThe Note 20 Ultra also boasts the best display on a phone yet, as its huge 6.9-inch OLED screen has a dynamic 120Hz refresh rate. So it’s smart enough to dial things up or down based on what's being displayed, which saves battery life. The 4,500 mAh battery lasts a long time on a charge, and you get quick 25-watt charging out of the box. Overall, the Galaxy Note 20 Ultra more than lives up to its name.",
						},
					new Image
					{
						Source = "note20.jpg",
						WidthRequest = 300,
						HeightRequest = 300,
					},
					btn2,
				}
				}
			};
			var oneplusContentPage = new ContentPage
			{
				Content = new StackLayout
				{
					Children =
					{
						new Label{TextColor=Color.Black,
							Text = "OnePlus 8 Pro",
							FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
							HorizontalOptions = LayoutOptions.Center,
			},
						new Label
						{TextColor=Color.Black,
							Text="The OnePlus 8 Pro may seem like a departure from previous OnePlus handsets. \nAfter all, at $899, this is one of the most expensive phones OnePlus has ever made. \nBut the OnePlus 8 Pro is the best flagship Android phone because it packs as many high-end features as possible for an incomparable value.In the case of the OnePlus 8 Pro, those features include a 120Hz refresh rate for its 6.78 - inch OLED screen and a top - of - the - line Snapdragon 865 CPU. \nThe OnePlus 8 Pro is the first OnePlus device to support wireless charging, and in the grand tradition of OnePlus pushing the battery envelope, its wireless charging standard is actually faster than many wired options.",
						},
					new Image
					{
						Source = "ones.jpg",
						WidthRequest = 300,
						HeightRequest = 300,
					},
					btn1,
				}
				}
			};
			var galaxynoteContentPage = new ContentPage
			{
				Content = new StackLayout
				{
					Children =
					{
						new Label{TextColor=Color.Black,
							Text = "Samsung Galaxy Note 20",
							FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
							HorizontalOptions = LayoutOptions.Center,
			},
						new Label
						{TextColor=Color.Black,
							Text="The $999 Galaxy Note 20 is an interesting proposition. \nIt's actually $200 cheaper than Samsung's Galaxy S20 Plus and $300 cheaper than the Galaxy Note 20 Ultra, and for that you lose a couple noteworthy features. The regular Note 20 has a 6.7-inch AMOLED display, but no 120Hz fast refresh rate. \nIt has a triple-lens rear camera, but no 108MP main sensor or 5x folded optical zoom lens.",
						},
					new Image
					{
						Source = "ag.jpg",
						WidthRequest = 300,
						HeightRequest = 300,
					},
					btn, 




				}
				}
			};

			Children.Add(googleContentPage);
			Children.Add(googlepixelContentPage);
			Children.Add(oneplusContentPage);
			Children.Add(galaxynoteContentPage);
		}

			private async void Btn_Clicked(object sender, EventArgs e)
			{
				ur = new Uri("https://www.tomsguide.com/us/best-android-phones,review-6051.html");
				await Browser.OpenAsync(ur);
			}
		private async void Btn1_Clicked(object sender, EventArgs e)
		{
			ur = new Uri("https://www.tomsguide.com/us/best-android-phones,review-6051.html");
			await Browser.OpenAsync(ur);
		}
		private async void Btn2_Clicked(object sender, EventArgs e)
		{
			ur = new Uri("https://www.tomsguide.com/us/best-android-phones,review-6051.html");
			await Browser.OpenAsync(ur);
		}
		private async void Btn3_Clicked(object sender, EventArgs e)
		{
			ur = new Uri("https://www.tomsguide.com/us/best-android-phones,review-6051.html");
			await Browser.OpenAsync(ur);
		}


	}
}


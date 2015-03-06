using Xamarin.Forms;

namespace SwitchingTabbedPageDemo {
	public class Page1 : ContentPage {
		public Page1() {
			Title = "Page 1 title";
			var button = new Button() {
				Text = "Stack a new Page 1 here",
			};
			button.Clicked += async (sender, e) => {
				var partPage = new Page1();
				await Navigation.PushAsync(partPage);
			};
			Content = new StackLayout { 
				Children = {
					button,
					new Label { Text = "Hello ContentPage 1" },
				}
			};
		}
	}
}

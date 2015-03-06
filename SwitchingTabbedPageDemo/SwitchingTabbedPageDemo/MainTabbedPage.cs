using Xamarin.Forms;
using System.Threading.Tasks;
using System;

namespace SwitchingTabbedPageDemo {
	public class MainTabbedPage : TabbedPage {
		readonly ContentPage tab2Page;
		readonly NavigationPage tab1Page;

		public MainTabbedPage() {
			// In this case, the tab's title is pulled from the navigation page.
			// The navigation title is pulled from the page it is showing.
			tab1Page = new NavigationPage(new Page1()) {
				Title = "Tab 1 title",
				Icon = "square.png"
			};
			Children.Add(tab1Page);
			// The title of the page added to Children will be the tab name as well.
			// The tab icon is pulled from the child page's Icon (for iOS)
			tab2Page = new Page2() {
				Title = "Tab 2 title",
				Icon = "circle" // extension isn't required
			};
			Children.Add(tab2Page);
		}

		/// <summary>
		/// Switch to a tab that is a navigation page. (Since popping and pushing are async, this is also async.)
		/// </summary>
		public async Task SwitchToTab1(Page pageToPush = null, bool resetToRootFirst = false) {
			if (resetToRootFirst) {
				// Pop back to the root of this navigation page.
				await tab1Page.PopToRootAsync();
			}
			// Warning: if we don't switch first, iOS will not switch (Android doesn't care).
			CurrentPage = tab1Page;
			if (pageToPush != null) {
				// Push a specific page on the navigation stack.
				await tab1Page.PushAsync(pageToPush);
			}
		}
		/// <summary>
		/// Switch to a tab that is just a plain page. (Note that tab switching isn't and async process.)
		/// </summary>
		public void SwitchToTab2() {
			CurrentPage = tab2Page;
		}
	}
}
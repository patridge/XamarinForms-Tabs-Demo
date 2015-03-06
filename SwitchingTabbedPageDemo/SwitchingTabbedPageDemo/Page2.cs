using Xamarin.Forms;

namespace SwitchingTabbedPageDemo {
    public class Page2 : ContentPage {
    	public Page2() {
    		var label = new Label { Text = "Hello ContentPage 2" };
    		Device.OnPlatform(
    			iOS: () => {
    				var parentTabbedPage = this.ParentTabbedPage() as MainTabbedPage;
    				if (parentTabbedPage != null) {
    					// HACK: get content out from under status bar if a navigation bar isn't doing that for us already.
    					Padding = new Thickness(Padding.Left, Padding.Top + 25f, Padding.Right, Padding.Bottom);
    				}
    			}
    		);
    		var button = new Button() {
    			Text = "Switch to Tab 1; add a Page 2 there",
    		};
    		button.Clicked += async (sender, e) => {
    			var tabbedPage = this.ParentTabbedPage() as MainTabbedPage;
    			var partPage = new Page2() { Title = "Added page 2" };
    			await tabbedPage.SwitchToTab1(partPage, resetToRootFirst: false);
    		};
    		Content = new StackLayout { 
    			Children = {
    				button,
    				label,
    			}
    		};
    	}
    }
}

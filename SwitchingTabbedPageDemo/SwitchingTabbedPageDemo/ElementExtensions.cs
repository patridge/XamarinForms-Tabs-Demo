using Xamarin.Forms;

namespace SwitchingTabbedPageDemo {
	public static class ElementExtensions {
		/// <summary>
		/// Walk the parent stack to try to find a parent that is a TabbedPage. Mostly
		/// useful for when a page is in a NavigationPage which is, in turn, in a TabbedPage.
		/// </summary>
		/// <returns>The first TabbedPage found, or null if there isn't one.</returns>
		public static TabbedPage ParentTabbedPage(this Element page) {
			if (page.Parent == null) {
				return null;
			}
			return page.Parent as TabbedPage ?? page.Parent.ParentTabbedPage();
		}
	}
}
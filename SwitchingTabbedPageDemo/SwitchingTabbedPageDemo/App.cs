using Xamarin.Forms;

namespace SwitchingTabbedPageDemo {
    public class App : Application {
    	public App() {
    		MainPage = new MainTabbedPage();
    	}

		protected override void OnStart() {
			// Handle when your app starts
		}

		protected override void OnSleep() {
			// Handle when your app sleeps
		}

		protected override void OnResume() {
			// Handle when your app resumes
		}
	}
}

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace TGCheckList
{
    public partial class App : Application
    {
        public App()
        {
            AppCenter.Start("ios=186378d1-7745-4667-9791-197f121c5e7b;" + "uwp={Your UWP App secret here};" +
                   "android={Your Android App secret here}",
                   typeof(Analytics), typeof(Crashes));
            InitializeComponent();
            MainPage = new TGCheckListPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

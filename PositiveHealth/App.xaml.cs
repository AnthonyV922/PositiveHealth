using PositiveHealth.Data;
using PositiveHealth.View;
using PositiveHealth.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace PositiveHealth
{
	public partial class App : Application
	{
        public static double progress;
        private static DBFoodController dbcontroller;
		public App ()
		{
			InitializeComponent();

			MainPage = new MapPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

        public static DBFoodController Dbcontroller
        {
            get
            {
                if(dbcontroller == null)
                {
                    dbcontroller = new DBFoodController();
                }
                return dbcontroller;
            }
        }
	}
}

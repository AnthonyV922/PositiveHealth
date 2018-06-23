using PositiveHealth.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PositiveHealth.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginView : ContentPage
	{
        public LoginModel loginModel;

		public LoginView ()
		{
			InitializeComponent ();
            loginModel = new LoginModel();

            //Displays notification alert confirming login
            MessagingCenter.Subscribe<LoginModel, string>(this, "LoginAlert", (sender, Username) =>
            {
                DisplayAlert("", Username, "Welcome");
            });
            this.BindingContext = loginModel;

            UsernameEntry.Completed += (object sender, EventArgs e) =>
            {
                PasswordEntry.Focus();
            };

            PasswordEntry.Completed += (object sender, EventArgs e) =>
            {
                loginModel.SubmitCommand.Execute(null);
            };
        }

        
    }
}
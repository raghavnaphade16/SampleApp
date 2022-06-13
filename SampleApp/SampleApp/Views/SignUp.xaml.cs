using System;
using System.Collections.Generic;
using VehicleSelling.Services;
using Xamarin.Forms;

namespace SampleApp.Views
{	
	public partial class SignUp : ContentPage
	{	
		public SignUp ()
		{
			InitializeComponent ();
		}

		async void BtnSignUp_Clicked(System.Object sender, System.EventArgs e)
		{
			var response = await ApiService.Registeruser(EntName.Text, EntEmail.Text, EntPassword.Text);
			if (response)
			{
				await DisplayAlert("Hello", "Account created successfully", "Ok");
			}
			else
			{
				await DisplayAlert("Error", "Something went wrong", "Ok");
			}
        }

        void BtnLogin_Clicked(System.Object sender, System.EventArgs e)
        {
			Navigation.PushAsync(new Login());
		}
    }
}


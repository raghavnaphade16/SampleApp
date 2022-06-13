using System;
using System.Collections.Generic;
using SampleApp.Views.MainView;
using Xamarin.Forms;

namespace SampleApp.Views
{	
	public partial class Login : ContentPage
	{	
		public Login ()
		{
			InitializeComponent ();
		}

        void BtnLogin_Clicked(System.Object sender, System.EventArgs e)
        {
			
			Navigation.PushAsync(new Surgeries());
        }
    }
}


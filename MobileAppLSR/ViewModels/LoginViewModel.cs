using MobileAppLSR.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

using MobileAppLSR.Models;


namespace MobileAppLSR.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        public string pseudo { get; set; }
        public string password { get; set; }
        public string erreurco { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            string pseudoi = "test";
            string passwordi = "test";
            if (pseudo == pseudoi && password == passwordi)
            {
                
                await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
            }
            else
            {
                erreurco = "Mot de passe ou pseudo incorrect";
            }
        }
    }
}

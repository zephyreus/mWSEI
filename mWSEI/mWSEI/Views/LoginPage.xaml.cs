using mWSEI.Models;
using mWSEI.Views.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mWSEI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            BackgroundColor = Constants.backgroundColor;
            ActivitySpinner.IsVisible = false;
            LoginLogo.HeightRequest = Constants.loginLogoHeight;
            AlertNoInternet.IsVisible = false;
            App.StartCheckIfInternet(AlertNoInternet, this);

            Entry_Login.Completed += (s, e) => Entry_Haslo.Focus();
            Entry_Haslo.Completed += (s, e) => LogInProcedureAsync(s, e);
        }

        async void LogInProcedureAsync(object sender, EventArgs e)
        {
            User user = new User(Entry_Login.Text, Entry_Haslo.Text);
            if (user.VerifyCredentials())
            {
                await DisplayAlert("", "Zalogowano", "Ok");
                // var result = await App.RestService.Login(user);
                var result = new Token();
                if (result != null)
                {
                    //App.UserDatabase.SaveUser(user);
                    // App.TokenDatabase.SaveToken(result);

                    if (Device.OS == TargetPlatform.Android)
                    {
                        Application.Current.MainPage = new MasterDetail();
                    }
                    else if (Device.OS == TargetPlatform.iOS)
                    {
                        await Navigation.PushModalAsync(new MasterDetail());
                    }
                }
            }
            else
            {
                await DisplayAlert("", "Login i hasło nie mogą być puste!", "Ok");
            }
        }
    }
}
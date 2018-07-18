using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace mWSEI.Models
{
    public class Constants
    {
        public static bool isDev = true;

        public static Color backgroundColor = Color.White;
        public static Color defaultTextColor = Color.FromRgb(66, 81, 88);

        public static int loginLogoHeight = 120;

        //Login constants
        public static string LoginUrl = "http://test.pl/api/Auth/Login";  //place to add URL to login webserwice
        public static string NoInternetConnectionText = "Brak połączenia z internetem.";
    }
}

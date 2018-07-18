using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using mWSEI.Models;

namespace mWSEI.Views.DetailViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Konto : ContentPage
    {
        public Konto()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            BackgroundColor = Constants.backgroundColor;
            App.StartCheckIfInternet(AlertNoInternet, this);
        }
    }

    
}
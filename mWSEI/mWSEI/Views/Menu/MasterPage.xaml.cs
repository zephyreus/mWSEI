using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mWSEI.Models;
using mWSEI.Views.DetailViews;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mWSEI.Views.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterPage : ContentPage
	{
        public ListView ListView { get { return listview; } }
        public List<MasterMenuItem> items;
		public MasterPage ()
		{
			InitializeComponent ();
            SetItems();
		}

        void SetItems()
        {
            items = new List<MasterMenuItem>();
            items.Add(new MasterMenuItem("Strona główna", Color.White, typeof(StronaGlowna)));
            items.Add(new MasterMenuItem("Twoje dane", Color.White, typeof(TwojeDane)));
            items.Add(new MasterMenuItem("Tok studiów", Color.White, typeof(TokStudiow)));
            items.Add(new MasterMenuItem("Przedmioty i oceny", Color.White, typeof(PrzedmiotyOceny)));
            items.Add(new MasterMenuItem("Finanse", Color.White, typeof(Finanse)));
            items.Add(new MasterMenuItem("Teczka", Color.White, typeof(Teczka)));
            items.Add(new MasterMenuItem("Praca dyplomowa", Color.White, typeof(PracaDyplomowa)));
            items.Add(new MasterMenuItem("Stypendia", Color.White, typeof(Stypendia)));
            items.Add(new MasterMenuItem("Praktyki", Color.White, typeof(Praktyki)));
            items.Add(new MasterMenuItem("Znajdź prowadzącego", Color.White, typeof(ZnajdzProwadzacego)));
            items.Add(new MasterMenuItem("Pliki do pobrania", Color.White, typeof(PlikiDoPobrania)));
            items.Add(new MasterMenuItem("Konto", Color.White, typeof(Konto)));
            ListView.ItemsSource = items;
        }
        async void LogOutProcedure(object sender, EventArgs e)
        {
            if (Device.OS == TargetPlatform.Android)
            {
                Application.Current.MainPage = new LoginPage();
            }
            else if (Device.OS == TargetPlatform.iOS)
            {
                await Navigation.PushModalAsync(new LoginPage());
            }
            await DisplayAlert("", "Wylogowano!", "Ok");
        }
    }
}
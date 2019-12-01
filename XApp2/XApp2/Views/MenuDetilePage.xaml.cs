using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XApp2.View_Models;
namespace XApp2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuDetilePage : ContentPage
    {
         
         
        public MenuDetilePage()
        {
            InitializeComponent();

            var menuList = new List<MenuPageViewModel>();
            try
            {
                menuList.Add(new MenuPageViewModel("Первый калькулятор", "cabel.png"));
            }
            finally 
            {
                menuList.Add(new MenuPageViewModel("Новости", "news_icon.png"));
            }
            listView.ItemsSource = menuList;
        }

        private async void News_Clicked(object sender, EventArgs e)
        {
 
            ((XApp2.Views.MainPage)Application.Current.MainPage).Detail = new NavigationPage(new News());
             
        }

        private async void Calc_Clicked(object sender, EventArgs e)
        {
 
            ((XApp2.Views.MainPage)Application.Current.MainPage).Detail = new NavigationPage( new MenuPage());

        }
    }
}
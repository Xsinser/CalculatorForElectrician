using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XApp2.View_Models
{
    class MenuPageViewModel : BaseViewModel
    {


        private string _namePage = string.Empty;
        private Image _imagePage = new Image();

        public string NamePage { get { return _namePage; } set { SetProperty(ref _namePage, value); } }        
        public Image ImagePage { get { return _imagePage; } set { SetProperty(ref _imagePage, value); } }

        public MenuPageViewModel(string namePage,string  nameImagePage)
        {
            NamePage = namePage;
           // ImagePage.Source = ImageSource.FromResource(nameImagePage);
            ImagePage = new Image { Source = "cabel.png" };
             
        }


    }
}

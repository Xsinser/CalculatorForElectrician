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
    public partial class News : ContentPage
    {
        /*
        class Class1
        {
            public string RowNews { get; set; }
            public string TopName { get; set; }
            public string LowName { get; set; }
            public Image ImagePath { get; set; }
            public Class1()
            {
                TopName = "Top";
                LowName = "1\n"+"2\n";
               // ImagePath = @"C:\Users\Xsinser\Desktop\news.jpg";
                ImagePath = new Image { Source = "cabel.png" };
                RowNews = "30";
            }

        }
        */
        public News()
        {
            InitializeComponent();
            BindingContext = new ViewsModel("Новости");
            
          //  var list = new List<Class1>();
           // list.Add(new Class1());
            //listView.ItemsSource = list;
        }
    }
}
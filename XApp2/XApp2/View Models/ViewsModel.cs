using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

 
using XApp2.Views;

namespace XApp2.View_Models
{
    class ViewsModel : BaseViewModel
    {
 
        public ViewsModel(string tille)
        {
            Title = tille;
        }
    }
}

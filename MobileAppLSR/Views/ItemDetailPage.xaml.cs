using MobileAppLSR.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MobileAppLSR.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
using MobileAppLSR.ViewModels;
using MobileAppLSR.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MobileAppLSR
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(PhotoPage), typeof(PhotoPage));

        }
    }
}

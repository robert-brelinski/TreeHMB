using System;
using System.Collections.Generic;
using TreeHMBApp.ViewModels;
using TreeHMBApp.Views;
using Xamarin.Forms;

namespace TreeHMBApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}

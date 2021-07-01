using System;
using System.Collections.Generic;
using System.ComponentModel;
using TreeHMBApp.Models;
using TreeHMBApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TreeHMBApp.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}
using System.ComponentModel;
using TreeHMBApp.ViewModels;
using Xamarin.Forms;

namespace TreeHMBApp.Views
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
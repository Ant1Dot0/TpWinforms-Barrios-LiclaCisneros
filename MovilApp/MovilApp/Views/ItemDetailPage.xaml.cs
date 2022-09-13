using MovilApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MovilApp.Views
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
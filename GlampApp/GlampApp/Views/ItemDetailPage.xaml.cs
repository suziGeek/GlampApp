using GlampApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace GlampApp.Views
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
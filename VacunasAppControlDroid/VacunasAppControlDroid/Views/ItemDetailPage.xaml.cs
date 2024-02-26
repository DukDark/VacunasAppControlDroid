using System.ComponentModel;
using VacunasAppControlDroid.ViewModels;
using Xamarin.Forms;

namespace VacunasAppControlDroid.Views
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
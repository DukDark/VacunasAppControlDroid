using System;
using System.Collections.Generic;
using System.ComponentModel;
using VacunasAppControlDroid.Models;
using VacunasAppControlDroid.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VacunasAppControlDroid.Views
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
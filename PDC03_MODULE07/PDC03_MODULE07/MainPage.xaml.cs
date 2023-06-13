﻿using PDC03_MODULE07.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDC03_MODULE07
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void LearnMoreButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.AnimalImportancePage());
        }
    }
}

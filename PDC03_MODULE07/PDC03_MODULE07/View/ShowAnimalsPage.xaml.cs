using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using PDC03_MODULE07.Model;
using PDC03_MODULE07.ViewModel;

namespace PDC03_MODULE07.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowAnimalsPage : ContentPage
    {
        AnimalsViewModel viewModel;
        public ShowAnimalsPage()
        {
            InitializeComponent();
            viewModel = new AnimalsViewModel();
        }

        private void showAnimalsPage()
        {
            var res = viewModel.GetAllAnimals().Result;
            lstData.ItemsSource = res;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            showAnimalsPage();
        }
        private void btnAddRecord_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new AddAnimal());
        }

        private async void lstData_ItemsSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                AnimalModel obj = (AnimalModel)e.SelectedItem;
                string res = await DisplayActionSheet("Operation", "Cancel", null, "Update", "Delete");

                switch (res)
                {
                    case "Update":
                        await this.Navigation.PushAsync(new AddAnimal(obj));
                        break;

                    case "Delete":
                        viewModel.DeleteAnimal(obj);
                        showAnimalsPage();
                        break;
                }
                lstData.SelectedItem = null;
            }
        }
    }
}
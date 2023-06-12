using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MODULE07.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]

	public partial class LandingPage : ContentPage
	{
		public LandingPage()
		{
			InitializeComponent();
		}
        private async void LearnMoreButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShowAnimalsPage());
        }
    }

}
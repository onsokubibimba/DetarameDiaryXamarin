using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void BtnOnClickedW(object sender,EventArgs args)
        {
            
            await Navigation.PushAsync(new WriteTypeSelect(), true);
        }

        private async void BtnOnClickedR(object sender, EventArgs args)
        {

            await Navigation.PushAsync(new ListViewPage1(), true);
            

        }

        private void BtnOnClickedE(object sender, EventArgs args)
        {
           DependencyService.Get<IDependencyserv>().Exit();


        }

        private void BtnOnClickedH(object sender, EventArgs args)
        {
            DependencyService.Get<IHelpMsg>().Show("へるーぷ");


        }

    }
}

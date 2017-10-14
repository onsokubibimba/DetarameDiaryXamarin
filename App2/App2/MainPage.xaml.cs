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

        //private int idx = 0;

		public MainPage()
		{
			InitializeComponent();

            ImgWrite.Source = ImageSource.FromFile("write1.png");

            var tgr = new TapGestureRecognizer();
            tgr.Tapped += (sender, e) => BtnOnClickedW(sender, e);
            ImgWrite.GestureRecognizers.Add(tgr);

            ImgRead.Source = ImageSource.FromFile("read1.png");


            var tgr2 = new TapGestureRecognizer();
            tgr2.Tapped += (sender, e) => BtnOnClickedR(sender, e);
            ImgRead.GestureRecognizers.Add(tgr2);


            //TimeSpan tm = TimeSpan.FromSeconds(2);

            //Device.StartTimer(tm, () => {
            //    // do something every 2000 milliseconds

            //    Device.BeginInvokeOnMainThread(() => {

            //        if (idx == 0)
            //        {
            //            ImgWrite.Source = ImageSource.FromFile("write1.png");


            //        } else
            //        {
            //            ImgWrite.Source = ImageSource.FromFile("write2.png");

            //        }

            //        if (idx == 0)
            //        {
            //            idx = 1;
            //        } else
            //        {
            //            idx = 0;
            //        }


            //    });
            //    return true; // runs again, or false to stop
            //});

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WriteTypeSelect : ContentPage
    {
        public WriteTypeSelect()
        {
            InitializeComponent();
        }

        private async void BtnWriteAOnClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new DiaryWriteSingleLabel(), true);
        }

        private async void BtnWriteBOnClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new DiaryWriteTurn(), true);
        }


        private async void BtnWriteCOnClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new DiaryWritePicker(), true);
        }

        //private async void BtnBackOnClicked(object sender, EventArgs args)
        //{
        //    await Navigation.PushAsync(new DiaryWriteSingleLabel(), true);
        //}

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App2.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(HelpMsg_Droid))]

namespace App2.Droid
{
    class HelpMsg_Droid : IHelpMsg
    {
        public void Show(string message)
        {
            Toast.MakeText(Android.App.Application.Context, message, ToastLength.Short).Show();
        }

    }

}

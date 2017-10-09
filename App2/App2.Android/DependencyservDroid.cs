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

[assembly: Xamarin.Forms.Dependency(typeof(DependencyservDroid))]


namespace App2.Droid
{
    class DependencyservDroid : IDependencyserv
    {
        public void Exit()
        {
            //Process.KillProcess(Process.MyPid());
            System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();

        }
    }
}
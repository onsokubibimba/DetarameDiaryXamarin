using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using App2.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(DependencyServ_iOS))]


namespace App2.iOS
{
    class DependencyServ_iOS : IDependencyserv
    {
        /// <summary>
        /// アプリ終了
        /// </summary>
        public void Exit()
        {
            System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
        }
    }
}
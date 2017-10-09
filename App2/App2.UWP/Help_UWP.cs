using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App2.UWP;


[assembly: Xamarin.Forms.Dependency(typeof(Help_UWP))]

namespace App2.UWP
{
    class Help_UWP : IHelpMsg
    {
        public void Show(string message)
        {
           // MessageBox
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App2.UWP;

[assembly: Xamarin.Forms.Dependency(typeof(Dependency_UWP))]


namespace App2.UWP
{
    class Dependency_UWP : IDependencyserv
    {
        public void Exit()
        {
                     
            Exit();
        }
    }
}

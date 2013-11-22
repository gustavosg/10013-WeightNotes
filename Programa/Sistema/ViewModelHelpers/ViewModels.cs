using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViewModelHelpers
{
    public class ViewModels : IViewModels
    {
        public ViewModels()
        {

        }

        protected void SendNavigationRequestMessage(Uri uri)
        {
            NavigationMessage(uri, new UriKind());
        }

        public static void NavigationMessage(Uri uri, UriKind uriKind){

        }


    }
}

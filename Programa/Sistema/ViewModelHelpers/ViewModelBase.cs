using NavigationService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViewModelHelpers
{
    public class ViewModelBase : NotifyPropertyChanged
    {

        protected T GetService<T>() where T : class
        {
            if (typeof(T) == typeof(INavigationService))
            {
                return new SimpleNavigationService() as T;
            }
            else
                return null;
        }

    }
}

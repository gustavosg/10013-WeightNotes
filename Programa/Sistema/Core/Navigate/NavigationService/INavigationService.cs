#region References

using System;
using System.Collections.Generic;

#endregion

namespace NavigationService
{
    public interface INavigationService 
    {
        void GoBack();

        void Navigate(String page);

        void Navigate(String page, IDictionary<String, String> parameters);
    }
}

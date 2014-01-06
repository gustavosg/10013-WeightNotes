

#region References

using Microsoft.Phone.Controls;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

#endregion


namespace NavigationService
{
    public class NavigationService : INavigationService
    {
        public void GoBack()
        {

        }

        public void Navigate(String page)
        {
            this.Navigate(page, null);
        }

        public void Navigate(String page, IDictionary<String, String> parameters)
        {
            PhoneApplicationFrame frame = Application.Current.RootVisual as PhoneApplicationFrame;

            if (frame == null)
                return;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(page);

            if (parameters != null && parameters.Count > 0)
            {
                stringBuilder.Append("?");

                Boolean addParameters = false;

                foreach (var item in parameters)
                {
                    if (addParameters)
                        stringBuilder.Append("&");

                    stringBuilder.AppendFormat("{0}={1}", item.Key, item.Value);
                    addParameters = true;
                }
            }

            page = stringBuilder.ToString();

            frame.Navigate(new Uri(page, UriKind.RelativeOrAbsolute));
        }
    }
}

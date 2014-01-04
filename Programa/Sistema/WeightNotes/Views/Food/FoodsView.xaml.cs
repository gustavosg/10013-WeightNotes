using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace WeightNotes.Views.Food
{
    public partial class FoodsView : PhoneApplicationPage
    {
        public FoodsView()
        {
            InitializeComponent();

            ChangeApplicationBar(false);
        }

        private void CheckBox_Clicked(object sender, RoutedEventArgs e)
        {
            Boolean value = ((CheckBox)sender).IsChecked == true ? true : false;

            ChangeApplicationBar(value);

        }

        /// <summary>
        /// Change in Runtime the Application Bar
        /// </summary>
        /// <param name="value">If there's any checkbox checked</param>
        private void ChangeApplicationBar(Boolean value)
        {
            ApplicationBar appBar = new ApplicationBar();

            if (value)
            {
                ApplicationBarIconButton iconButton1 = new ApplicationBarIconButton();
                iconButton1.Text = "editar";
                iconButton1.IconUri = new Uri("Images/dark/appbar.edit.rest.png", UriKind.Relative);

                appBar.Buttons.Add(iconButton1);

                ApplicationBarIconButton iconButton2 = new ApplicationBarIconButton();
                iconButton2.Text = "excluir";
                iconButton2.IconUri = new Uri("Images/dark/appbar.delete.rest.png", UriKind.Relative);
                appBar.Buttons.Add(iconButton2);
            }

            else
            {
                ApplicationBarIconButton iconButton1 = new ApplicationBarIconButton();
                iconButton1.Text = "novo";
                iconButton1.IconUri = new Uri("Images/dark/appbar.new.rest.png", UriKind.Relative);

                appBar.Buttons.Add(iconButton1);

                ApplicationBarIconButton iconButton2 = new ApplicationBarIconButton();
                iconButton2.Text = "procurar";
                iconButton2.IconUri = new Uri("Images/dark/appbar.feature.search.rest.png", UriKind.Relative);
                appBar.Buttons.Add(iconButton2);

                ApplicationBarIconButton iconButton3 = new ApplicationBarIconButton();
                iconButton3.Text = "filtrar";
                iconButton3.IconUri = new Uri("Images/dark/appbar.filter.png", UriKind.Relative);
                appBar.Buttons.Add(iconButton3);

                
            }

            FoodsViewPage.ApplicationBar = appBar;
            
        }
    }
}
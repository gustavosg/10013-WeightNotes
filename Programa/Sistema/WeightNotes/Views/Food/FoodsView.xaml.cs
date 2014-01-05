
#region References

using System;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using WeightNotes.ViewModels;

#endregion

namespace WeightNotes.Views.Food
{
    public partial class FoodsView : PhoneApplicationPage
    {
        #region Fields

        private Int16 qtSelected = 0;
        private Boolean isFired = false;

        private FoodsViewModel foodsViewModel;

        #endregion

        #region Constructor

        public FoodsView()
        {
            if (foodsViewModel == null)
                foodsViewModel = new FoodsViewModel();

            InitializeComponent();

            ChangeApplicationBar(false);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Check if Checkbox was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBox_Clicked(object sender, RoutedEventArgs e)
        {
            Boolean isChecked = ((CheckBox)sender).IsChecked == true ? true : false;

            if (isChecked)
                qtSelected++;

            else
                qtSelected--;

            if (isChecked)
            {
                if (!isFired)
                    ChangeApplicationBar(isChecked);

                isFired = true;
            }
            else if (qtSelected == 0)
            {
                ChangeApplicationBar(false);

                isFired = false;
            }
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
                iconButton2.Click += remover_click;
                appBar.Buttons.Add(iconButton2);
            }

            else
            {
                ApplicationBarIconButton iconButton1 = new ApplicationBarIconButton();
                iconButton1.Text = "novo";
                iconButton1.IconUri = new Uri("Images/dark/appbar.new.rest.png", UriKind.Relative);
                iconButton1.Click += novo_Click;

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

        void novo_Click(object sender, EventArgs e)
        {
            
        }

        void remover_click(object sender, EventArgs e)
        {
            foodsViewModel.DeleteFood();
        }

        #endregion
    }
}
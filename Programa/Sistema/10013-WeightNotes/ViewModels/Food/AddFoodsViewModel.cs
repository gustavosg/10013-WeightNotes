using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using WeightNotes.Model;
using ViewModelHelpers;

namespace WeightNotes.ViewModels
{
    public class AddFoodsViewModel : ViewModelBasePageEdit
    {
        #region Fields

        #endregion

        #region Constructor

        public AddFoodsViewModel()
        {

        }

        ~AddFoodsViewModel()
        {

        }

        #endregion

        #region Properties

        private Foods foodData;
        public Foods FoodData
        {
            get { return foodData; }
            set
            {
                foodData = value;

            }
        }

        #endregion

        #region Commands

        private RelayCommand exibir;
        public RelayCommand Exibir
        {
            get
            {
                if (exibir == null)
                    exibir = new RelayCommand(param => DoExibir());
                return exibir;
            }
        }


        #endregion

        #region Methods

        void DoExibir()
        {
            MessageBox.Show("Ola!");
        }

        #endregion

    }
}

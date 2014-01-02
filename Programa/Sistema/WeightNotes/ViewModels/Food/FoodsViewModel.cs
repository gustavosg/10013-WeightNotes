
#region References

using System.Windows;
using System;
using ViewModelHelpers;
using System.Collections.Generic;

#endregion

namespace WeightNotes.ViewModels
{
    public class FoodsViewModel : ViewModelBasePageEdit
    {
        #region Fields

        #endregion

        #region Construtors

        public FoodsViewModel()
        {
            IList<Test> listTemp = new List<Test>();

            listTemp.Add(new Test() { Id = "1", Name = "First Name" });
            listTemp.Add(new Test() { Id = "2", Name = "2nd Name" });

            ListItems = listTemp;
        }

        ~FoodsViewModel()
        {

        }

        #endregion

        #region Properties

        private String name;
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public String[] Gender
        {
            get
            {
                return new String[]{
                    "Doces",
                    "Laticínios",
                    "Ovos",
                    "Óleos Vegetais",
                    "Sementes e Castanhas",
                    "Frutas",
                    "Verduras",
                    "Grãos (Pães, Arroz, Macarrão, etc)",
                    "Legumes e soja", 
                };
            }
        }

        private String genderSelectedItem;
        public String GenderSelectedItem
        {
            get { return genderSelectedItem; }
            set
            {
                genderSelectedItem = value;
                OnPropertyChanged("GenderSelectedItem");
            }
        }

        private Double weight;
        public Double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                OnPropertyChanged("Weight");
            }
        }

        private IEnumerable<WeightType> weightTypeList;
        public IEnumerable<WeightType> WeightTypeList
        {
            get
            {

                IList<WeightType> list = new List<WeightType>();

                list.Add(new WeightType { });
                list.Add(new WeightType { Name = "Gramas", ShortName = "gr" });
                list.Add(new WeightType { Name = "Kilogramas", ShortName = "kg" });

                return list;
            }
        }

        private Double carbohydrates;
        public Double Carbohydrates
        {
            get { return carbohydrates; }
            set
            {
                carbohydrates = value;
                OnPropertyChanged("Carbohydrates");
            }
        }

        private Double protein;
        public Double Protein
        {
            get { return protein; }
            set
            {
                protein = value;
                OnPropertyChanged("Protein");
            }
        }

        private Double fat;
        public Double Fat
        {
            get { return fat; }
            set
            {
                fat = value;
                OnPropertyChanged("Fat");
            }
        }

        private Double fiber;
        public Double Fiber
        {
            get { return fiber; }
            set
            {
                fiber = value;
                OnPropertyChanged("Fiber");
            }
        }

        private Double sodium;
        public Double Sodium
        {
            get { return sodium; }
            set
            {
                sodium = value;
                OnPropertyChanged("Sodium");
            }
        }

        private Double energyValue;
        public Double EnergyValue
        {
            get { return energyValue; }
            set
            {
                energyValue = value;
                OnPropertyChanged("EnergyValue");
            }
        }

        private IList<Test> listItems;
        public IList<Test> ListItems
        {
            get { return listItems; }

            set
            {
                listItems = value;
                OnPropertyChanged("ListItems");
            }
        }

        #endregion
    }

    #region Commands



    #endregion

    #region Auxiliar Class

    public class WeightType
    {
        public String Name { get; set; }
        public String ShortName { get; set; }
    }

    public class Test
    {
        public String Id { get; set; }
        public String Name { get; set; }
    }

    #endregion

}


#region References

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using NavigationService;
using ViewModelHelpers;
using WeightNotes.Domain.Model;

#endregion

namespace WeightNotes.ViewModels
{
    public class FoodsViewModel : ViewModelBasePageEdit
    {
        #region Fields

        private static Food food;

        #endregion

        #region Construtors

        public FoodsViewModel()
        {
            ListItems = new List<Food>();

            ListItems.Add(new Food() { Id = 1, Name = "First Name", IsChecked = false });
            ListItems.Add(new Food() { Id = 2, Name = "Arroz", IsChecked = false });
            ListItems.Add(new Food() { Id = 3, Name = "Mamão", IsChecked = false });

            IsChecked = true;
        }

        ~FoodsViewModel()
        {

        }

        #endregion

        #region Properties

        private String test;
        public String Test
        {
            get { return test; }
            set
            {
                test = value;
                OnPropertyChanged("Test");
            }
        }


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

        private Boolean isChecked;
        public Boolean IsChecked
        {
            get { return isChecked; }
            set
            {
                isChecked = value;
                OnPropertyChanged("IsChecked");
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

        private IList<Food> listItems;
        public IList<Food> ListItems
        {
            get { return listItems; }

            set
            {
                listItems = value;
                OnPropertyChanged("ListItems");
            }
        }

        #endregion

        #region Commands



        #endregion

        #region Methods

        public void Save(String nameFood)
        {
            Food food = (new Food() { Name = nameFood });

            food.AddFood(food);
        }


        /// <summary>
        /// 
        /// </summary>
        public void DeleteFood()
        {
            ListItems.Remove(ListItems.LastOrDefault());
        }

        #endregion
    }

    #region Auxiliar Class

    public class WeightType
    {
        public String Name { get; set; }
        public String ShortName { get; set; }
    }



    #endregion

}

#region References

using System;
using System.Data.Linq.Mapping;
using System.IO.IsolatedStorage;
using Basis.BaseEntity;

#endregion

namespace WeightNotes.Domain.Model
{
    [Table]
    public class Food : BaseEntity
    {
        private static IsolatedStorageSettings isolatedStorageSettings;

        //private String id;
        //public String Id
        //{
        //    get { return id; }
        //    set
        //    {
        //        id = value;
        //        OnPropertyChanged("Id");
        //    }
        //}

        //private String name;
        //public String Name
        //{
        //    get { return name; }
        //    set
        //    {
        //        name = value;
        //        OnPropertyChanged("Name");
        //    }
        //}

        //private Boolean isChecked;
        //public Boolean IsChecked
        //{
        //    get { return isChecked; }
        //    set
        //    {
        //        isChecked = value;
        //        OnPropertyChanged("IsChecked");
        //    }
        //}

        [Column(IsPrimaryKey = true, CanBeNull = false, IsDbGenerated = true, DbType = "INT NOT NULL Identity")]
        public Int16 Id { get; set; }

        public String Name { get; set; }

        public Boolean IsChecked { get; set; }


        #region Methods

        public void AddFood(Food food)
        {
            isolatedStorageSettings["Food"] = food;

            isolatedStorageSettings.Save();
        }

        #endregion


    }
}

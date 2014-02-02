#region References

using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using ViewModelHelpers;

#endregion

namespace WeightNotes.Model
{
    [Table(Name = "Food")]
    public class Food : NotifyPropertyChanged
    {
        public Food()
        {
            this._genre = new EntityRef<Genre>();
        }

        private Int64 _id;
        [Column(Name = "Id", CanBeNull = false, DbType = "long not null identity", IsDbGenerated = true, IsPrimaryKey = true, AutoSync = AutoSync.OnInsert)]
        public Int64 Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }

        [Column]
        protected Int64 _genreId;

        private String _name;
        [Column(Name = "Name", CanBeNull = false, DbType = "nchar(50)")]
        public String Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        private Double _energyValue;
        [Column(Name = "EnergyValue", CanBeNull = true, DbType = "float")]
        public Double EnergyValue
        {
            get { return _energyValue; }
            set
            {
                _energyValue = value;
                OnPropertyChanged("EnergyValue");
            }
        }

        private Double _weight;
        [Column(Name = "Weight", CanBeNull = false, DbType = "double")]
        public Double Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
                OnPropertyChanged("Weight");
            }
        }

        private List<String> _weightType;
        [Column(Name = "WeightType")]
        public List<String> WeightType
        {
            get
            {
                return new List<String>{
                "Gramas",
                "Kilogramas"};
            }
        }

        private Double _carbohydrates;
        [Column(Name = "Carbohydrates", CanBeNull = true, DbType = "double")]
        public Double Carbohydrates
        {
            get { return _carbohydrates; }
            set
            {
                _carbohydrates = value;
                OnPropertyChanged("Carbohydrates");
            }
        }

        private Double _protein;
        [Column(Name = "Protein", CanBeNull = true, DbType = "double")]
        public Double Protein
        {
            get { return _protein; }
            set
            {
                _protein = value;
                OnPropertyChanged("Protein");
            }
        }

        private Double _fat;
        [Column(Name = "Fat", CanBeNull = true, DbType = "double")]
        public Double Fat
        {
            get { return _fat; }
            set
            {
                _fat = value;
                OnPropertyChanged("Fat");
            }
        }

        private Double _fibers;
        [Column(Name = "Fibers", CanBeNull = true, DbType = "double")]
        public Double Fibers
        {
            get { return _fibers; }
            set
            {
                _fibers = value;
                OnPropertyChanged("Fibers");
            }
        }

        private Double _sodium;
        [Column(Name = "Sodium", CanBeNull = true, DbType = "double")]
        public Double Sodium
        {
            get { return _sodium; }
            set
            {
                _sodium = value;
                OnPropertyChanged("Sodium");
            }
        }

        // Associations
        private EntityRef<Genre> _genre;
        [Association(Storage = "_genre", ThisKey = "_genreId", OtherKey = "Id")]
        public Genre Genre
        {
            get { return _genre.Entity; }
            set
            {
                _genre.Entity = value;
                OnPropertyChanged("Genre");
            }
        }
    }
}

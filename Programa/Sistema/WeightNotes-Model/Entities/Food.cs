#region References

using System.Data.Linq;
using System.Data.Linq.Mapping;
using ViewModelHelpers;

#endregion

namespace WeightNotes.Model
{
    [Table]
    public class Food : NotifyPropertyChanged
    {
        public Food()
        {
            this._genre = new EntityRef<Genre>();
        }

        private int _id;
        [Column(Name = "Id", CanBeNull = false, DbType = "int not null identity", IsDbGenerated = true, IsPrimaryKey = true, AutoSync = AutoSync.OnInsert)]
        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }

        private string _name;
        [Column(Name = "Name", CanBeNull = false, DbType = "nchar(50)")]
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        [Column]
        protected int _genreId;

        private double _energyValue;
        [Column(Name = "EnergyValue", CanBeNull = true, DbType = "bool")]
        public double EnergyValue
        {
            get { return _energyValue; }
            set
            {
                _energyValue = value;
                OnPropertyChanged("EnergyValue");
            }
        }

        private double _weight;
        [Column(Name = "Weight", CanBeNull = false, DbType = "double")]
        public double Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
                OnPropertyChanged("Weight");
            }
        }

        private string[] _weightType;
        [Column(Name = "WeightType")]
        public string[] WeightType
        {
            get
            {
                return new string[]{
                "Gramas",
                "Kilogramas"};
            }
        }

        private double _carbohydrates;
        [Column(Name = "Carbohydrates", CanBeNull = true, DbType = "double")]
        public double Carbohydrates
        {
            get { return _carbohydrates; }
            set
            {
                _carbohydrates = value;
                OnPropertyChanged("Carbohydrates");
            }
        }

        private double _protein;
        [Column(Name = "Protein", CanBeNull = true, DbType = "double")]
        public double Protein
        {
            get { return _protein; }
            set
            {
                _protein = value;
                OnPropertyChanged("Protein");
            }
        }

        private double _fat;
        [Column(Name = "Fat", CanBeNull = true, DbType = "double")]
        public double Fat
        {
            get { return _fat; }
            set
            {
                _fat = value;
                OnPropertyChanged("Fat");
            }
        }

        private double _fibers;
        [Column(Name = "Fibers", CanBeNull = true, DbType = "double")]
        public double Fibers
        {
            get { return _fibers; }
            set
            {
                _fibers = value;
                OnPropertyChanged("Fibers");
            }
        }

        private double _sodium;
        [Column(Name = "Sodium", CanBeNull = true, DbType = "double")]
        public double Sodium
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

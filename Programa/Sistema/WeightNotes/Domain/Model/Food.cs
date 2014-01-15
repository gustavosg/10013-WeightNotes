#region References

using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using Basis.BaseEntity;
using ViewModelHelpers;

#endregion

namespace WeightNotes.Domain.Model
{
    [Table(Name = "Food")]
    public class Food : NotifyPropertyChanged
    {
        public Food()
        {
            this._genre = new EntityRef<Genre>();
        }

        private Int16 _id;
        [Column(Name = "Id", IsPrimaryKey = true, CanBeNull = false, IsDbGenerated = true, DbType = "INT NOT NULL Identity", AutoSync = AutoSync.OnInsert)]
        public Int16 Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }

        private String _name;
        [Column(Name = "Name", CanBeNull = false, DbType = "STRING NOT NULL")]
        public String Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        private Boolean _isChecked;
        [Column(Name = "IsChecked", CanBeNull = false, DbType = "BOOLEAN NOT NULL")]
        public Boolean IsChecked
        {
            get
            {
                return _isChecked;
            }
            set
            {
                _isChecked = value;
                OnPropertyChanged("IsChecked");
            }
        }

        // Internal column for the associated Genre ID Value
        [Column(Name = "_genreId")]
        internal String _genreId;

        // Entity Reference to Genre Table
        [Column]
        private EntityRef<Genre> _genre;

        [Association(Storage = "_genre", ThisKey = "_genreId")]
        public Genre Genre
        {
            get { return _genre.Entity; }
            set
            {
                _genre.Entity = value;
                OnPropertyChanged("Genre");
            }
        }

        // Version column aids update performance
        [Column(IsVersion = true)]
        private Binary _version;

    }
}

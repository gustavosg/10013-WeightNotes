#region References

using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.IO.IsolatedStorage;
using Basis.BaseEntity;

#endregion

namespace WeightNotes.Domain.Model
{
    [Table]
    public class Food : BaseEntity
    {
        private Int16 _id;
        [Column(IsPrimaryKey = true, CanBeNull = false, IsDbGenerated = true, DbType = "INT NOT NULL Identity")]
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
        [Column(CanBeNull = false, DbType = "STRING NOT NULL")]
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
        [Column(CanBeNull = false, DbType = "BOOLEAN NOT NULL")]
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
        [Column]
        internal Int16 _genreId;

        // Entity Reference to Genre Table
        [Column]
        private EntityRef<Genre> _genre;

        [Association(Storage = "_genre", ThisKey = "_genreId", OtherKey = "Id", IsForeignKey = true)]
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

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

        private EntityRef<Genre> _genre;
        [Association(Storage="_genre", ThisKey="_genreId", OtherKey="Id")]
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

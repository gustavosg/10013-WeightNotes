using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using ViewModelHelpers;

namespace WeightNotes.Model
{
    [Table]
    public class Genre : NotifyPropertyChanged
    {
        public Genre()
        {
            this._foods = new EntitySet<Food>();
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

        [Column]
        protected Int64 _foodId;

        private EntitySet<Food> _foods;
        [Association(Storage = "_foods", ThisKey = "_foodId", OtherKey = "Id")]
        public EntitySet<Food> Foods
        {
            get { return _foods; }
            set
            {
                _foods = value;
                OnPropertyChanged("Foods");
            }
        }
    }
}

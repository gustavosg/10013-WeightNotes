using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using Basis.BaseEntity;
using ViewModelHelpers;

namespace WeightNotes.Domain.Model
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
        int _foodsId;

        

        private EntitySet<Food> _foods;
        [Association(Storage = "_foods", ThisKey="_foodsId", OtherKey = "Id")]
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

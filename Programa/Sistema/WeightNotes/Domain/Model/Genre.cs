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
        private Int64 _id;
        [Column(Name = "Id", IsPrimaryKey=true, IsDbGenerated = true, DbType = "INT NOT NULL Identity", AutoSync = AutoSync.OnInsert)]
        public Int64 Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }

        private String _name;

        [Column(Name = "Name", CanBeNull = false)]
        public String Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        private EntitySet<Food> _foods;
        [Association(Storage = "_foods", OtherKey = "Id", ThisKey = "Id", IsForeignKey=true)]
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

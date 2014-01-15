using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Linq;
using System.Text;
using ViewModelHelpers;

namespace WeightNotes.Domain.Model
{
    public class BaseModelDataContext : DataContext
    {
        public BaseModelDataContext(String connectionString) : base(connectionString) { }

        public Table<Genre> Genres;

        public Table<Food> Foods;
    }
}

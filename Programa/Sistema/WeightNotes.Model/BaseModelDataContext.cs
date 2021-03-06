﻿using System;
using System.Data.Linq;

namespace WeightNotes.Model
{
    public class BaseModelDataContext : DataContext
    {
        public BaseModelDataContext(String connectionString) : base(connectionString) { }

        public Table<Genre> Genres;

        public Table<Food> Foods;
    }
}

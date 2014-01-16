using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeightNotes.Model;

namespace WeightNotes.Model
{
    public static class DataBaseHelper 
    {

        private static string _databaseURL = "Data Source=isostore:/weightnotes.sdf";


        public static BaseModelDataContext UseConnection()
        {

            using (BaseModelDataContext db = new BaseModelDataContext(_databaseURL))
            {
                if (db.DatabaseExists())
                    db.DeleteDatabase();

                if (!db.DatabaseExists())
                {
                    try
                    {
                        // Create database
                        db.CreateDatabase();

                        Genre fruta = new Genre();
                        //fruta.Name = "Frutas";

                        db.Genres.InsertOnSubmit(fruta);

                        db.Foods.InsertOnSubmit(new Food { Name = "Maçã", Genre = fruta });

                        // Save changes
                        db.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }

                return db;
            }
        }
    }
}

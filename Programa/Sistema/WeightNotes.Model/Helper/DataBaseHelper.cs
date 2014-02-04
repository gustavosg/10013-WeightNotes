#region References

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace WeightNotes.Model
{
    public static class DataBaseHelper
    {

        private static string _databaseURL = "Data Source=isostore:/weightnotes.sdf";

        public static BaseModelDataContext UseConnection()
        {

            using (BaseModelDataContext db = new BaseModelDataContext(_databaseURL))
            {

#if DEBUG
                if (db.DatabaseExists())
                    db.DeleteDatabase();

#endif
                if (!db.DatabaseExists())
                {
                    try
                    {
                        // Create database
                        db.CreateDatabase();

                        IList<Genre> listaGeneros = new List<Genre>();
                        listaGeneros.Add(new Genre { Name = "Frutas" });
                        listaGeneros.Add(new Genre { Name = "Legumes" });
                        listaGeneros.Add(new Genre { Name = "Verduras" });
                        listaGeneros.Add(new Genre { Name = "Carnes" });
                        listaGeneros.Add(new Genre { Name = "Cereais" });
                        listaGeneros.Add(new Genre { Name = "Doces" });

                        listaGeneros = listaGeneros.OrderBy(s => s.Name).ToList<Genre>();

                        Genre generos = new Genre();
                        generos.Name = "Frutas";

                        db.Genres.InsertOnSubmit(generos);

                        db.Foods.InsertOnSubmit(new Food { Name = "Maçã", Genre = generos });

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

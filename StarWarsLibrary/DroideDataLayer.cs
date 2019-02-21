using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsLibrary
{
    public class DroideDataLayer 
    {
        public void Edit(Droide droide)
        {
            using (StarWarsLibrary.StarWarsEntities context = new StarWarsEntities())
            {
                //Droide vraiDroide = context.Droide.First(item => item.ID == droide.ID);

                //vraiDroide.Matricule = droide.Matricule;
                //vraiDroide.ModeleID = droide.ModeleID;
                //vraiDroide.PointsDeVie = droide.PointsDeVie;

                context.Droide.Attach(droide);
                //context.Entry(droide).State = System.Data.Entity.EntityState.Modified;

                // => pour ne modifer que certaines colonnes en base
                context.Entry(droide).Property(item => item.Matricule).IsModified = true;
                context.Entry(droide).Property(item => item.ModeleID).IsModified = true;

                context.SaveChanges();

                droide.Modele = new Modele()
                {
                    ID = droide.ModeleID
                };
            }
        }

        public Droide SelectOne(int id)
        {
            return this.SelectAll(id).First();
        }

        public void Add(Droide droide)
        {
            using (StarWarsLibrary.StarWarsEntities context = new StarWarsEntities())
            {
                context.Droide.Add(droide);
                context.SaveChanges();
            }
        }

        public List<Droide> SelectAll(int id = -1)
        {
            using (StarWarsLibrary.StarWarsEntities context = new StarWarsEntities())
            {
                var query = from item in context.Droide
                                                .Include("Modele")
                            select item;

                if (id > 0)
                    query = query.Where(item => item.ID == id);

                return query.ToList();
            }
        }
    }
}

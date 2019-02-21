using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsLibrary
{
    public class ModeleDataLayer //: BaseDataLayer<Modele>
    {
        public List<Modele> SelectAll(int id = -1)
        {
            using (StarWarsLibrary.StarWarsEntities context = new StarWarsEntities())
            {
                var query = from item in context.Modele
                            select item;

                if (id > 0)
                    query = query.Where(item => item.ID == id);

                return query.ToList();
            }
            }
    }
}

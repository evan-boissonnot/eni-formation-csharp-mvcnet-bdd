using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsLibrary
{
    public class WookieDataLayer// : BaseDataLayer<Wookie>
    {
        #region Public methods
        public List<Wookie> SelectAll(int id = -1)
        {
            using (StarWarsLibrary.StarWarsEntities context = new StarWarsEntities())
            {
                var query = from item in context.Wookie
                            select item;

                if (id > 0)
                    query = query.Where(item => item.ID == id);

                return query.ToList();
            }
        }
        
        #endregion
    }
}

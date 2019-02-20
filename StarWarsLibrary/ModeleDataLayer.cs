using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsLibrary
{
    public class ModeleDataLayer : BaseDataLayer<Modele>
    {
        public override List<Modele> SelectAll(int id = -1)
        {
            return this.SelectAll("SELECT ID, Libelle FROM Modele");
        }

        protected override void BindListWithReader(SqlDataReader reader, List<Modele> list)
        {
            Modele item = new Modele();

            item.Id = int.Parse(reader["Id"].ToString());
            item.Libelle = reader["Libelle"].ToString();

            list.Add(item);
        }

        protected override string GetAddQuery(Modele item)
        {
            throw new NotImplementedException();
        }

        protected override string GetUpdateQuery(Modele item)
        {
            throw new NotImplementedException();
        }
    }
}

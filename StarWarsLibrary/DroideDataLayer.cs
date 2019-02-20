using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsLibrary
{
    public class DroideDataLayer : BaseDataLayer<Droide>
    {
        public override List<Droide> SelectAll(int id = -1)
        {
            string where = id > 0 ? " WHERE Droide.ID = " + id : string.Empty;

            return this.SelectAll("SELECT Droide.ID, Matricule, DateDeF, Modele.ID as ModeleID, Modele.Libelle as ModeleLibelle " +
                                  "From Droide join Modele on Droide.ModeleID = Modele.ID " + where);
        }

        protected override void BindListWithReader(SqlDataReader reader, List<Droide> list)
        {
            Droide item = new Droide();

            item.Id = int.Parse(reader["ID"].ToString());
            item.Matricule = reader["Matricule"].ToString();

            Modele parent = new Modele()
            {
                Id = int.Parse(reader["ModeleID"].ToString()),
                Libelle = reader["ModeleLibelle"].ToString()
            };

            item.ModeleId = parent.Id;

            item.MonModele= parent;

            list.Add(item);
        }

        protected override string GetAddQuery(Droide droide)
        {
            return "INSERT INTO [dbo].[Droide] " +
                        "           ([Matricule] " +
                        //"           ,[DateDeF] " +
                        "           ,[ModeleID]) " +
                        "     VALUES " +
                        "           ('" + droide.Matricule + "'" +
                        // "           ,<DateDeF, datetime,> " +
                        "           ," + droide.ModeleId + ")";
        }

        protected override string GetUpdateQuery(Droide item)
        {
            return "UPDATE[dbo].[Droide] " +
                "   SET [Matricule] = '" + item.Matricule + "' " +
                "      ,[ModeleID] = " + item.ModeleId.ToString() +
                " WHERE ID = " + item.Id.ToString();
    }
    }
}

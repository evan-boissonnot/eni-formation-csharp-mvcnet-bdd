using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsLibrary
{
    public class WookieDataLayer : BaseDataLayer<Wookie>
    {
        #region Public methods
        public override List<Wookie> SelectAll(int id = -1)
        {
            return this.SelectAll("select " +
                        "    Wookie.ID, Wookie.Nom, Wookie.Sexe, " +
                        "	Planete.ID as PlaneteID, Planete.Nom as PlaneteNom " +
                        "from Wookie " +
                        "join Planete on Wookie.PlanetID = Planete.ID");
        }

        //public List<Wookie> SelectAll()
        //{
        //    List<Wookie> list = new List<Wookie>();

        //    using (SqlConnection connection = new SqlConnection())
        //    {
        //        connection.ConnectionString = Properties.Settings.Default.MaChaineParDefaut;
        //        connection.Open();

        //        using (SqlCommand command = connection.CreateCommand())
        //        {
        //            command.CommandText = "select " +
        //                "    Wookie.ID, Wookie.Nom, Wookie.Sexe, " +
        //                "	Planete.ID as PlaneteID, Planete.Nom as PlaneteNom " +
        //                "from Wookie " +
        //                "join Planete on Wookie.PlanetID = Planete.ID";

        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {

        //                }
        //            }
        //        }
        //    }

        //    return list;
        //}

        protected override void BindListWithReader(SqlDataReader reader, List<Wookie> list)
        {
            Wookie wookie = new Wookie();

            wookie.Nom = reader["Nom"].ToString();
            wookie.Sexe = bool.Parse(reader["Sexe"].ToString());

            Planete planete = new Planete()
            {
                Id = int.Parse(reader["PlaneteID"].ToString()),
                Nom = reader["PlaneteNom"].ToString()
            };
            wookie.MaPlanete = planete;

            list.Add(wookie);
        }

        protected override string GetAddQuery(Wookie item)
        {
            throw new NotImplementedException();
        }

        protected override string GetUpdateQuery(Wookie item)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsLibrary
{
    public abstract class BaseDataLayer<T>
    {
        #region Public methods
        public T SelectOne(int id)
        {
            List<T> list = this.SelectAll(id);

            return list.First();
        }

        public abstract List<T> SelectAll(int id = -1);

        public virtual List<T> SelectAll(string requete)
        {
            List<T> list = new List<T>();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = Properties.Settings.Default.MaChaineParDefaut;
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = requete;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            this.BindListWithReader(reader, list);
                        }
                    }
                }
            }

            return list;
        }

        protected abstract string GetAddQuery(T item);
        protected abstract string GetUpdateQuery(T item);

        public void Add(T item)
        {
            this.ExecuteNonQuery(this.GetAddQuery(item));
        }

        public void Edit(T item)
        {
            this.ExecuteNonQuery(this.GetUpdateQuery(item));
        }

        protected void ExecuteNonQuery(string requete)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = Properties.Settings.Default.MaChaineParDefaut;
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = requete;
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Méthodes internes
        protected abstract void BindListWithReader(SqlDataReader reader, List<T> list); 
        #endregion
    }
}

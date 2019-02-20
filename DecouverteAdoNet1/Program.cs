using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecouverteAdoNet1
{
    class Program
    {
        static void Main(string[] args)
        {
            StarWarsLibrary.WookieDataLayer layer = new StarWarsLibrary.WookieDataLayer();

            foreach (var item in layer.SelectAll())
            {
                Console.WriteLine("Nom : " + item.Nom);
            }
        }
    }
}

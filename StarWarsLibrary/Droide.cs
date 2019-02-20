using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsLibrary
{
    public class Droide
    {
        #region Propriétés
        public int Id { get; set; }

        public string Matricule { get; set; }

        public DateTime DateDeFabrication { get; set; }

        public int ModeleId { get; set; }

        public Modele MonModele { get; set; }
        #endregion
    }
}

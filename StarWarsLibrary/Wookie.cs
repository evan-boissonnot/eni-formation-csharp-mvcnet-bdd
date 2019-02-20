using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsLibrary
{
    public class Wookie
    {
        public int Id { get; set; }

        [Display(Description = "Test ?", Name = "Nom")]
        public string Nom { get; set; }

        public bool Sexe { get; set; }

        [Display(Description = "Test ?", Name = "Date")]
        public DateTime DateDeNaissance { get; set; }

        public Planete MaPlanete { get; set; }
    }
}

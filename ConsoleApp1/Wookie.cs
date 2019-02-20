namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Wookie")]
    public partial class Wookie
    {
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Nom { get; set; }

        public DateTime DateDeN { get; set; }

        public bool Sexe { get; set; }

        public int? PlanetID { get; set; }

        public virtual Planete Planete { get; set; }
    }
}

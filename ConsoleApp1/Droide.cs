namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Droide")]
    public partial class Droide
    {
        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string Matricule { get; set; }

        public DateTime DateDeF { get; set; }

        public int ModeleID { get; set; }

        public int? PointsDeVie { get; set; }

        public virtual Modele Modele { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MesPremiersPasEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Droide
    {
        public int ID { get; set; }
        public string Matricule { get; set; }
        public System.DateTime DateDeF { get; set; }
        public int ModeleID { get; set; }
    
        public virtual Modele Modele { get; set; }
    }
}

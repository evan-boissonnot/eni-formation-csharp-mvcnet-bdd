namespace ConsoleApp1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Droide> Droide { get; set; }
        public virtual DbSet<Modele> Modele { get; set; }
        public virtual DbSet<Planete> Planete { get; set; }
        public virtual DbSet<Wookie> Wookie { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Droide>()
                .Property(e => e.Matricule)
                .IsUnicode(false);

            modelBuilder.Entity<Modele>()
                .Property(e => e.Libelle)
                .IsUnicode(false);

            modelBuilder.Entity<Modele>()
                .HasMany(e => e.Droide)
                .WithRequired(e => e.Modele)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Planete>()
                .Property(e => e.Nom)
                .IsUnicode(false);

            modelBuilder.Entity<Planete>()
                .HasMany(e => e.Wookie)
                .WithOptional(e => e.Planete)
                .HasForeignKey(e => e.PlanetID);

            modelBuilder.Entity<Wookie>()
                .Property(e => e.Nom)
                .IsUnicode(false);
        }
    }
}

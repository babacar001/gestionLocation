using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using menu.Model;
using MySql.Data.EntityFramework;

namespace gestion_location.Model
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]

    public class BdAppartementContext : DbContext
    {
        public BdAppartementContext() : base("bdAppartementContext")
        { }

        public DbSet<Profil> Profils { get; set; }
        public DbSet<Locataire> locataires { get; set; }
        public DbSet<Personne> personnes { get; set; }
        public DbSet<Proprietaire> proprietaires { get; set; }
        public DbSet<Appartement> appartements { get; set; }
        public DbSet<TypeAppartement> typeAppartements { get; set; }
        public DbSet<ContratLocation> contratLocations { get; set; }
        public DbSet<Utilisateur> utilisateurs { get; set; }
        public DbSet<Paiement> paiements { get; set; }
        public DbSet<Gestionnaire> gestionnaires { get; set; }
        public DbSet<Admin> admins { get; set; }
        public DbSet<Td_Erreur> td_Erreurs { get; set;}

    }
}

using Microsoft.EntityFrameworkCore;
using MonApp_MVC.Entities;

namespace MonApp_MVC.Data
{
    public class MonAppDbContext: DbContext
    {

        public DbSet<Tournois> Tournois { get; set; }
        public DbSet<Equipe> Equipes { get; set; }
        public DbSet<Joueur> Joueurs { get; set; }
        public DbSet<FicheOfficielle> FichesOfficielles { get; set; }

        public MonAppDbContext(DbContextOptions<MonAppDbContext> options)
            : base(options)
        {

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
   
        }
    }
}

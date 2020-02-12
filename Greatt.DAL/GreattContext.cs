using Greatt.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Greatt.DAL
{
    /// <summary>
    /// Classe définissant le DbContext (la modélisation de la base)
    /// </summary>
    public class GreattContext : DbContext
    {
        public DbSet<ClubEntity> Clubs { get; set; }

        public DbSet<JoueurEntity> Joueurs { get; set; }

        public DbSet<JugeEntity> Juges { get; set; }

        /// <summary>
        /// Sur la demande de configuration
        /// </summary>
        /// <param name="options"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("Data Source=greatt.db");
    }
}

using Microsoft.EntityFrameworkCore;


namespace Hudelsis_P2_AP1.DAL
{
    public class Contexto : DbContext
    {
        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= Data\Proyecto_DB.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
using Microsoft.EntityFrameworkCore;

namespace MVC_Project_4.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-N9TUFUP; Database=Db_MVC4; Integrated Security=true; TrustServerCertificate=true;");
        }
        public DbSet<Personel> personeller { get; set; }
        public DbSet<Departman> departmanlar { get; set; }

    }
}

using efcore01.Entities;
using Microsoft.EntityFrameworkCore;

namespace efcore01.Context
{
    internal class AppDpContect:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.; Database = Appg3 ; Trusted_Connection = True ; TrustServerCertificate = True");
        }
        public DbSet <Empoylee> Empoylee { get; set; }
        public DbSet <Department> Department { get; set; }
        //لازم اعمل من ال  
        //entity  بتعتلي دب سيت  عشان تتحول من كلاس عادي لي مابينج 
    }
}

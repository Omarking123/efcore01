using efcore01.Configurations;
using efcore01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace efcore01.Context
{
    internal class AppDpContect : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)


        {
            modelBuilder.ApplyConfiguration(new EmployeeConf());






            #region ..
            //modelBuilder.Entity<Employee>().HasKey("Empid");
            //modelBuilder.Entity<Employee>().HasKey(nameof(Employee.Empid));
            //modelBuilder.Entity<Employee>().HasKey(e=>e.Empid);


            //modelBuilder.Entity<Employee>()
            //    .Property(E => E.Name)
            //    .IsRequired()
            //    .HasColumnType("varchar")
            //    .HasMaxLength(50).
            //    HasColumnName("EmployeeName");
            //modelBuilder.Entity<Employee>().Property(e => e.Age).IsRequired(false);
            //modelBuilder.Entity<Employee>().Property(e => e.Salary).HasColumnType("money");
            //modelBuilder.Entity<Employee>().Property(e => e.DateOfCreation).HasDefaultValue(DateTime.Now); modelBuilder.Entity<Employee>().HasKey(e=>e.Empid);


            //modelBuilder.Entity<Employee>(E =>
            //{

            //    E.HasKey(e => e.Empid);
            //    E
            //    .Property(E => E.Name)
            //    .IsRequired()
            //    .HasColumnType("varchar")
            //    .HasMaxLength(50).
            //    HasColumnName("EmployeeName");
            //    E.Property(e => e.Age).IsRequired(false);
            //    E.Property(e => e.Salary).HasColumnType("money");
            //    E.Property(e => e.DateOfCreation).HasDefaultValue(DateTime.Now);
            //});

            #endregion


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.; Database = Appg3 ; Trusted_Connection = True ; TrustServerCertificate = True");
        }
        public DbSet <Employee> Empoylee { get; set; }
        public DbSet <Department> Department { get; set; }
        //لازم اعمل من ال  
        //entity  بتعتلي دب سيت  عشان تتحول من كلاس عادي لي مابينج 
    }
}

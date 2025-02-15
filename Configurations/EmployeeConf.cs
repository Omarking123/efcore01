using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using efcore01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace efcore01.Configurations
{
    internal class EmployeeConf : IEntityTypeConfiguration<Employee>
    {
       public void Configure(EntityTypeBuilder<Employee> E)
        {
            E.HasKey(e => e.Empid);
            E
            .Property(E => E.Name)
            .IsRequired()
            .HasColumnType("varchar")
            .HasMaxLength(50).
            HasColumnName("EmployeeName");
            E.Property(e => e.Age).IsRequired(false);
            E.Property(e => e.Salary).HasColumnType("money");
            E.Property(e => e.DateOfCreation).HasDefaultValue(DateTime.Now);
        }
    }
}

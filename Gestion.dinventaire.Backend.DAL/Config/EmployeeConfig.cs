using Gestion.dinventaire.Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.dinventaire.Backend.DAL.Config
{
    public class EmployeeConfig
        :  IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("T_Employee");
        builder.HasKey(x => x.id).HasName("PK_Employee");
        builder.Property(x => x.id).ValueGeneratedOnAdd();
        builder.Property(x => x.username).IsRequired();
        builder.Property(x => x.email).IsRequired().HasMaxLength(320);
        builder.Property(x => x.password).IsRequired();
        builder.Property(x => x.IsActif).HasDefaultValue(false);
        builder.HasCheckConstraint("checkMinLenMail", "lEN(Email)>=5");
        builder.HasIndex(x => x.email).IsUnique();

    }

    {
    }
}

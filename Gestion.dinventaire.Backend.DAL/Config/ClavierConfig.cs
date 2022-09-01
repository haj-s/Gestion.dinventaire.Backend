using Gestion.dinventaire.Backend.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.dinventaire.Backend.DAL.Config
{
    internal class ClavierConfig
         : IEntityTypeConfiguration<Clavier>
    {
        public void Configure(EntityTypeBuilder<Clavier> builder)
        {
            builder.ToTable("T_Clavier");
            builder.HasKey(x => x.Id).HasName("PK_clavier");
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.type).IsRequired();
            builder.Property(x => x.reference).IsRequired().HasMaxLength(320);
            builder.Property(x => x.image).IsRequired();
            builder.Property(x => x.model).IsRequired();
            builder.Property(x => x.dateDebut).IsRequired();
            builder.Property(x => x.dateFin).IsRequired();


        }
    }
}

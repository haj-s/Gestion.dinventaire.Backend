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
    public class TableConfig
         : IEntityTypeConfiguration<TableEntity>
    {
        public void Configure(EntityTypeBuilder<TableEntity> builder)
        {
            builder.ToTable("T_Table");
            builder.HasKey(x => x.id).HasName("PK_Table");
            builder.Property(x => x.id).ValueGeneratedOnAdd();
            builder.Property(x => x.type).IsRequired();
            builder.Property(x => x.reference).IsRequired().HasMaxLength(320);
            builder.Property(x => x.image).IsRequired();
            builder.Property(x => x.model).IsRequired();
            builder.Property(x => x.dateDebut).IsRequired();
            builder.Property(x => x.dateFin).IsRequired();



        }
    }
}


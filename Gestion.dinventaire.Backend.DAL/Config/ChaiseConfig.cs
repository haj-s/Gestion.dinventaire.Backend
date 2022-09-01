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
    public class ChaiseConfig
          : IEntityTypeConfiguration<ChaiseBurautique>
    {
        public void Configure(EntityTypeBuilder<ChaiseBurautique> builder)
        {
            builder.ToTable("T_chaise");
            builder.HasKey(x => x.id).HasName("PK_chaise");
            builder.Property(x => x.id).ValueGeneratedOnAdd();
            builder.Property(x => x.type).IsRequired();
            builder.Property(x => x.reference).IsRequired().HasMaxLength(320);
            builder.Property(x => x.image).IsRequired();
            builder.Property(x => x.dateDebut).IsRequired();
            builder.Property(x => x.dateFin).IsRequired();


        }
    }

}


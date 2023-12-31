using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class ModuloMaestrosConfiguration : IEntityTypeConfiguration<ModuloMaestro>
    {
        public void Configure(EntityTypeBuilder<ModuloMaestro> builder)
        {
            builder.ToTable("ModulosMaestros");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(w => w.FechaCreacion)
            .HasColumnType("DateTime");
            builder.Property(w => w.FechaModificacion)
            .HasColumnType("DateTime");

            builder.Property(p => p.NombreModulo)
            .IsRequired()
            .HasMaxLength(100);
        }
    }
}
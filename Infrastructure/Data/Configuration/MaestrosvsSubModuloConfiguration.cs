using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class MaestrosvsSubModuloConfiguration : IEntityTypeConfiguration<MaestroVsSubmodulo>
    {
        public void Configure(EntityTypeBuilder<MaestroVsSubmodulo> builder)
        {
            builder.ToTable("MaestrosVsSubmodulos");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(w => w.FechaCreacion)
            .HasColumnType("DateTime");
            builder.Property(w => w.FechaModificacion)
            .HasColumnType("DateTime");

            builder.HasOne(e => e.Maestro)
            .WithMany(p => p.MaestroVsSubmodulos)
            .HasForeignKey(p => p.IdMaestroFk);

            builder.HasOne(p => p.Submodulo)
            .WithMany(p => p.MaestroVsSubmodulos)
            .HasForeignKey(P => P.IdSubmoduloFk);

        }
    }
}
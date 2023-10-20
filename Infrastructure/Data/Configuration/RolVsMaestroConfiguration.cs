using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class RolVsMaestroConfiguration : IEntityTypeConfiguration<RolVsMaestro>
    {
        public void Configure(EntityTypeBuilder<RolVsMaestro> builder)
        {
            builder.ToTable("RolVsMaestro");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(w => w.FechaCreacion)
            .HasColumnType("DateTime");
            builder.Property(w => w.FechaModificacion)
            .HasColumnType("DateTime");

            builder.HasOne(o => o.Roles)
            .WithMany(o => o.RolVsMaestros)
            .HasForeignKey(o => o.IdRolFk);

            builder.HasOne(b => b.Maestros)
            .WithMany(b => b.RolVsMaestros)
            .HasForeignKey(b => b.IdMaestroFk);
        }
    }
}
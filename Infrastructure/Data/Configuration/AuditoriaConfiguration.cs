using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class AuditoriaConfiguration : IEntityTypeConfiguration<Auditoria>
    {
        public void Configure(EntityTypeBuilder<Auditoria> builder)
        {
            builder.ToTable("Auditoria");
            
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            builder.Property(a => a.NombreUsuario)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(a => a.DescAccion)
                .IsRequired();
            builder.Property(a => a.FechaCreacion)
            .HasColumnType("DateTime");
            builder.Property(a => a.FechaModificacion)
            .HasColumnType("DateTime");
        }
    }
}
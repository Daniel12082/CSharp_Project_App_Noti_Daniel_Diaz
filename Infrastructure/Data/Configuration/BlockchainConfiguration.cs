using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class BlockChainConfiguration : IEntityTypeConfiguration<Blockchain>
    {
        public void Configure(EntityTypeBuilder<Blockchain> builder)
        {
            builder.ToTable("BlockChain");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(e => e.HasGenerado)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(w => w.FechaCreacion)
            .HasColumnType("DateTime");
            builder.Property(w => w.FechaModificacion)
            .HasColumnType("DateTime");

            builder.HasOne(p => p.Auditorias)
            .WithMany(p => p.Blockchains)
            .HasForeignKey(e => e.IdAuditoriaFk);

            builder.HasOne(p => p.HilosRespuestasNotificaciones)
            .WithMany(p => p.Blockchains)
            .HasForeignKey(p => p.IdHiloRespuestaFk);

            builder.HasOne(p => p.TipoNotificaciones)
            .WithMany(p => p.Blockchains)
            .HasForeignKey(P => P.IdNotificacionFk);
        }
    }
}
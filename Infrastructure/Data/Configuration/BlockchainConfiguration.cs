using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class BlockchainConfiguration : IEntityTypeConfiguration<Blockchain>
    {
        public void Configure(EntityTypeBuilder<Blockchain> builder)
        {
            builder.ToTable("Blockchain");
            
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            builder.HasOne(x => x.Notificaciones)
                .WithMany(x => x.Blockchains)
                .HasForeignKey(x => x.IdNotificacionFk);
            builder.HasOne(x => x.HilosRespuestasNotificaciones)
                .WithMany(x => x.Blockchains)
                .HasForeignKey(x => x.IdHiloRespuestaFk);
            builder.HasOne(x => x.Auditorias)
                .WithMany(x => x.Blockchains)
                .HasForeignKey(x => x.IdAuditoriaFk);
            builder.Property(x => x.HasGenerado)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(x => x.FechaCreacion)
                .IsRequired();
            builder.Property(x => x.FechaModificacion);
            
        }
    }
}
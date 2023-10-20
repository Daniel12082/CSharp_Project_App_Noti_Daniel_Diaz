using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructura.Data.Configuration
{
    public class ModuloNotificacionesConfiguration : IEntityTypeConfiguration<ModuloNotificacion>
    {
        public void Configure(EntityTypeBuilder<ModuloNotificacion> builder)
        {
            builder.ToTable("ModuloNoficaciones");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(w => w.FechaCreacion)
            .HasColumnType("DateTime");
            builder.Property(w => w.FechaModificacion)
            .HasColumnType("DateTime");

            builder.Property(p => p.AsuntoNotifcacion)
            .IsRequired()
            .HasMaxLength(80);

            builder.Property(p => p.TextoNotificacion)
            .HasMaxLength(2000);

            builder.HasOne(j => j.tipoNotificacion)
            .WithMany(j => j.ModuloNotificaciones)
            .HasForeignKey(j => j.IdTipoNotificacionFk);

            builder.HasOne(s => s.radicado)
            .WithMany(s => s.ModuloNotificaciones)
            .HasForeignKey(s => s.IdRadicadoFk);

            builder.HasOne(n => n.estadoNotificacion)
            .WithMany(n => n.ModuloNotificaciones)
            .HasForeignKey(n => n.IdEstadoNotificacionFk);

            builder.HasOne(m => m.hiloRespuesta)
            .WithMany(m => m.ModuloNotificaciones)
            .HasForeignKey( m => m.IdHiloRespuestaFk);

            builder.HasOne(a => a.formato)
            .WithMany(a => a.ModuloNotificaciones)
            .HasForeignKey(a => a.IdFormatoFk);

            builder.HasOne(u => u.tipoRequerimiento)
            .WithMany(u => u.ModuloNotificaciones)
            .HasForeignKey(u => u.IdTipoRequerimientoFk);

        }
    }
}
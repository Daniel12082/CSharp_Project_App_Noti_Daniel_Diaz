using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class GenericoVsModuloConfiguration : IEntityTypeConfiguration<GenericoVsModulo>
    {
        public void Configure(EntityTypeBuilder<GenericoVsModulo> builder)
        {
            builder.ToTable("GenericoVsModulo");
            
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            builder.HasOne(x => x.PermisosGenericos)
                .WithMany(s => s.GenericoVsModulos)
                .HasForeignKey(x => x.IdGenericoFk);

            builder.Property(x => x.FechaCreacion)
                .IsRequired();
            builder.Property(x => x.FechaModificacion);
        }
    }
}
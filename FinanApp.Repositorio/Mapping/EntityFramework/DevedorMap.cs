using FinanApp.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanApp.Repositorio.Mapping.EntityFramework
{
    public class DevedorMap : IEntityTypeConfiguration<Devedor>
    {
        public void Configure(EntityTypeBuilder<Devedor> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.Nome)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(d => d.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .HasMany(d => d.Movimentos)
                .WithOne(m => m.Devedor);
        }
    }
}

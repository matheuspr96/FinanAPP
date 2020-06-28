using FinanApp.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanApp.Repositorio.Mapping.EntityFramework
{
    public class BancoMap : IEntityTypeConfiguration<Banco>
    {
        public void Configure(EntityTypeBuilder<Banco> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Nome)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(b => b.ValorFatura)
                .IsRequired();

            builder.Property(b => b.VencimentoFatura)
                .IsRequired();
        }
    }
}

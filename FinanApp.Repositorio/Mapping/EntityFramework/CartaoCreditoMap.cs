using FinanApp.Dominio.Entidades;
using FinanApp.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanApp.Repositorio.Mapping.EntityFramework
{
    public class CartaoCreditoMap : IEntityTypeConfiguration<CartaoCredito>
    {

        public void Configure(EntityTypeBuilder<CartaoCredito> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(b => b.CriadoEm)
                .IsRequired();

            builder.Property(b => b.AtualizadoEm)
                .IsRequired();

        }
    }
}

using FinanApp.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FinanApp.Repositorio.Mapping.EntityFramework
{
    public class MovimentoMap : IEntityTypeConfiguration<MovimentacaoFinanceira>
    {
        public void Configure(EntityTypeBuilder<MovimentacaoFinanceira> builder)
        {
            builder.HasKey(m => m.Id);


            builder.Property(m => m.Descricao)
                .IsRequired()
                .HasMaxLength(50);


            builder.Property(m => m.Valor)
                .IsRequired();

            builder.Property(m => m.DataMovimento)
               .IsRequired();

        }
    }
}

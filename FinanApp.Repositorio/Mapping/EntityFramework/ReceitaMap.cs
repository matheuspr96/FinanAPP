﻿using FinanApp.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanApp.Repositorio.Mapping.EntityFramework
{
    public class ReceitaMap : IEntityTypeConfiguration<Receita>
    {
        public void Configure(EntityTypeBuilder<Receita> builder)
        {
            builder.HasKey(u => u.Id);

            builder
                .Property(u => u.Descricao)
                .IsRequired()
                .HasMaxLength(20);

            builder
               .Property(u => u.Valor)
               .IsRequired();

            builder
             .Property(u => u.DataReceita)
             .IsRequired();
        }
    }
}

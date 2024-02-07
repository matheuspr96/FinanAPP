using FinanApp.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanApp.Repositorio.Mapping.EntityFramework
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);

            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(20);

            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(500);

            builder
                .HasMany(u => u.Receitas)
                .WithOne(r => r.Usuario);

            builder
                .HasMany(u => u.Bancos)
                .WithOne(b => b.Usuario);

        }
    }
}

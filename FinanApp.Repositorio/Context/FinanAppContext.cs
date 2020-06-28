using FinanApp.Dominio.Entidades;
using FinanApp.Repositorio.Mapping.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanApp.Repositorio.Context
{
    public class FinanAppContext : DbContext
    {
        public FinanAppContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Banco> Bancos { get; set; }
        public DbSet<Devedor> Devedores { get; set; }
        public DbSet<Movimento> Movimentos { get; set; }
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Classes de Mapeamento Entity
            modelBuilder.ApplyConfiguration(new BancoMap());
            modelBuilder.ApplyConfiguration(new DevedorMap());
            modelBuilder.ApplyConfiguration(new MovimentoMap());
            modelBuilder.ApplyConfiguration(new ReceitaMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}

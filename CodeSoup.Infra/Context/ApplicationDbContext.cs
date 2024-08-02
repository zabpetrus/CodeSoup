using CodeSoup.Domain.Entites;
using CodeSoup.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSoup.Infra.Context
{
    public class ApplicationDbContext : DbContext
    {
        // DbSets para cada conjunto de entidades
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Moto> Motos { get; set; }

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Empregado> Empregados { get; set; }
        public DbSet<Freelancer> Freelancers { get; set; }

        public DbSet<Computador> Computadores { get; set; }
        public DbSet<Impressora> Impressores { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuração TPT
            modelBuilder.Entity<Veiculo>().ToTable("Veiculos");
            modelBuilder.Entity<Carro>().ToTable("Carros");
            modelBuilder.Entity<Moto>().ToTable("Motos");

            // Configuração TPH
            modelBuilder.Entity<Funcionario>()
                .ToTable("Funcionarios")
                .HasDiscriminator<TipoFuncionario>("TipoFuncionario")
                .HasValue<Empregado>(TipoFuncionario.Empregado)
                .HasValue<Freelancer>(TipoFuncionario.Freelancer);

            // Configuração TPC
            modelBuilder.Entity<Computador>().ToTable("Computadores");
            modelBuilder.Entity<Impressora>().ToTable("Impressoras");
        }
    }
}

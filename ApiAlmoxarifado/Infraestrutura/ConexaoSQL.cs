using ApiAlmoxarifado.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace ApiAlmoxarifado.Infraestrutura
{
    public class ConexaoSQL : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
            =>
              optionBuilder.UseSqlServer(
                  @"Server=sql.bsite.net\MSSQL2016;" +
                  "Database=niuguin_;" +
                  "User id=niuguin_;" +
                  "Password=cmfs110110"


              );


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entrada>()
          .HasMany(e => e.produto)
          .WithOne(e => e.entrada)
          .HasForeignKey(e => e.codigoEntrada)
          .HasPrincipalKey(e => e.codigo);

                modelBuilder.Entity<Produto>()
         .HasMany(e => e.itensEntrada)
         .WithOne(e => e.produto)
         .HasForeignKey(e => e.codigoEntrada)
         .HasPrincipalKey(e => e.id);

            modelBuilder.Entity<Requisicao>()
           .HasMany(e => e.itens)
           .WithOne(e => e.requisicao)
           .HasForeignKey(e => e.codigoRequisicao)
           .HasPrincipalKey(e => e.Codigo);

            modelBuilder.Entity<Produto>()
           .HasMany(e => e.itens)
           .WithOne(e => e.produto)
           .HasForeignKey(e => e.codigoProduto)
           .HasPrincipalKey(e => e.id);

            modelBuilder.Entity<CategoriaMotivo>()
           .HasMany(e => e.Motivos)
           .WithOne(e => e.CategoriaMotivo)
           .HasForeignKey(e => e.CodigoCategoriaMotivo)
           .HasPrincipalKey(e => e.Codigo);
        }



        public DbSet<Produto> Produto { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<CategoriaMotivo> CategoriaMotivo { get; set; }
        public DbSet<MotivoSaida> MotivoSaida { get; set; }
        public DbSet<Requisicao> Requisicao { get; set; }
        public DbSet<ItensRequisicao> ItensRequisicao { get; set; }
        public DbSet<Motivo> Motivo { get; set; }
        public DbSet<Escolaridade> Escolaridade { get; set; }
        public DbSet<ItensEntrada> ItensEntrada { get; set; }
        public DbSet<Entrada> Entrada { get; set; }
    }
}

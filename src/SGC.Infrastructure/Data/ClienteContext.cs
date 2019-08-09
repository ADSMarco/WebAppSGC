using Microsoft.EntityFrameworkCore;
using SGC.ApplicationCore.Entity;
using SGC.Infrastructure.EntityConfig;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGC.Infrastructure.Data // classe responsavel pelo mapeamento do banco
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // função responsavel pela configuração do entity framework
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente"); // retira o plural do banco
            modelBuilder.Entity<Contato>().ToTable("Contato");
            modelBuilder.Entity<Endereco>().ToTable("Endereco");
            modelBuilder.Entity<Profissao>().ToTable("Profissao");
            modelBuilder.Entity<ProfissaoCliente>().ToTable("ProdissaoCliente");
            modelBuilder.ApplyConfiguration(new ClienteMap());
           
         

         

       



            #region Configurações de Menu
          
            #endregion

        }
    }
}

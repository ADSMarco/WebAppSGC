using Microsoft.EntityFrameworkCore;
using SGC.ApplicationCore.Entity;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder) // função responsavel pela configuração do entity framework
        {
            modelBuilder.Entity<Cliente>().ToTable("Tb_Cliente"); // retira o plural do banco
        }
    }
}

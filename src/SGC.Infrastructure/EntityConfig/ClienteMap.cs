using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGC.Infrastructure.EntityConfig
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder) // interface obrigatoria devido a contrato
        {
            builder.HasKey(c => c.ClienteId);

            builder.HasMany(c => c.Contatos)
                .WithOne(c => c.Cliente)
                .HasForeignKey(c => c.ClienteId)
                .HasPrincipalKey(c => c.ClienteId)
                .OnDelete(DeleteBehavior.Restrict); // Assim apaga só  cliente e não o contato para evitar a remoção em cascata

            builder.HasOne(c => c.Endereco) //Um cliente tem um endereço e um enfereço tem um cliente
                .WithOne(c => c.Cliente)
                .HasForeignKey<Endereco>(x => x.ClienteId);

            builder.Property(e => e.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();

            builder.Property(e => e.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

        }
    }
}

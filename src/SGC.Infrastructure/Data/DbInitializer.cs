using SGC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGC.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ClienteContext context)
        {

            if (context.Clientes.Any())
            {
                return; // DB has been seeded
            }

            var clientes = new Cliente[] // clientes recebe um array de clientes
                {
                    new Cliente {
                        Nome = "Fulano da Silva",
                        CPF = "11111111111"
                    },
                     new Cliente {
                        Nome = "Beltrano da Silva",
                        CPF = "22222222222"
                    }
                };

            context.AddRange(clientes);

            var contatos = new Contato[]
            {
                new Contato
                {
                    Nome = "Contato 1",
                    Telefone = "99999999",
                    Email= "emailContato1!teste.com",
                    Cliente = clientes[0] // pegou o primeiro cliente do array clientes que é o zero no indice de arrayz
                },

                   new Contato
                {
                    Nome = "Contato 2",
                    Telefone = "33333333",
                    Email= "emailContato2!teste.com",
                    Cliente = clientes[1] 
                }
            };

            context.AddRange(contatos);

            context.SaveChanges();
        }
    }
}

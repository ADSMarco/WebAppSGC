using SGC.ApplicationCore.Entity;
using SGC.Infrastructure.Data;
using SGC.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGC.ApplicationCore.Interfaces.Repository
{
    public class ClienteRepository : EFRepository<Cliente>, IClienteRepository //Erdando de cliente ele já traz todas as persistencias feitas.
    {

        public ClienteRepository(ClienteContext dbContext):base(dbContext) //passando a instancia para a classe base EFRepository
        {

        }

        public Cliente ObterPorProfissao(int clientId)
        {
            return Buscar(x => x.ProfissoesClientes.Any(p => p.ClienteId == clientId)).FirstOrDefault();
        }
    }
}

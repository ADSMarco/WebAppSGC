using SGC.ApplicationCore.Entity;
using SGC.Infrastructure.Data;
using SGC.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGC.ApplicationCore.Interfaces.Repository
{
    public class ContatoRepository : EFRepository<Contato>, IContatoRepository 
    {

        public ContatoRepository(ClienteContext dbContext):base(dbContext) 
        {

        }
   
    }
}

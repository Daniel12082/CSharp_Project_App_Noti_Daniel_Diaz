using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class RadicadoRepository : GenericRepository<Radicado>
    {
        private readonly AppNotiContext context;

        public RadicadoRepository(AppNotiContext context) : base(context)
        {
            this.context = context;
        }
    }
}
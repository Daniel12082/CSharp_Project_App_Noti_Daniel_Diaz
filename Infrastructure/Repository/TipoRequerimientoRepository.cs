using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class TipoRequerimientoRepository : GenericRepository<TipoRequerimiento>
    {
        private readonly AppNotiContext context;

        public TipoRequerimientoRepository(AppNotiContext context) : base(context)
        {
            this.context = context;
        }
    }
}
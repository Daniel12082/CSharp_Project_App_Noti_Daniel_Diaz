using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class PermisoGenericoRepository : GenericRepository<PermisoGenerico>
    {
        private readonly AppNotiContext context;

        public PermisoGenericoRepository(AppNotiContext context) : base(context)
        {
            this.context = context;
        }
    }
}
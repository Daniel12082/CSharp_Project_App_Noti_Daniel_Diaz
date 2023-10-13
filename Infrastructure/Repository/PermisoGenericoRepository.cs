using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class PermisoGenericoRepository : GenericRepository<PermisoGenerico> , IPermisoGenerico
    {
        private readonly AppNotiContext context;

        public PermisoGenericoRepository(AppNotiContext context) : base(context)
        {
            this.context = context;
        }
    }
}
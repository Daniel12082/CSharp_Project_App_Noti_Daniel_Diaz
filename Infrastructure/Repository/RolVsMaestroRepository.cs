using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class RolVsMaestroRepository : GenericRepository<RolVsMaestro>
    {
        private readonly AppNotiContext context;

        public RolVsMaestroRepository(AppNotiContext context) : base(context)
        {
            this.context = context;
        }
    }
}
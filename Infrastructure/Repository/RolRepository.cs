using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class RolRepository : GenericRepository<Rol>
    {
        private readonly AppNotiContext context;

        public RolRepository(AppNotiContext context) : base(context)
        {
            this.context = context;
        }
    }
}
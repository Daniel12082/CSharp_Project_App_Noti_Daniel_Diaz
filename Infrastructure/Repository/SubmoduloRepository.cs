using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class SubmoduloRepository : GenericRepository<Submodulo>, ISubmodulo
    {
        private readonly AppNotiContext context;

        public SubmoduloRepository(AppNotiContext context) : base(context)
        {
            this.context = context;
        }
    }
}
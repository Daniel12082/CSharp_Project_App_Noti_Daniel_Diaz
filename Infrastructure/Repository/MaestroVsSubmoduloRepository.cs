using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class MaestroVsSubmoduloRepository : GenericRepository<MaestroVsSubmodulos>
    {
        private readonly AppNotiContext context;

        public MaestroVsSubmoduloRepository(AppNotiContext context) : base(context)
        {
            this.context = context;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class ModuloNotificacionRepository : GenericRepository<ModuloNotificacion>
    {
        private readonly AppNotiContext context;

        public ModuloNotificacionRepository(AppNotiContext context) : base(context)
        {
            this.context = context;
        }
    }
}
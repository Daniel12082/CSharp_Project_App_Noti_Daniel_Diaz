using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class EstadoNotificacionRepository : GenericRepository<EstadoNotificacion>
    {
        private readonly AppNotiContext context;

        public EstadoNotificacionRepository(AppNotiContext context) : base(context)
        {
            this.context = context;
        }
    }
}
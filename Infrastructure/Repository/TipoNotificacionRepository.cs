using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class TipoNotificacionRepository : GenericRepository<TipoNotificacion>
    {
        private readonly AppNotiContext context;

        public TipoNotificacionRepository(AppNotiContext context) : base(context)
        {
            this.context = context;
        }
    }
}
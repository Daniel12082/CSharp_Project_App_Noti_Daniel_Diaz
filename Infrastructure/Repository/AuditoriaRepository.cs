using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class AuditoriaRepository : GenericRepository<Auditoria> , IAuditoria
    {
        private readonly AppNotiContext _context;
        public AuditoriaRepository(AppNotiContext context) : base(context)
        {
            _context = context;
        }

    }
}
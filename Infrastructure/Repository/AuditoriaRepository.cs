using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class AuditoriaRepository : GenericRepository<Auditoria>
    {
        private readonly AppNotiContext _context;
        public AuditoriaRepository(AppNotiContext context) : base(context)
        {
            _context = context;
        }
    }
}
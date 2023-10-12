using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class BlockchainRepository : GenericRepository<Blockchain>
    {
        private readonly AppNotiContext _context;
        public BlockchainRepository(AppNotiContext context) : base(context)
        {
            _context = context;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class RolVsMaestro : BaseEntity
    {
        public int IdRolFk { get; set; }
        public int IdMaestroFK { get; set; } 
    }
}
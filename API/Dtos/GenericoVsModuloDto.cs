using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class GenericoVsModuloDto : GenericDto
    {
        public int IdGenericoFk { get; set; }
        public int IdSubModuloFk { get; set; }
        public int IdRolFk { get; set; }
    }
}
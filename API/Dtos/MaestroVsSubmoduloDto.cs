using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace API.Dtos
{
    public class MaestroVsSubmoduloDto : GenericDto
    {
        public int IdMaestroFk { get; set; }
        public int IdSubModuloFk { get; set; }
        public ICollection<GenericoVsModulo> GenericoVsModulos { get; set; }
    }
}
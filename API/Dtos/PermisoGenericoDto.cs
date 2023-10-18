using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace API.Dtos
{
    public class PermisoGenericoDto : GenericDto
    {
        public string NombrePermiso { get; set; }
        public ICollection<GenericoVsModulo> GenericoVsModulos { get; set; }
    }
}
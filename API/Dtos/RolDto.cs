using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace API.Dtos
{
    public class RolDto
    {
        public string Nombre { get; set; }
        public ICollection<RolVsMaestro> RolVsMaestros { get; set; }
        public ICollection<GenericoVsModulo> GenericoVsModulos { get; set; }
    }
}
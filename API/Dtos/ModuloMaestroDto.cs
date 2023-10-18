using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace API.Dtos
{
    public class ModuloMaestroDto : GenericDto
    {
        public string NombreModulo { get; set; }
        public ICollection<RolVsMaestro> RolVsMaestros { get; set; }
        public ICollection<MaestroVsSubmodulo> MaestroVsSubmodulos { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class SubmoduloDto : GenericDto
    {
        public string NombreSubmodulo { get; set; }
        public ICollection<MaestroVsSubmoduloDto> MaestroVsSubmodulo { get; set; }
    }
}
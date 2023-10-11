using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class MaestroVsSubmodulos : BaseEntity
    {
        public int IdMaestroFk { get; set; }
        public ModuloMaestro Maestro { get; set; }
        public int IdSubmoduloFk { get; set; }
        public Submodulo Submodulo { get; set; }
    }
}
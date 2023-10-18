using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class MaestroVsSubmodulo : BaseEntity
    {
        public int IdMaestroFk { get; set; }
        public ModuloMaestro Maestro { get; set; }
        public int IdSubmoduloFk { get; set; }
        public Submodulo Submodulo { get; set; }
        public ICollection<GenericoVsModulo> GenericoVsModulos { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class GenericoVsModulo : BaseEntity
    {
        public int IdGenericoFk { get; set; }
        public PermisoGenerico PermisosGenericos { get; set; }
        public int IdSubModulofk { get; set; }
        public Submodulo Submodulos { get; set; }
        public int IdRolFk { get; set; }
        public Rol roles { get; set; }
    }
}
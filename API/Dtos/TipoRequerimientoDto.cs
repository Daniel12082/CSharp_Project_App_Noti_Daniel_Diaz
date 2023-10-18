using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace API.Dtos
{
    public class TipoRequerimientoDto : GenericDto
    {
        public string Nombre { get; set; }
        public ICollection<ModuloNotificacion> ModuloNotificacion { get; set; }
    }
}
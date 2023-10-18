using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace API.Dtos
{
    public class EstadoNotificacionDto : GenericDto
    {
        public string NombreEstado { get; set; }
        public ICollection<ModuloNotificacion> ModuloNotificacion { get; set; }
    }
}
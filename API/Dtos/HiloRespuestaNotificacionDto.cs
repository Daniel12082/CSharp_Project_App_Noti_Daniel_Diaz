using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace API.Dtos
{
    public class HiloRespuestaNotificacionDto : GenericDto
    {
        public string NombreTipo { get; set; }
        public ICollection<Blockchain> Blockchains { get; set; }
        public ICollection<ModuloNotificacion> ModuloNotificaciones { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class TipoNotificacion : BaseEntity
    {
        public string NombreTipo { get; set; }
        public ICollection<Blockchain> Blockchains { get; set; }
        public ICollection<ModuloNotificacion> ModuloNotificaciones { get; set; }
    }
}
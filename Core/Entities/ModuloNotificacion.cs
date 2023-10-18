using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ModuloNotificacion : BaseEntity
    {
        public string TextoNotificacion { get; set; }
        public string AsuntoNotifcacion { get; set; }
        public int IdTipoNotificacionFk { get; set; }
        public TipoNotificacion tipoNotificacion { get; set; }
        public int IdRadicadoFk { get; set; }
        public Radicado radicado { get; set; }
        public int IdEstadoNotificacionFk { get; set; }
        public EstadoNotificacion estadoNotificacion { get; set; }
        public int IdHiloRespuestaFk { get; set; }
        public HiloRespuestaNotificacion hiloRespuesta { get; set; }
        public int IdTipoRequerimientoFk { get; set; }
        public TipoRequerimiento tipoRequerimiento { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ModuloNotificacion : BaseEntity
    {
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
        public string TextoNotificacion { get; set; }
        public ICollection<HiloRespuestaNotificacion> HiloRespuestaNotificaciones { get; set; }
        public ICollection<Radicado> Radicados { get; set; }
        public ICollection<EstadoNotificacion> EstadoNotificaciones { get; set; }
        public ICollection<TipoNotificacion> TipoNotificaciones { get; set; }
        public ICollection<TipoRequerimiento> TipoRequerimientos { get; set; }
        public ICollection<Formato> Formatos { get; set; }
    }
}
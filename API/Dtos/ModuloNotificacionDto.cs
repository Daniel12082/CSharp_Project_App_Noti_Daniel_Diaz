using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace API.Dtos
{
    public class ModuloNotificacionDto : GenericDto
    {
        public string AsuntoNotifcacion { get; set; }
        public int IdTipoFk { get; set; }
        public int IdRadicadoFk { get; set; }
        public int IdEstadoNotificacionFk { get; set; }
        public int IdHiloRespuestaFk { get; set; }
        public int IdTipoRequerimientoFk { get; set; }
        public string TextoNotificacion { get; set; }
    }
}
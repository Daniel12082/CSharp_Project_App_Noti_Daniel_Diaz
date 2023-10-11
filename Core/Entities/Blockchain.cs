using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Blockchain
    {
        public int IdNotificacionFk { get; set; }
        public TipoNotificacion Notificaciones { get; set; }
        public int IdHiloRespuestaFk { get; set; }
        public HiloRespuestaNotificacion HilosRespuestasNotificaciones { get; set; }
        public int IdAuditoriaFk { get; set; }
        public Auditoria Auditorias { get; set; }
        public string HasGenerado { get; set; }
    }
}
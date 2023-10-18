using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class Blockchain : GenericDto
    {
        public string HasGenerado { get; set; }
        public int IdNotificacionFk { get; set; }
        public int IdHiloRespuestaFk { get; set; }
        public int IdAuditoriaFk { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace API.Dtos
{
    public class FormatoDto : GenericDto
    {
        public string NombreFormato { get; set; }
        public ICollection<ModuloNotificacion> ModuloNotificacion { get; set; }
    }
}
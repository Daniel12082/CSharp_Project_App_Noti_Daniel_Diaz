using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        IAuditoria Auditoria { get; }
        IBlockchain Blockchain { get; }
        IEstadoNotificacion EstadoNotificacion { get; }
        IFormato Formato { get; }
        IGenericoVsModulo GenericoVsModulo { get; }
        IHiloRespuestaNotificacion HiloRespuestaNotificacion { get; }
        IMaestroVsSubmodulo MaestroVsSubmodulo { get; }
        IModuloMaestro ModuloMaestro { get; }
        IModuloNotificacion ModuloNotificacion { get; }
        IPermisoGenerico PermisoGenerico { get; }
        IRadicado Radicado { get; }
        IRol Rol { get; }
        IRolVsMaestro RolVsMaestro { get; }
        ISubmodulo Submodulo { get; }
        ITipoNotificacion TipoNotificacion { get; }
        ITipoRequerimiento TipoRequerimiento { get; }
    }
}
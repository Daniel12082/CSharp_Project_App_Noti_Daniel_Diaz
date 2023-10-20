using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repository;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly AppNotiContext _context;
        private AuditoriaRepository _auditoria;
        private BlockchainRepository _blockchain;
        private EstadoNotificacionRepository _estadoNotificacion;
        private FormatoRepository _formato;
        private GenericoVsModuloRepository _genericoVsModulo;
        private HiloRespuestaNotificacionRepository _hiloRespuestaNotificacion;
        private MaestroVsSubmoduloRepository _maestroVsSubmodulo;
        private ModuloMaestroRepository _moduloMaestro;
        private ModuloNotificacionRepository _moduloNotificacion;
        private PermisoGenericoRepository _permisoGenerico;
        private RadicadoRepository _radicado;
        private RolRepository _rol;
        private RolVsMaestroRepository _rolVsMaestro;
        private SubmoduloRepository _submodulo;
        private TipoNotificacionRepository _tipoNotificacion;
        private TipoRequerimientoRepository _tipoRequerimiento;
        
        public UnitOfWork(AppNotiContext context)
        {
            _context = context;
        }

        public IAuditoria Auditoria{
            get
            {
                if (_auditoria == null)
                {
                    _auditoria = new AuditoriaRepository(_context);
                }
                return _auditoria;
            }
        }

        public IBlockchain Blockchain{
            get
            {
                if (_blockchain == null)
                {
                    _blockchain = new BlockchainRepository(_context);
                }
                return _blockchain;
            }
        }
        public IEstadoNotificacion EstadoNotificacion{
            get
            {
                if (_estadoNotificacion == null)
                {
                    _estadoNotificacion = new EstadoNotificacionRepository(_context);
                }
                return _estadoNotificacion;
            }
        }
        public IFormato Formato{
            get
            {
                if (_formato == null)
                {
                    _formato = new FormatoRepository(_context);
                }
                return _formato;
            }
        }

        public IGenericoVsModulo GenericoVsModulo{
            get
            {
                if (_genericoVsModulo == null)
                {
                    _genericoVsModulo = new GenericoVsModuloRepository(_context);
                }
                return _genericoVsModulo;
            }
        }

        public IHiloRespuestaNotificacion HiloRespuestaNotificacion{
            get
            {
                if (_hiloRespuestaNotificacion == null)
                {
                    _hiloRespuestaNotificacion = new HiloRespuestaNotificacionRepository(_context);
                }
                return _hiloRespuestaNotificacion;
            }
        }

        public IMaestroVsSubmodulo MaestroVsSubmodulo{
            get
            {
                if (_maestroVsSubmodulo == null)
                {
                    _maestroVsSubmodulo = new MaestroVsSubmoduloRepository(_context);
                }
                return _maestroVsSubmodulo;
            }
        }
        public IModuloMaestro ModuloMaestro{
            get
            {
                if (_moduloMaestro == null)
                {
                    _moduloMaestro = new ModuloMaestroRepository(_context);
                }
                return _moduloMaestro;
            }
        }

        public IModuloNotificacion ModuloNotificacion{
            get
            {
                if (_moduloNotificacion == null)
                {
                    _moduloNotificacion = new ModuloNotificacionRepository(_context);
                }
                return _moduloNotificacion;
            }
        }

        public IPermisoGenerico PermisoGenerico{
            get
            {
                if (_permisoGenerico == null)
                {
                    _permisoGenerico = new PermisoGenericoRepository(_context);
                }
                return _permisoGenerico;
            }
        }

        public IRadicado Radicado {
            get
            {
                if (_radicado == null)
                {
                    _radicado = new RadicadoRepository(_context);
                }
                return _radicado;
            }
        }

        public IRol Rol {
            get
            {
                if (_rol == null)
                {
                    _rol = new RolRepository(_context);
                }
                return _rol;
            }
        }

        public IRolVsMaestro RolVsMaestro {
            get
            {
                if (_rolVsMaestro == null)
                {
                    _rolVsMaestro = new RolVsMaestroRepository(_context);
                }
                return _rolVsMaestro;
            }
        }

        public ISubmodulo Submodulo {
            get
            {
                if (_submodulo == null)
                {
                    _submodulo = new SubmoduloRepository(_context);
                }
                return _submodulo;
            }
        }

        public ITipoNotificacion TipoNotificacion {
            get
            {
                if (_tipoNotificacion == null)
                {
                    _tipoNotificacion = new TipoNotificacionRepository(_context);
                }
                return _tipoNotificacion;
            }
        }

        public ITipoRequerimiento TipoRequerimiento {
            get
            {
                if (_tipoRequerimiento == null)
                {
                    _tipoRequerimiento = new TipoRequerimientoRepository(_context);
                }
                return _tipoRequerimiento;
            }
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
        }
}
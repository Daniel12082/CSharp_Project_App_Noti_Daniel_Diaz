using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles(){
            CreateMap<Auditoria, AuditoriaDto>();
            CreateMap<Blockchain, BlockchainDto>();
            CreateMap<EstadoNotificacion, EstadoNotificacionDto>();
            CreateMap<Formato, FormatoDto>();
            CreateMap<GenericoVsModulo, GenericoVsModuloDto>();
            CreateMap<HiloRespuestaNotificacion, HiloRespuestaNotificacionDto>();
            CreateMap<MaestroVsSubmodulo, MaestroVsSubmoduloDto>();
            CreateMap<ModuloMaestro, ModuloMaestroDto>();
            CreateMap<ModuloNotificacion, ModuloNotificacionDto>();
            CreateMap<PermisoGenerico, PermisoGenericoDto>();
            CreateMap<Radicado, RadicadoDto>();
            CreateMap<Rol, RolDto>();
            CreateMap<RolVsMaestro, RolVsMaestroDto>();
            CreateMap<Submodulo, SubmoduloDto>();
            CreateMap<TipoNotificacion, TipoNotificacionDto>();
            CreateMap<TipoRequerimiento, TipoRequerimientoDto>();
        }
    }
}
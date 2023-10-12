using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

    public class AppNotiContext : DbContext
    {
        public AppNotiContext(DbContextOptions<AppNotiContext> options) : base(options){}
            public DbSet<Auditoria> Auditorias { get; set; }
            public DbSet<Blockchain> Blockchains { get; set; }
            public DbSet<Rol> Roles { get; set; }
            public DbSet<ModuloMaestro> Maestros { get; set; }
            public DbSet<RolVsMaestro> RolVsMaestros { get; set; }


        }


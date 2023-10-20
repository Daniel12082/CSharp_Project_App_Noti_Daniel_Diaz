using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Auditoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreUsuario = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescAccion = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "DateTime", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auditoria", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EstadoNotificacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreEstado = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoNotificacion", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Formato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreFormato = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formato", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HiloRespuestaNotificacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreTipo = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "DateTime", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HiloRespuestaNotificacion", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ModulosMaestros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreModulo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "DateTime", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModulosMaestros", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PermisosGenericos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombrePermiso = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "DateTime", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermisosGenericos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Radicados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaCreacion = table.Column<DateTime>(type: "DateTime", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radicados", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SubModulos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreSubmodulo = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "DateTime", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubModulos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoNotificaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreTipo = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "DateTime", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoNotificaciones", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoRequerimiento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "DateTime", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoRequerimiento", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RolVsMaestro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdRolFk = table.Column<int>(type: "int", nullable: false),
                    IdMaestroFk = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "DateTime", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolVsMaestro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolVsMaestro_ModulosMaestros_IdMaestroFk",
                        column: x => x.IdMaestroFk,
                        principalTable: "ModulosMaestros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolVsMaestro_Roles_IdRolFk",
                        column: x => x.IdRolFk,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MaestrosVsSubmodulos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdMaestroFk = table.Column<int>(type: "int", nullable: false),
                    IdSubmoduloFk = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "DateTime", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaestrosVsSubmodulos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaestrosVsSubmodulos_ModulosMaestros_IdMaestroFk",
                        column: x => x.IdMaestroFk,
                        principalTable: "ModulosMaestros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaestrosVsSubmodulos_SubModulos_IdSubmoduloFk",
                        column: x => x.IdSubmoduloFk,
                        principalTable: "SubModulos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BlockChain",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdNotificacionFk = table.Column<int>(type: "int", nullable: false),
                    IdHiloRespuestaFk = table.Column<int>(type: "int", nullable: false),
                    IdAuditoriaFk = table.Column<int>(type: "int", nullable: false),
                    HasGenerado = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "DateTime", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlockChain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlockChain_Auditoria_IdAuditoriaFk",
                        column: x => x.IdAuditoriaFk,
                        principalTable: "Auditoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlockChain_HiloRespuestaNotificacion_IdHiloRespuestaFk",
                        column: x => x.IdHiloRespuestaFk,
                        principalTable: "HiloRespuestaNotificacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlockChain_TipoNotificaciones_IdNotificacionFk",
                        column: x => x.IdNotificacionFk,
                        principalTable: "TipoNotificaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ModuloNoficaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TextoNotificacion = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AsuntoNotifcacion = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoNotificacionFk = table.Column<int>(type: "int", nullable: false),
                    IdRadicadoFk = table.Column<int>(type: "int", nullable: false),
                    IdEstadoNotificacionFk = table.Column<int>(type: "int", nullable: false),
                    IdHiloRespuestaFk = table.Column<int>(type: "int", nullable: false),
                    IdTipoRequerimientoFk = table.Column<int>(type: "int", nullable: false),
                    IdFormatoFk = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "DateTime", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuloNoficaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModuloNoficaciones_EstadoNotificacion_IdEstadoNotificacionFk",
                        column: x => x.IdEstadoNotificacionFk,
                        principalTable: "EstadoNotificacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuloNoficaciones_Formato_IdFormatoFk",
                        column: x => x.IdFormatoFk,
                        principalTable: "Formato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuloNoficaciones_HiloRespuestaNotificacion_IdHiloRespuesta~",
                        column: x => x.IdHiloRespuestaFk,
                        principalTable: "HiloRespuestaNotificacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuloNoficaciones_Radicados_IdRadicadoFk",
                        column: x => x.IdRadicadoFk,
                        principalTable: "Radicados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuloNoficaciones_TipoNotificaciones_IdTipoNotificacionFk",
                        column: x => x.IdTipoNotificacionFk,
                        principalTable: "TipoNotificaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuloNoficaciones_TipoRequerimiento_IdTipoRequerimientoFk",
                        column: x => x.IdTipoRequerimientoFk,
                        principalTable: "TipoRequerimiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GenericoVsModulo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdGenericoFk = table.Column<int>(type: "int", nullable: false),
                    IdSubModulofk = table.Column<int>(type: "int", nullable: false),
                    SubmodulosId = table.Column<int>(type: "int", nullable: true),
                    IdRolFk = table.Column<int>(type: "int", nullable: false),
                    rolesId = table.Column<int>(type: "int", nullable: true),
                    MaestroVsSubmoduloId = table.Column<int>(type: "int", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenericoVsModulo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenericoVsModulo_MaestrosVsSubmodulos_MaestroVsSubmoduloId",
                        column: x => x.MaestroVsSubmoduloId,
                        principalTable: "MaestrosVsSubmodulos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GenericoVsModulo_PermisosGenericos_IdGenericoFk",
                        column: x => x.IdGenericoFk,
                        principalTable: "PermisosGenericos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenericoVsModulo_Roles_rolesId",
                        column: x => x.rolesId,
                        principalTable: "Roles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GenericoVsModulo_SubModulos_SubmodulosId",
                        column: x => x.SubmodulosId,
                        principalTable: "SubModulos",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_BlockChain_IdAuditoriaFk",
                table: "BlockChain",
                column: "IdAuditoriaFk");

            migrationBuilder.CreateIndex(
                name: "IX_BlockChain_IdHiloRespuestaFk",
                table: "BlockChain",
                column: "IdHiloRespuestaFk");

            migrationBuilder.CreateIndex(
                name: "IX_BlockChain_IdNotificacionFk",
                table: "BlockChain",
                column: "IdNotificacionFk");

            migrationBuilder.CreateIndex(
                name: "IX_GenericoVsModulo_IdGenericoFk",
                table: "GenericoVsModulo",
                column: "IdGenericoFk");

            migrationBuilder.CreateIndex(
                name: "IX_GenericoVsModulo_MaestroVsSubmoduloId",
                table: "GenericoVsModulo",
                column: "MaestroVsSubmoduloId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericoVsModulo_rolesId",
                table: "GenericoVsModulo",
                column: "rolesId");

            migrationBuilder.CreateIndex(
                name: "IX_GenericoVsModulo_SubmodulosId",
                table: "GenericoVsModulo",
                column: "SubmodulosId");

            migrationBuilder.CreateIndex(
                name: "IX_MaestrosVsSubmodulos_IdMaestroFk",
                table: "MaestrosVsSubmodulos",
                column: "IdMaestroFk");

            migrationBuilder.CreateIndex(
                name: "IX_MaestrosVsSubmodulos_IdSubmoduloFk",
                table: "MaestrosVsSubmodulos",
                column: "IdSubmoduloFk");

            migrationBuilder.CreateIndex(
                name: "IX_ModuloNoficaciones_IdEstadoNotificacionFk",
                table: "ModuloNoficaciones",
                column: "IdEstadoNotificacionFk");

            migrationBuilder.CreateIndex(
                name: "IX_ModuloNoficaciones_IdFormatoFk",
                table: "ModuloNoficaciones",
                column: "IdFormatoFk");

            migrationBuilder.CreateIndex(
                name: "IX_ModuloNoficaciones_IdHiloRespuestaFk",
                table: "ModuloNoficaciones",
                column: "IdHiloRespuestaFk");

            migrationBuilder.CreateIndex(
                name: "IX_ModuloNoficaciones_IdRadicadoFk",
                table: "ModuloNoficaciones",
                column: "IdRadicadoFk");

            migrationBuilder.CreateIndex(
                name: "IX_ModuloNoficaciones_IdTipoNotificacionFk",
                table: "ModuloNoficaciones",
                column: "IdTipoNotificacionFk");

            migrationBuilder.CreateIndex(
                name: "IX_ModuloNoficaciones_IdTipoRequerimientoFk",
                table: "ModuloNoficaciones",
                column: "IdTipoRequerimientoFk");

            migrationBuilder.CreateIndex(
                name: "IX_RolVsMaestro_IdMaestroFk",
                table: "RolVsMaestro",
                column: "IdMaestroFk");

            migrationBuilder.CreateIndex(
                name: "IX_RolVsMaestro_IdRolFk",
                table: "RolVsMaestro",
                column: "IdRolFk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlockChain");

            migrationBuilder.DropTable(
                name: "GenericoVsModulo");

            migrationBuilder.DropTable(
                name: "ModuloNoficaciones");

            migrationBuilder.DropTable(
                name: "RolVsMaestro");

            migrationBuilder.DropTable(
                name: "Auditoria");

            migrationBuilder.DropTable(
                name: "MaestrosVsSubmodulos");

            migrationBuilder.DropTable(
                name: "PermisosGenericos");

            migrationBuilder.DropTable(
                name: "EstadoNotificacion");

            migrationBuilder.DropTable(
                name: "Formato");

            migrationBuilder.DropTable(
                name: "HiloRespuestaNotificacion");

            migrationBuilder.DropTable(
                name: "Radicados");

            migrationBuilder.DropTable(
                name: "TipoNotificaciones");

            migrationBuilder.DropTable(
                name: "TipoRequerimiento");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "ModulosMaestros");

            migrationBuilder.DropTable(
                name: "SubModulos");
        }
    }
}

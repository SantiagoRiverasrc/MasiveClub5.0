using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Masive.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id_Categoria = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Categori__CB903349D4D27532", x => x.Id_Categoria);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id_Usuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 20, nullable: false),
                    Apellidos = table.Column<string>(maxLength: 20, nullable: false),
                    Email = table.Column<string>(maxLength: 20, nullable: false),
                    Contraseña = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Usuario__63C76BE2A387BFCD", x => x.Id_Usuario);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id_Producto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Categoria = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 20, nullable: false),
                    precio = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Producto__2085A9CF1F7E32EE", x => x.Id_Producto);
                    table.ForeignKey(
                        name: "FK__Productos__Id_Ca__398D8EEE",
                        column: x => x.Id_Categoria,
                        principalTable: "Categoria",
                        principalColumn: "Id_Categoria",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id_Cliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Usuario = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 20, nullable: false),
                    Nombre2 = table.Column<string>(maxLength: 20, nullable: true),
                    Apellido = table.Column<string>(maxLength: 20, nullable: false),
                    Apellido2 = table.Column<string>(maxLength: 20, nullable: true),
                    Direccion = table.Column<string>(maxLength: 20, nullable: false),
                    Telefono = table.Column<int>(nullable: false),
                    Email = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Cliente__3DD0A8CB3B997769", x => x.Id_Cliente);
                    table.ForeignKey(
                        name: "FK__Cliente__Id_Usua__267ABA7A",
                        column: x => x.Id_Usuario,
                        principalTable: "Usuario",
                        principalColumn: "Id_Usuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    Codigo_factura = table.Column<int>(nullable: false),
                    Id_Cliente = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Factura__90794BC07B66CD03", x => x.Codigo_factura);
                    table.ForeignKey(
                        name: "FK__Factura__Id_Clie__2A4B4B5E",
                        column: x => x.Id_Cliente,
                        principalTable: "Cliente",
                        principalColumn: "Id_Cliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Detalles",
                columns: table => new
                {
                    Id_Detalle = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Producto = table.Column<int>(nullable: false),
                    Codigo_factura = table.Column<int>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    Precio_total = table.Column<int>(nullable: false),
                    Fecha_compra = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Detalles__9274780B0EBE89C6", x => x.Id_Detalle);
                    table.ForeignKey(
                        name: "FK__Detalles__Codigo__412EB0B6",
                        column: x => x.Codigo_factura,
                        principalTable: "Factura",
                        principalColumn: "Codigo_factura",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Detalles__Id_Pro__403A8C7D",
                        column: x => x.Id_Producto,
                        principalTable: "Productos",
                        principalColumn: "Id_Producto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_Id_Usuario",
                table: "Cliente",
                column: "Id_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_Codigo_factura",
                table: "Detalles",
                column: "Codigo_factura");

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_Id_Producto",
                table: "Detalles",
                column: "Id_Producto");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_Id_Cliente",
                table: "Factura",
                column: "Id_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_Id_Categoria",
                table: "Productos",
                column: "Id_Categoria");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalles");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}

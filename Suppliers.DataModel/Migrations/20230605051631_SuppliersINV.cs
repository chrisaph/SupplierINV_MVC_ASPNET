using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Suppliers.DataModel.Migrations
{
    /// <inheritdoc />
    public partial class SuppliersINV : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SuppliersINV",
                columns: table => new
                {
                    SupplierID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Representative = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    ContactNo = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "DateTime2(7)", nullable: true),
                    DateModified = table.Column<DateTime>(type: "DateTime2(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuppliersINV", x => x.SupplierID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuppliersINV");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SafeSpaceAPI.Migrations
{
    /// <inheritdoc />
    public partial class V4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ID_USUARIO_SS",
                table: "SolicitacoesAjuda");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "SolicitacoesAjuda",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SolicitacoesAjuda",
                newName: "ID");

            migrationBuilder.AddColumn<Guid>(
                name: "ID_USUARIO_SS",
                table: "SolicitacoesAjuda",
                type: "RAW(16)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}

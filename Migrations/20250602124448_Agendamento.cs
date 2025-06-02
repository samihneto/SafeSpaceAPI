using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SafeSpaceAPI.Migrations
{
    /// <inheritdoc />
    public partial class Agendamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "URL",
                table: "ConteudoAutoAjuda",
                type: "NVARCHAR2(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<string>(
                name: "TITULO",
                table: "ConteudoAutoAjuda",
                type: "NVARCHAR2(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<string>(
                name: "DESCRICAO",
                table: "ConteudoAutoAjuda",
                type: "NVARCHAR2(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AlterColumn<string>(
                name: "TIPO_CONTEUDO",
                table: "ConteudoAutoAjuda",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");

            migrationBuilder.CreateTable(
                name: "Agendamento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    DATA_AGENDAMENTO = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    DESCRICAO = table.Column<string>(type: "NVARCHAR2(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendamento", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendamento");

            migrationBuilder.RenameColumn(
                name: "TITULO",
                table: "ConteudoAutoAjuda",
                newName: "Titulo");

            migrationBuilder.RenameColumn(
                name: "DESCRICAO",
                table: "ConteudoAutoAjuda",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "ConteudoAutoAjuda",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TIPO_CONTEUDO",
                table: "ConteudoAutoAjuda",
                newName: "TipoConteudo");

            migrationBuilder.RenameColumn(
                name: "DATA_PUBLICACAO",
                table: "ConteudoAutoAjuda",
                newName: "DataPublicacao");

            migrationBuilder.AlterColumn<string>(
                name: "URL",
                table: "ConteudoAutoAjuda",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "ConteudoAutoAjuda",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "ConteudoAutoAjuda",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<int>(
                name: "TipoConteudo",
                table: "ConteudoAutoAjuda",
                type: "NUMBER(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");
        }
    }
}

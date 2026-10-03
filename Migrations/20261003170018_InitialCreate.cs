using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wordz.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "words",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    _Word = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Meaning = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    AddedTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Lang = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_words", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "words");
        }
    }
}

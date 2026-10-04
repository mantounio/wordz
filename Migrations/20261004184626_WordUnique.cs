using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wordz.Migrations
{
    /// <inheritdoc />
    public partial class WordUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_words_Id__Word_Meaning",
                table: "words");

            migrationBuilder.CreateIndex(
                name: "IX_words_Id__Word",
                table: "words",
                columns: new[] { "Id", "_Word" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_words_Id__Word",
                table: "words");

            migrationBuilder.CreateIndex(
                name: "IX_words_Id__Word_Meaning",
                table: "words",
                columns: new[] { "Id", "_Word", "Meaning" },
                unique: true);
        }
    }
}

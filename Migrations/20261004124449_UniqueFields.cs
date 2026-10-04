using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wordz.Migrations
{
    /// <inheritdoc />
    public partial class UniqueFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_words_Id__Word_Meaning",
                table: "words",
                columns: new[] { "Id", "_Word", "Meaning" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_words_Id__Word_Meaning",
                table: "words");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    /// <inheritdoc />
    public partial class Test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "blog",
                columns: new[] { "Id", "Content", "CreatedDate", "FileName", "FileType", "Title", "UpdateDate" },
                values: new object[] { 1, "Content", "20-02-2024", "Test", "Test", "Title", "20-02-2024" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "blog",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}

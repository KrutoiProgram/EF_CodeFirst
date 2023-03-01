using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class Initial_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Blogs");

            migrationBuilder.AddColumn<int>(
                name: "BlogBlodId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Blogs",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_BlogBlodId",
                table: "Posts",
                column: "BlogBlodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Blogs_BlogBlodId",
                table: "Posts",
                column: "BlogBlodId",
                principalTable: "Blogs",
                principalColumn: "BlodId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Blogs_BlogBlodId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_BlogBlodId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "BlogBlodId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "Blogs");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Blogs",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");
        }
    }
}

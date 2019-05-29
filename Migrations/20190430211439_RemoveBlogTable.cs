using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InstagramAPIClone.Migrations
{
    public partial class RemoveBlogTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_Blog_BlogId",
                table: "Post");

            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropIndex(
                name: "IX_Post_BlogId",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "BlogId",
                table: "Post");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogId",
                table: "Post",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Post_BlogId",
                table: "Post",
                column: "BlogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Blog_BlogId",
                table: "Post",
                column: "BlogId",
                principalTable: "Blog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

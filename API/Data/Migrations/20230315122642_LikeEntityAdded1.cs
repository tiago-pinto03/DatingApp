using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class LikeEntityAdded1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Users_TargerUserId",
                table: "Likes");

            migrationBuilder.RenameColumn(
                name: "TargerUserId",
                table: "Likes",
                newName: "TargetUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Likes_TargerUserId",
                table: "Likes",
                newName: "IX_Likes_TargetUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Users_TargetUserId",
                table: "Likes",
                column: "TargetUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Users_TargetUserId",
                table: "Likes");

            migrationBuilder.RenameColumn(
                name: "TargetUserId",
                table: "Likes",
                newName: "TargerUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Likes_TargetUserId",
                table: "Likes",
                newName: "IX_Likes_TargerUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Users_TargerUserId",
                table: "Likes",
                column: "TargerUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

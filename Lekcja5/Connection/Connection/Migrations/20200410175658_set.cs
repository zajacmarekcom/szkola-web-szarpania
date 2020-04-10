using Microsoft.EntityFrameworkCore.Migrations;

namespace Connection.Migrations
{
    public partial class set : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HobbyEntity_Users_UserEntityId",
                table: "HobbyEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProject_Users_UserId",
                table: "UserProject");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_AddressEntity_AddressId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "UsersCustom");

            migrationBuilder.RenameIndex(
                name: "IX_Users_AddressId",
                table: "UsersCustom",
                newName: "IX_UsersCustom_AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersCustom",
                table: "UsersCustom",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HobbyEntity_UsersCustom_UserEntityId",
                table: "HobbyEntity",
                column: "UserEntityId",
                principalTable: "UsersCustom",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProject_UsersCustom_UserId",
                table: "UserProject",
                column: "UserId",
                principalTable: "UsersCustom",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersCustom_AddressEntity_AddressId",
                table: "UsersCustom",
                column: "AddressId",
                principalTable: "AddressEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HobbyEntity_UsersCustom_UserEntityId",
                table: "HobbyEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProject_UsersCustom_UserId",
                table: "UserProject");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersCustom_AddressEntity_AddressId",
                table: "UsersCustom");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersCustom",
                table: "UsersCustom");

            migrationBuilder.RenameTable(
                name: "UsersCustom",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_UsersCustom_AddressId",
                table: "Users",
                newName: "IX_Users_AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HobbyEntity_Users_UserEntityId",
                table: "HobbyEntity",
                column: "UserEntityId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProject_Users_UserId",
                table: "UserProject",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_AddressEntity_AddressId",
                table: "Users",
                column: "AddressId",
                principalTable: "AddressEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

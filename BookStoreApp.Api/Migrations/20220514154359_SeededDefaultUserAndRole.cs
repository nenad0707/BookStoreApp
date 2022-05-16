using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.Api.Migrations
{
    public partial class SeededDefaultUserAndRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "72e2887d-5644-4bfd-bf2b-915087dc8082", "faaffd03-d524-484c-b1b5-602922af4313", "Administrator", "ADMINISTRATOR" },
                    { "c6b23901-ae31-4788-9b7c-42bdd12805d8", "488386a6-c12a-417d-a1dc-607539b1cc31", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c751752e-b0ea-4032-8196-fa1037bfbb23", 0, "ec7c03a6-8f03-4290-9e29-e24d11ae3629", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEFmjQeqvifUfiQfNxQ85a4RJgJiD+i8Ia/tEy64i8CVq34pD4aMZ8ysdxJKDepTWBw==", null, false, "2d6823f5-5bb5-4c6f-9ddf-0da439b5fcf3", false, "admin@bookstore.com" },
                    { "fe1444e7-e218-40df-947c-e1c8de60b40c", 0, "76ab6b78-7242-4f27-a86b-ed438d86d3b4", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEHlk2ckg5obqs4xZMStQsUctBiwYk6x9LJ97I36fJtrJnlnuYUvhPE3QJHaLiBi4qA==", null, false, "6f9d8433-7158-485b-a9c6-e2f3b51ae5ac", false, "user@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "72e2887d-5644-4bfd-bf2b-915087dc8082", "c751752e-b0ea-4032-8196-fa1037bfbb23" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c6b23901-ae31-4788-9b7c-42bdd12805d8", "fe1444e7-e218-40df-947c-e1c8de60b40c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72e2887d-5644-4bfd-bf2b-915087dc8082", "c751752e-b0ea-4032-8196-fa1037bfbb23" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c6b23901-ae31-4788-9b7c-42bdd12805d8", "fe1444e7-e218-40df-947c-e1c8de60b40c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72e2887d-5644-4bfd-bf2b-915087dc8082");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6b23901-ae31-4788-9b7c-42bdd12805d8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c751752e-b0ea-4032-8196-fa1037bfbb23");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe1444e7-e218-40df-947c-e1c8de60b40c");
        }
    }
}

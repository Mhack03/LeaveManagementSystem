using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRolesandUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "69593294-da2a-411d-ab51-b2a2039ea8ed", null, "Administrator", "ADMINISTRATOR" },
                    { "ba546c2c-f506-463d-976d-cfa6f6d6383d", null, "Supervisor", "SUPERVISOR" },
                    { "db046d61-6c8f-4b1b-97f3-bbdf610444f8", null, "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "28cb7da6-8e79-4467-a2bc-f30fad495996", 0, "8a58beef-f253-4a42-8939-b4d01ed75887", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEAhaEdd88tvUHYCwF6qBUN905hKgPgfU2f6lTjMzsavBAPYpu3UrRgKIc9gSbHIK1Q==", null, false, "2e82efee-652e-4c34-af0d-e5764305dd13", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "69593294-da2a-411d-ab51-b2a2039ea8ed", "28cb7da6-8e79-4467-a2bc-f30fad495996" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba546c2c-f506-463d-976d-cfa6f6d6383d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db046d61-6c8f-4b1b-97f3-bbdf610444f8");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "69593294-da2a-411d-ab51-b2a2039ea8ed", "28cb7da6-8e79-4467-a2bc-f30fad495996" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69593294-da2a-411d-ab51-b2a2039ea8ed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28cb7da6-8e79-4467-a2bc-f30fad495996");
        }
    }
}

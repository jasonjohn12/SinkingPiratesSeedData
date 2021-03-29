using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeedDatabase.Migrations
{
    public partial class InitalMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ClassId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClassName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ClassId);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DistrictName = table.Column<string>(nullable: true),
                    DistrictNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    ClassId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Grade = table.Column<double>(nullable: false),
                    CreatedAtUTC = table.Column<DateTime>(nullable: false),
                    LastEditDateUTC = table.Column<DateTime>(nullable: true),
                    LastEditByUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    DistrictId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schools_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entries",
                columns: table => new
                {
                    EntryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedByUserId = table.Column<int>(nullable: false),
                    LastEditByUserId = table.Column<int>(nullable: false),
                    CreatedAtDateUTC = table.Column<DateTime>(nullable: false),
                    RecentContactDateUTC = table.Column<DateTime>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Contacted = table.Column<bool>(nullable: false),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entries", x => x.EntryId);
                    table.ForeignKey(
                        name: "FK_Entries_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    UserRole = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    SchoolId = table.Column<int>(nullable: true),
                    CreateAtDateUTC = table.Column<DateTime>(nullable: false),
                    LastActive = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "ClassName", "UserId" },
                values: new object[] { 1, "Principals of BioMedical Science", 2 });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "ClassName", "UserId" },
                values: new object[] { 2, "Chemistry", 2 });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "ClassName", "UserId" },
                values: new object[] { 3, "Physics", 3 });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "ClassName", "UserId" },
                values: new object[] { 4, "Biology", 4 });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "ClassName", "UserId" },
                values: new object[] { 5, "Algebra", 2 });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "ClassName", "UserId" },
                values: new object[] { 6, "English", 1 });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "DistrictName", "DistrictNumber" },
                values: new object[] { 1, "Piper School District", 206 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "ClassId", "CreatedAtUTC", "FirstName", "Grade", "LastEditByUserId", "LastEditDateUTC", "LastName", "UserId" },
                values: new object[] { 1, 1, new DateTime(2021, 3, 29, 14, 50, 15, 373, DateTimeKind.Utc).AddTicks(6520), "Harry", 60.0, 1, null, "Potter", 1 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "ClassId", "CreatedAtUTC", "FirstName", "Grade", "LastEditByUserId", "LastEditDateUTC", "LastName", "UserId" },
                values: new object[] { 2, 2, new DateTime(2021, 3, 29, 14, 50, 15, 373, DateTimeKind.Utc).AddTicks(7730), "Luna", 77.0, 2, null, "LoveGood", 2 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "ClassId", "CreatedAtUTC", "FirstName", "Grade", "LastEditByUserId", "LastEditDateUTC", "LastName", "UserId" },
                values: new object[] { 3, 2, new DateTime(2021, 3, 29, 14, 50, 15, 373, DateTimeKind.Utc).AddTicks(7770), "Hermoine", 58.0, 2, null, "Granger", 1 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "ClassId", "CreatedAtUTC", "FirstName", "Grade", "LastEditByUserId", "LastEditDateUTC", "LastName", "UserId" },
                values: new object[] { 4, 5, new DateTime(2021, 3, 29, 14, 50, 15, 373, DateTimeKind.Utc).AddTicks(7770), "Ron", 48.0, 2, null, "Weasely", 1 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "ClassId", "CreatedAtUTC", "FirstName", "Grade", "LastEditByUserId", "LastEditDateUTC", "LastName", "UserId" },
                values: new object[] { 5, 3, new DateTime(2021, 3, 29, 14, 50, 15, 373, DateTimeKind.Utc).AddTicks(7770), "Draco", 50.0, 2, null, "Malfor", 3 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "ClassId", "CreatedAtUTC", "FirstName", "Grade", "LastEditByUserId", "LastEditDateUTC", "LastName", "UserId" },
                values: new object[] { 6, 3, new DateTime(2021, 3, 29, 14, 50, 15, 373, DateTimeKind.Utc).AddTicks(7770), "Gregory", 40.0, 2, null, "Goyle", 3 });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "EntryId", "Contacted", "CreatedAtDateUTC", "CreatedByUserId", "LastEditByUserId", "Note", "RecentContactDateUTC", "StudentId" },
                values: new object[] { 1, false, new DateTime(2021, 3, 29, 14, 50, 15, 374, DateTimeKind.Utc).AddTicks(4480), 1, 0, "Did not turn in last assignment", null, 1 });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "EntryId", "Contacted", "CreatedAtDateUTC", "CreatedByUserId", "LastEditByUserId", "Note", "RecentContactDateUTC", "StudentId" },
                values: new object[] { 2, false, new DateTime(2021, 3, 29, 14, 50, 15, 374, DateTimeKind.Utc).AddTicks(4980), 1, 0, "Did not turn in last assignment", null, 1 });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "EntryId", "Contacted", "CreatedAtDateUTC", "CreatedByUserId", "LastEditByUserId", "Note", "RecentContactDateUTC", "StudentId" },
                values: new object[] { 5, false, new DateTime(2021, 3, 29, 14, 50, 15, 374, DateTimeKind.Utc).AddTicks(4990), 1, 0, "Did not turn in last assignment", null, 1 });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "EntryId", "Contacted", "CreatedAtDateUTC", "CreatedByUserId", "LastEditByUserId", "Note", "RecentContactDateUTC", "StudentId" },
                values: new object[] { 3, false, new DateTime(2021, 3, 29, 14, 50, 15, 374, DateTimeKind.Utc).AddTicks(4990), 3, 0, "She's too smart.", null, 2 });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "EntryId", "Contacted", "CreatedAtDateUTC", "CreatedByUserId", "LastEditByUserId", "Note", "RecentContactDateUTC", "StudentId" },
                values: new object[] { 4, false, new DateTime(2021, 3, 29, 14, 50, 15, 374, DateTimeKind.Utc).AddTicks(4990), 3, 0, "Left Message to parent. No Answer", null, 2 });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "EntryId", "Contacted", "CreatedAtDateUTC", "CreatedByUserId", "LastEditByUserId", "Note", "RecentContactDateUTC", "StudentId" },
                values: new object[] { 6, false, new DateTime(2021, 3, 29, 14, 50, 15, 374, DateTimeKind.Utc).AddTicks(4990), 1, 0, "Did not turn in last assignment", null, 3 });

            migrationBuilder.InsertData(
                table: "Entries",
                columns: new[] { "EntryId", "Contacted", "CreatedAtDateUTC", "CreatedByUserId", "LastEditByUserId", "Note", "RecentContactDateUTC", "StudentId" },
                values: new object[] { 7, false, new DateTime(2021, 3, 29, 14, 50, 15, 374, DateTimeKind.Utc).AddTicks(4990), 1, 0, "Did not turn in last assignment", null, 3 });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "DistrictId", "Name" },
                values: new object[] { 1, 1, "Piper High School" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreateAtDateUTC", "FirstName", "LastActive", "LastName", "PasswordHash", "PasswordSalt", "SchoolId", "Status", "UserName", "UserRole" },
                values: new object[] { 1, new DateTime(2021, 3, 29, 14, 50, 15, 372, DateTimeKind.Utc).AddTicks(2450), "Jason", new DateTime(2021, 3, 29, 14, 50, 15, 372, DateTimeKind.Utc).AddTicks(2880), "John", new byte[] { 59, 136, 59, 244, 121, 85, 69, 56, 176, 36, 125, 152, 202, 104, 43, 65, 56, 49, 110, 237, 33, 106, 215, 190, 99, 226, 226, 204, 213, 143, 189, 27, 214, 10, 66, 230, 187, 60, 245, 216, 103, 216, 17, 71, 97, 13, 69, 76, 124, 214, 126, 204, 166, 170, 35, 149, 21, 41, 2, 180, 99, 184, 166, 186 }, new byte[] { 252, 53, 60, 100, 141, 181, 239, 92, 177, 47, 241, 77, 205, 132, 8, 199, 103, 85, 94, 189, 14, 185, 235, 38, 43, 95, 149, 17, 20, 242, 113, 68, 30, 174, 148, 57, 59, 240, 133, 180, 164, 43, 182, 108, 161, 106, 12, 59, 130, 240, 91, 173, 85, 188, 235, 175, 5, 228, 5, 55, 156, 69, 142, 112, 159, 73, 251, 41, 72, 99, 138, 103, 90, 177, 0, 57, 54, 185, 103, 88, 187, 210, 206, 184, 2, 140, 217, 4, 116, 88, 77, 247, 233, 151, 149, 122, 109, 110, 115, 45, 227, 91, 150, 93, 29, 221, 145, 11, 53, 24, 172, 187, 151, 28, 92, 10, 23, 38, 247, 207, 151, 220, 213, 184, 193, 239, 146, 33 }, 1, 1, "jasonjohn12", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreateAtDateUTC", "FirstName", "LastActive", "LastName", "PasswordHash", "PasswordSalt", "SchoolId", "Status", "UserName", "UserRole" },
                values: new object[] { 2, new DateTime(2021, 3, 29, 14, 50, 15, 372, DateTimeKind.Utc).AddTicks(3590), "Shawna", new DateTime(2021, 3, 29, 14, 50, 15, 372, DateTimeKind.Utc).AddTicks(3600), "John", new byte[] { 198, 220, 210, 40, 7, 118, 91, 208, 64, 24, 187, 197, 107, 167, 105, 251, 153, 55, 104, 150, 174, 102, 222, 202, 198, 54, 59, 76, 86, 211, 95, 241, 135, 99, 207, 83, 112, 12, 208, 136, 208, 67, 78, 182, 187, 14, 58, 254, 107, 165, 106, 248, 237, 72, 19, 33, 195, 254, 214, 44, 125, 217, 56, 227 }, null, 1, 1, "shawnajohn09", 2 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreateAtDateUTC", "FirstName", "LastActive", "LastName", "PasswordHash", "PasswordSalt", "SchoolId", "Status", "UserName", "UserRole" },
                values: new object[] { 3, new DateTime(2021, 3, 29, 14, 50, 15, 372, DateTimeKind.Utc).AddTicks(3660), "Eric", new DateTime(2021, 3, 29, 14, 50, 15, 372, DateTimeKind.Utc).AddTicks(3660), "Mabie", new byte[] { 180, 255, 110, 119, 134, 36, 15, 123, 246, 28, 94, 114, 210, 157, 2, 100, 40, 186, 231, 218, 126, 3, 150, 192, 122, 73, 21, 129, 229, 236, 108, 87, 152, 17, 150, 181, 5, 164, 10, 80, 155, 138, 214, 139, 205, 83, 254, 251, 105, 154, 10, 158, 200, 243, 62, 39, 230, 207, 172, 230, 72, 131, 204, 168 }, null, 1, 1, "emaybe", 2 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreateAtDateUTC", "FirstName", "LastActive", "LastName", "PasswordHash", "PasswordSalt", "SchoolId", "Status", "UserName", "UserRole" },
                values: new object[] { 4, new DateTime(2021, 3, 29, 14, 50, 15, 372, DateTimeKind.Utc).AddTicks(3840), "Kalli", new DateTime(2021, 3, 29, 14, 50, 15, 372, DateTimeKind.Utc).AddTicks(3840), "Hinemen", new byte[] { 42, 178, 238, 209, 13, 227, 76, 65, 173, 224, 69, 91, 44, 42, 226, 241, 201, 51, 51, 34, 125, 101, 19, 235, 222, 253, 60, 241, 132, 224, 128, 196, 147, 114, 35, 196, 24, 107, 169, 62, 89, 179, 214, 134, 70, 103, 8, 48, 60, 69, 137, 250, 16, 96, 247, 155, 83, 152, 182, 190, 221, 66, 104, 214 }, null, 1, 1, "kallioop", 2 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreateAtDateUTC", "FirstName", "LastActive", "LastName", "PasswordHash", "PasswordSalt", "SchoolId", "Status", "UserName", "UserRole" },
                values: new object[] { 5, new DateTime(2021, 3, 29, 14, 50, 15, 372, DateTimeKind.Utc).AddTicks(3870), "John", new DateTime(2021, 3, 29, 14, 50, 15, 372, DateTimeKind.Utc).AddTicks(3870), "Ngyuen", new byte[] { 162, 235, 233, 140, 190, 206, 47, 63, 174, 247, 97, 232, 215, 144, 105, 36, 226, 2, 171, 251, 27, 7, 108, 155, 74, 207, 94, 81, 60, 132, 241, 27, 96, 19, 192, 122, 98, 88, 43, 152, 100, 244, 224, 86, 130, 186, 142, 91, 104, 211, 166, 132, 218, 153, 41, 149, 93, 201, 111, 104, 159, 57, 89, 152 }, null, 1, 1, "jngyuen", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreateAtDateUTC", "FirstName", "LastActive", "LastName", "PasswordHash", "PasswordSalt", "SchoolId", "Status", "UserName", "UserRole" },
                values: new object[] { 6, new DateTime(2021, 3, 29, 14, 50, 15, 372, DateTimeKind.Utc).AddTicks(3940), "John", new DateTime(2021, 3, 29, 14, 50, 15, 372, DateTimeKind.Utc).AddTicks(3940), "Tytla", new byte[] { 238, 105, 32, 159, 202, 50, 240, 43, 195, 133, 103, 164, 81, 244, 9, 254, 222, 126, 129, 48, 207, 16, 32, 204, 73, 25, 137, 216, 114, 75, 112, 112, 203, 226, 246, 28, 187, 78, 79, 134, 185, 22, 49, 247, 47, 197, 150, 27, 248, 95, 165, 116, 129, 10, 209, 49, 140, 131, 113, 173, 66, 29, 12, 64 }, null, 1, 1, "jtytla", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Entries_StudentId",
                table: "Entries",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_DistrictId",
                table: "Schools",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SchoolId",
                table: "Users",
                column: "SchoolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Entries");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropTable(
                name: "Districts");
        }
    }
}

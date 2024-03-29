using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolSystem.Infrastructure.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentsSubjectsGrades",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false, comment: "Student Identifier"),
                    SubjectId = table.Column<int>(type: "int", nullable: false, comment: "Subject Identifier"),
                    Grade = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Students Grade")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsSubjectsGrades", x => new { x.StudentId, x.SubjectId });
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Principals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Principal Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Principals Full Name"),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "Principals Email Address"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "Principals Phone Number"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Principals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Principals_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "School Principal");

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Teacher Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Teachers Full Name"),
                    IsClassTeacher = table.Column<bool>(type: "bit", nullable: false, comment: "Is the teacher a class teacher"),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "Teachers Email Address"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "Teachers Phone Number"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "School Teacher");

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Class Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, comment: "Class Name"),
                    AverageScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Class Average Score"),
                    TeacherId = table.Column<int>(type: "int", nullable: false, comment: "Class Teacher Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classes_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "School Class");

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Subject Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Subject Name"),
                    TeacherId = table.Column<int>(type: "int", nullable: false, comment: "Subject Teacher")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "School Subject");

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Student Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Students First Name"),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Students Last Name"),
                    ClassId = table.Column<int>(type: "int", nullable: false, comment: "Students Class Identifier"),
                    ClassTeacherId = table.Column<int>(type: "int", nullable: false, comment: "Students Teacher Identifier"),
                    AverageScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Students Average Score"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Students_Teachers_ClassTeacherId",
                        column: x => x.ClassTeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "School Student");

            migrationBuilder.CreateTable(
                name: "Parents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Parent Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Parents Full Name"),
                    ChildId = table.Column<int>(type: "int", nullable: false, comment: "Parents Child Identifier"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parents_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Parents_Students_ChildId",
                        column: x => x.ChildId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "School Parent");

            migrationBuilder.CreateTable(
                name: "StudentSubject",
                columns: table => new
                {
                    StudentsId = table.Column<int>(type: "int", nullable: false),
                    SubjectsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSubject", x => new { x.StudentsId, x.SubjectsId });
                    table.ForeignKey(
                        name: "FK_StudentSubject_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentSubject_Subjects_SubjectsId",
                        column: x => x.SubjectsId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "04870e99-9ba7-4640-8ef2-01fc2a1190d7", 0, "8ad08c3a-98a1-46b3-bd14-50908d3e351a", "radkaivanova@myschool.com", false, false, null, "radkaivanova@myschool.com", "radkaivanova", "AQAAAAEAACcQAAAAEOn7rNVbjV5Y3EsCs1r9p8TBSkrbQC+njecbXHmO1tIzIwUn9vnrpOrjOZUw6JJiIg==", null, false, "8ecd8926-771e-482d-9fba-be91628298b5", false, "radkaivanova" },
                    { "0c2174fe-5bfc-4842-9cb3-882a35a09902", 0, "0b8d43f3-62e0-4d2c-92f5-40ab5ec5aaf7", "m.ivanova@myschool.com", false, false, null, "m.ivanova@myschool.com", "m.ivanova@myschool.com", "AQAAAAEAACcQAAAAENrI5PeGuyV5koL5KTh9PfUlzwG36mf7mFK+ImU2mOzgqzLOx1/ZwiuE1z8uDg4pFA==", null, false, "3b8842fc-9ba0-4aff-9377-f0da0ca5c764", false, "m.ivanova@myschool.com" },
                    { "0dbed053-0ea2-43c1-b4b1-99a1d1197084", 0, "de6b3e1e-04ac-46a9-b85b-ed6ba635a608", "kameliapetrova@myschool.com", false, false, null, "kameliapetrova@myschool.com", "kameliapetrova", "AQAAAAEAACcQAAAAEAXjDU8Nf0Hm0ZZDnrfRMpkWlsR0TCmoFQeH0XbOmJhoiH30W47bsi5IO5IvryJKrw==", null, false, "55dee046-8f7b-46eb-873c-81e631c9776b", false, "kameliapetrova" },
                    { "0e119a09-9c6b-46c2-bb9b-5151d5b8a8d7", 0, "6e021e0c-e00f-4705-91aa-20080160c007", "borisstefanov@myschool.com", false, false, null, "borisstefanov@myschool.com", "borisstefanov", "AQAAAAEAACcQAAAAEDObXoEwTR1QoLAORihKsBlMvsRibPgIgapoG/8RwYCud9kaekY/pQdL+4PloD7LOw==", null, false, "bc8d2787-b2af-4ad4-8c5f-36841b3c3555", false, "borisstefanov" },
                    { "0f76fe6a-91ed-496d-aa60-ba07cda9c7e1", 0, "d6899b21-582e-489e-ba19-5d59fb4699f1", "kamenpetrov@myschool.com", false, false, null, "kamenpetrov@myschool.com", "kamenpetrov", "AQAAAAEAACcQAAAAEE4KMHT5tf8NkB8AxlhOPmi29hlDOde5bC6prUcpNM0RUm0OlMAKjIa+DE7FLmqnPQ==", null, false, "23127c96-01de-4da8-b652-f454cb32aa61", false, "kamenpetrov" },
                    { "0fe8a18a-0f52-4e41-8d44-292001678e5b", 0, "fb94bde5-ef70-42ed-81d0-8d05c98f0da5", "gerganaivanova@myschool.com", false, false, null, "gerganaivanova@myschool.com", "gerganaivanova", "AQAAAAEAACcQAAAAEJ23jSVluxvWxA0Z/n4myL0MuSC/6wbvTesi0u7YKrZLOwrcPRqCWAh8jvxBSeKkEg==", null, false, "2af681fe-2a71-4eb4-b8ae-08c697d4a82e", false, "gerganaivanova" },
                    { "109824cc-6b9f-4b1f-af65-87bb5a4ff79b", 0, "c188e9fb-306e-4707-80cc-8528f3cf476f", "milenageorgieva@myschool.com", false, false, null, "milenageorgieva@myschool.com", "milenageorgieva", "AQAAAAEAACcQAAAAEC9T1ZO+u1bZFpkuLwjTf7R2ZLgybFasJHTDJZWchBW5X2IjSLlgCoXD7HkhsYeHPQ==", null, false, "0df60dea-5ba4-4cd2-af87-6bca7a750f8d", false, "milenageorgieva" },
                    { "10b1bb25-7f3e-4ec5-bb68-9f8282850711", 0, "1d27e2c6-28ff-42c7-b9b8-a1afd47d9a88", "magdalinaivanova@myschool.com", false, false, null, "magdalinaivanova@myschool.com", "magdalinaivanova", "AQAAAAEAACcQAAAAEPiDnYx8XO3Gf/U9Q5FRgeaBcQ9K0xa4LTYxuxGsbrJoo69G3hXswHsF235YgE0Z/A==", null, false, "6b3e9507-720e-46d2-a15e-b42b77459220", false, "magdalinaivanova" },
                    { "11b2f953-01c9-446a-818f-778ce6a1f1a3", 0, "ff30357a-6355-4fa3-8eaf-656bdb85e05b", "ivayloivanov@myschool.com", false, false, null, "ivayloivanov@myschool.com", "ivayloivanov", "AQAAAAEAACcQAAAAEEsKe7Ha7msmPpZ808cBh3jlOpW05Jtn8Z67k5D7+Tl8hMVQGhQsIErYjngRtu3PcA==", null, false, "bdda9587-685a-4481-913e-0a32fbe34c8d", false, "ivayloivanov" },
                    { "1443d844-bfd9-45a1-94a5-83c18f140c0e", 0, "3cf369f0-2a4f-4c40-8ab2-6a05e4cbf4d2", "magdalenaivanova@myschool.com", false, false, null, "magdalenaivanova@myschool.com", "magdalenaivanova", "AQAAAAEAACcQAAAAEKWC7SkJGu6UCeSrK9appfDfMJbsGxRQhg/UleJ+npK9uIPikQKPCTXFSdupkf+8dw==", null, false, "8ff1c07b-5a00-4ee5-b1a2-84fb77f10f08", false, "magdalenaivanova" },
                    { "15b7349f-c184-42e7-9a18-0c0dd1a05bea", 0, "6cbb99b4-4861-43fb-818e-7c6a7b450d94", "bogdankolev@myschool.com", false, false, null, "bogdankolev@myschool.com", "bogdankolev", "AQAAAAEAACcQAAAAEOIx1cIcpZTiYyxNcET3g4Yz/mUM1mJ5SWdexUOrW0trybnpkbr1xPSA03OyJg6NUw==", null, false, "81b47619-8454-4f5d-b6b7-2ad87d03d011", false, "bogdankolev" },
                    { "162d8979-1a84-4642-9b27-49973518a040", 0, "41d89a46-0449-4407-a858-f6d309c50ea6", "valentinadimitrova@myschool.com", false, false, null, "valentinadimitrova@myschool.com", "valentinadimitrova", "AQAAAAEAACcQAAAAENU9JOO7MQQ2jkBaOMG+lcS5EIvVwY3XvKVavFaOC8/2uZ6lAnCBExwu0aYZyE4qAQ==", null, false, "05a0635c-3899-4f59-bdb0-3a8ec3939bf7", false, "valentinadimitrova" },
                    { "172ef32c-2c8e-49f9-8c0f-0d8236a98fc7", 0, "b24b2b5d-5d63-487e-9254-ccd7414e6f86", "georgimarinov@myschool.com", false, false, null, "georgimarinov@myschool.com", "georgimarinov", "AQAAAAEAACcQAAAAEDEH1HPW40LnxVr42QXVZEC9rSwl62nVzRJxyWrR01ICDMw912Mw7A+V9y58ngdIzA==", null, false, "1d161457-2c3d-4b64-97fc-8b882cbe971d", false, "georgimarinov" },
                    { "17b6757b-33e6-4d97-b8f4-22e3ec4e34a3", 0, "efc2c9f3-de10-4e51-b1d0-b24fae3a9c21", "nataliyavasileva@myschool.com", false, false, null, "nataliyavasileva@myschool.com", "nataliyavasileva", "AQAAAAEAACcQAAAAEMHFzcr4rv4jG5l54pUUTVWFQwWVO0+gWgqlB15QWxZpuu2tII63OjHQKqV9yBzN+w==", null, false, "fbf70070-b08c-4a88-8440-0c5d7152f4f1", false, "nataliyavasileva" },
                    { "1a36c289-32ed-42d0-8b6b-1f5490ecf0ab", 0, "d55ad855-25e0-41ca-beb5-f7a53fb42884", "ralitsakoleva@myschool.com", false, false, null, "ralitsakoleva@myschool.com", "ralitsakoleva", "AQAAAAEAACcQAAAAEJjl0nGwXeKZdC+zSyNIo1w0ef7QKVmplHZLdGIpNoXDvTlZzDhIE1qSJWR2m0pcZA==", null, false, "e1b3192e-fbe8-4a21-9288-9fec643aee5f", false, "ralitsakoleva" },
                    { "1b441729-6f7d-4d13-9f0b-3fe4e76727c3", 0, "963974bf-1a37-4152-a160-a7f871ae3f80", "radinkaivanova@myschool.com", false, false, null, "radinkaivanova@myschool.com", "radinkaivanova", "AQAAAAEAACcQAAAAEOyFe1qUzH3BnFqH+sQzApBwlABKFM07UVt2SxpeEUuCweKiQBBXCArXKY4Q91hApA==", null, false, "1b696655-bebe-454d-a88d-a9aea1aafa9c", false, "radinkaivanova" },
                    { "1b56c7bf-0f4e-4c3d-94db-7e81f4c32ebf", 0, "a0bba62c-b91b-45af-b28b-cabccbf1b297", "stefandimitrov@myschool.com", false, false, null, "stefandimitrov@myschool.com", "stefandimitrov", "AQAAAAEAACcQAAAAEO5nGmYaA/WZTaL/Ee+fymmnVa2bJXdFY+RHL5CA38XO4a37m4402mB15NLgl5HNyQ==", null, false, "813fd261-9803-4be3-867a-4e82b85cb2c6", false, "stefandimitrov" },
                    { "1e1b85b7-6c15-4f2c-b1c4-47ad0c8bf5f9", 0, "789800b1-9b3c-48fc-84c2-028d19d68035", "stefanivanov@myschool.com", false, false, null, "stefanivanov@myschool.com", "stefanivanov", "AQAAAAEAACcQAAAAEG+JZtMjhYWRAYskJWzGJqCAX/G3VdpIyMwp5mjM3NoWm6zE/j22LK0xFgvJI1Mv+Q==", null, false, "42c6da12-409a-41e8-9b6f-88ee9a9acf3f", false, "stefanivanov" },
                    { "1f49e02f-784c-4b51-856b-0fc301da5bf0", 0, "18f21f8c-cdac-45a8-9b12-90697011d803", "kristinapetrova@myschool.com", false, false, null, "kristinapetrova@myschool.com", "kristinapetrova", "AQAAAAEAACcQAAAAECEaibyF2TbTI1o2rRYqacfb1ywtMBs4JLsoolFtTuXvKwD/HqsAtnsPsMTf0BbD9A==", null, false, "84c77367-9b0f-45b2-96c8-d92adbe281ea", false, "kristinapetrova" },
                    { "21d56e3d-8c91-431e-a6e2-760848cf2aae", 0, "1de4d327-1fc2-4022-b4a7-40afc795b2b8", "dimitarivanov@myschool.com", false, false, null, "dimitarivanov@myschool.com", "dimitarivanov", "AQAAAAEAACcQAAAAEHSAJtI7rKAITBKY291zfADs4yfrQ3bES21mj/9h9a+l1YhjPJabTFlUVfvVzqiWJQ==", null, false, "50c93e82-1959-47c3-a483-a53cfb7202d8", false, "dimitarivanov" },
                    { "23dbfde3-00c5-47d9-b1b4-23f97379881e", 0, "2eac99c8-b466-4abc-8dbc-34c96a09c478", "radoslavgeorgiev@myschool.com", false, false, null, "radoslavgeorgiev@myschool.com", "radoslavgeorgiev", "AQAAAAEAACcQAAAAEPkdDRxiwIU5eQMlOKFIyy3LaLx5VYuIH7Z9vOUUf+f8vA024uktA7LmwxOOpD9PyA==", null, false, "7f74804d-b511-4de6-ba8e-ae51a5f98bff", false, "radoslavgeorgiev" },
                    { "23fb4de4-1bf9-4e72-9764-4c2d1f870990", 0, "c6ee1752-7e0d-4b82-8bfd-14aa0b779a1e", "teodoratodorova@myschool.com", false, false, null, "teodoratodorova@myschool.com", "teodoratodorova", "AQAAAAEAACcQAAAAEP4CFr/aJ1olYzpi2flfHWvaRYBax4W6ttVnZCEu7zIHEub2FF4IYbeT+iq7h8ON0Q==", null, false, "c15968df-8879-4379-9e39-db289cff8424", false, "teodoratodorova" },
                    { "2b765779-8f0d-4d01-b822-41fb42f9d173", 0, "0f565b46-d7a5-4f29-9298-149982b8cff7", "aneliyakoleva@myschool.com", false, false, null, "aneliyakoleva@myschool.com", "aneliyakoleva", "AQAAAAEAACcQAAAAENhjlqbN3Da/TaQynk/QEFXBhLmNWfr0i31NQx3nP7F1ABMXRyWUOgBtDFL6wEkIew==", null, false, "eba46c3c-166d-4e7f-8f97-502219f0378a", false, "aneliyakoleva" },
                    { "2b7c8f64-17f7-42f5-bb92-84b8f4d35f4f", 0, "96f1c8ee-3e01-4108-8535-ef773bb9ce56", "rosenkolev@myschool.com", false, false, null, "rosenkolev@myschool.com", "rosenkolev", "AQAAAAEAACcQAAAAEG/AZT3vQha0DgUXpSNwITfGCHmicLcv3biqBy4Ctbikr6uXBj+kCgZ7Xwy1pDvUDg==", null, false, "06f0afd2-523c-4c32-9667-4a08b61d0285", false, "rosenkolev" },
                    { "2b7e8569-4edf-46d1-8b07-d2a09977e361", 0, "8ab5682f-7048-4fa6-aa67-639b5f62de04", "velkovasilev@myschool.com", false, false, null, "velkovasilev@myschool.com", "velkovasilev", "AQAAAAEAACcQAAAAEFcD1BwdvNcI/kJUSfHEMD/B1IvNuimdvEJHmojdrLDOkOIsGvVIVSBZnjK86T/ALQ==", null, false, "e5db68e6-7653-43d9-935e-b94f57f8f0b5", false, "velkovasilev" },
                    { "2bd002d3-ff51-4a18-a155-dc76bba5130a", 0, "567d918e-49d1-4f94-b4e1-cd410bd8f31a", "darinkakoleva@myschool.com", false, false, null, "darinkakoleva@myschool.com", "darinkakoleva", "AQAAAAEAACcQAAAAEIubmooiZ85m0mJdVBZyx4sCKuubRD9tRKKIDPVXEP3M6w+v3p9uMKC8cjuENLtxWQ==", null, false, "baef5fc7-27dc-40ec-b0aa-f488f2ab07e7", false, "darinkakoleva" },
                    { "2c537f9a-c6ef-43d1-98da-e63d947de2bd", 0, "ab61127d-d8e8-4291-8d1a-2f659b9440f6", "martinkolev@myschool.com", false, false, null, "martinkolev@myschool.com", "martinkolev", "AQAAAAEAACcQAAAAEGXpndOZDL1b7RQvL/gFB0l8njo2In0U0S3AuktGPFz1RIhds+06kmYbMtmwoFEa7Q==", null, false, "217128b6-c291-4861-aab3-d1c2b962623d", false, "martinkolev" },
                    { "2d8f5db8-876c-4c0a-9c3a-91a4e724cbdd", 0, "293bc748-6c9b-49a5-be17-9446ccc1ef40", "plamendimitrov@myschool.com", false, false, null, "plamendimitrov@myschool.com", "plamendimitrov", "AQAAAAEAACcQAAAAEB4vb4afRBE8oOHZw4tEmw9okfduIEPEJoBaKpDMS+3Ys9QtQgjPZs1Xim6Ec1eU/g==", null, false, "3e33a1e2-978e-45ad-bed8-f1fefc3d1a6a", false, "plamendimitrov" },
                    { "2db4cc9f-8d87-4e13-97f0-8eb8b7ea00e7", 0, "5fd50d78-de6b-4b5c-9263-db191f15ce52", "b.bangeeva@myschool.com", false, false, null, "b.bangeeva@myschool.com", "b.bangeeva@myschool.com", "AQAAAAEAACcQAAAAEKUaPY43kd2S6BjBz2i1L/8sgvQSRqHA9MIE6D2ExrJJDlM9TmFRTqI85L4mAk8E7A==", null, false, "d538386a-4a5c-48c9-9418-96624f4d7bef", false, "b.bangeeva@myschool.com" },
                    { "2e07c9b0-d2a4-41e7-b8d8-0e0384c5e81b", 0, "ecc22440-4e08-4829-b368-f7d045a7a1a1", "mariyapetrova@myschool.com", false, false, null, "mariyapetrova@myschool.com", "mariyapetrova", "AQAAAAEAACcQAAAAECUny1JffgPukpe3EcSmgaFHsCGcQfdB3T4AK3vmKfu14BxnD69zOSWr4tCWI+1yDw==", null, false, "eac2a6ec-acb2-4c84-8cbe-cfba745907f5", false, "mariyapetrova" },
                    { "2e3c6d85-136f-4878-819b-9f982e6e4ed8", 0, "729db15f-2334-4e50-becd-ed852782d49a", "kristinakoleva@myschool.com", false, false, null, "kristinakoleva@myschool.com", "kristinakoleva", "AQAAAAEAACcQAAAAEFDvORgLnox6hsq2xibL6O0EUFaJhWW0jSU+dVrNKTdIG+GZf4lfKgzqqpqods/d5A==", null, false, "df4c20bd-9cb6-451f-9c1b-71a3dd32cb5a", false, "kristinakoleva" },
                    { "2ef3d2b3-3d7f-4d52-8a04-5433e1f869ec", 0, "31fb22c2-8b86-40de-8b68-5b6af93e4c75", "antoniyapetrova@myschool.com", false, false, null, "antoniyapetrova@myschool.com", "antoniyapetrova", "AQAAAAEAACcQAAAAEPF4rllfD7l1N2JQhtiXvOOHHbiEQTjbm0JWxN6n7IpSk73t7/Bk3MGGXHXDIs6U8w==", null, false, "df1cf7e2-8db0-4fe5-a5a8-03bba796b237", false, "antoniyapetrova" },
                    { "2f978b4c-4d9c-4ee1-aa1b-bdca0d1f89d6", 0, "df6fc425-fc45-4c82-a414-1c10f7ea837e", "tsvetelinastoyanova@myschool.com", false, false, null, "tsvetelinastoyanova@myschool.com", "tsvetelinastoyanova", "AQAAAAEAACcQAAAAEDHqmUFosBZlNeZy50aAEwsUO5vipU5lTd9Kh2/CRS+2j6ZUHUlUn2vww0rG0fozQw==", null, false, "2877400a-22f0-4f09-8397-d8f875282960", false, "tsvetelinastoyanova" },
                    { "30936933-775b-4687-8e1a-5a758bc5ed38", 0, "c8ad3a4a-5950-4981-96d1-ae6d452290af", "nadiakoleva@myschool.com", false, false, null, "nadiakoleva@myschool.com", "nadiakoleva", "AQAAAAEAACcQAAAAEFBFYZxdn874DEa/rIsZbcJsyamBOtWw1eCXFHmjV5uwWSRnyMIf92/vdDy7bkfbgw==", null, false, "37b78b18-1ee7-4726-af10-9bea09ba0615", false, "nadiakoleva" },
                    { "31b1f166-5412-40c7-b0cb-38aaec6a5ba6", 0, "8cf84bba-d2f0-41a0-89f7-888a474d7d0c", "stanimirtodorov@myschool.com", false, false, null, "stanimirtodorov@myschool.com", "stanimirtodorov", "AQAAAAEAACcQAAAAEEVuiStd+V3+mB7BAyt8WEhl9MVyryq3V5QKjSr5fEjZSAnA+5YrpjYzM0rqiJhl9Q==", null, false, "195c4069-d2d1-427d-908f-8300a56c0b5c", false, "stanimirtodorov" },
                    { "31d9f6c5-c9a8-48c8-8b5f-c990d06200ad", 0, "3f2ec359-5b8f-474a-b8ec-a50d61394990", "silviyapetrova@myschool.com", false, false, null, "silviyapetrova@myschool.com", "silviyapetrova", "AQAAAAEAACcQAAAAEKynqNPAbgsStGC8bARekG1l67EQvER6Yn/lScssdWdmk4BcSZq+3YRpbTUibnW4hg==", null, false, "221813c1-012c-46c8-9b39-3d1ad12a0ebd", false, "silviyapetrova" },
                    { "321efec2-563e-4f66-a158-7c2e4f7db24b", 0, "bc522a22-3885-4622-ab7f-f69676688c52", "tsvetanchogeorgiev@myschool.com", false, false, null, "tsvetanchogeorgiev@myschool.com", "tsvetanchogeorgiev", "AQAAAAEAACcQAAAAEFrtjQrJCmogmN4uu/edlf4K8Vsgk349rOd7Jn8OSBeoHcidZKFMP2I5+9maPyWVQw==", null, false, "dbff4306-bbbe-4f68-b2ec-d5d233d9926c", false, "tsvetanchogeorgiev" },
                    { "3251a6f3-1415-4173-8d95-509d9b57a4bb", 0, "c9d29d94-9e4a-42ac-9c62-2678d92d2910", "desislavdimitrov@myschool.com", false, false, null, "desislavdimitrov@myschool.com", "desislavdimitrov", "AQAAAAEAACcQAAAAEJ+9qVoxNsJnvhAgnXe3v82fDNdpEadbOj0WCczNiEDOg87G9SOnSr/hh6erMloBmg==", null, false, "696eb44c-5934-4be4-8869-23bb84fcf499", false, "desislavdimitrov" },
                    { "32d43d0a-632a-48fe-bc8f-68bb3f72f083", 0, "76f11e23-fa9a-4e24-a917-208606fa2c48", "petyakoleva@myschool.com", false, false, null, "petyakoleva@myschool.com", "petyakoleva", "AQAAAAEAACcQAAAAEFnEDGZtXaefYYxaX9P4WijpDb5rJaq9grFv5ggvySIERZp6dUUQFMVhf6Vy5auLUw==", null, false, "24af26e3-8255-4a94-92d0-b0b87f96e510", false, "petyakoleva" },
                    { "35af9309-d2fb-46a4-84b4-d3dfdaa6b7d3", 0, "1f1ab84e-0fe3-41c9-af61-7282c94647f2", "vasilenaivanova@myschool.com", false, false, null, "vasilenaivanova@myschool.com", "vasilenaivanova", "AQAAAAEAACcQAAAAEA1wkeaXdYghv0Q+b3FoFJuIDxxA65cSEchrmmfuVBxzrghGdI3mIR2MYZMKKasSdw==", null, false, "002dc13a-e2f0-4f46-a2cb-2855122ef8ac", false, "vasilenaivanova" },
                    { "3670d992-3c68-43a1-9862-1e14d65f8888", 0, "ba99b6c8-d1a4-4e9b-b895-de431e27badc", "todorgeorgiev@myschool.com", false, false, null, "todorgeorgiev@myschool.com", "todorgeorgiev", "AQAAAAEAACcQAAAAEFww7vgaqSYWx6DNeXGMxeGuZ9RLQKS7K8VJab+drj78/LbY3Hu51Y8YQdgNGyEcXw==", null, false, "6c8512cc-0191-4e0f-a9f0-4a00d3984100", false, "todorgeorgiev" },
                    { "39b55a1b-d8b5-4bb2-9e71-cc994a1463d5", 0, "5e9f7f36-ceeb-42d8-b30b-b830c8064c5a", "radostinaivanova@myschool.com", false, false, null, "radostinaivanova@myschool.com", "radostinaivanova", "AQAAAAEAACcQAAAAEO42t/pSi4ZG/i+bKtbSr2DqSyx7/c5xrsI3FrHcZt+kryD3jgA2ZdSkgo4JaCIbDQ==", null, false, "ec101865-6550-4a62-9114-d339fa6e05b1", false, "radostinaivanova" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3b3202f3-3f0c-4e15-9eb1-2c49b78aeb3b", 0, "ca991c23-cc1f-466a-b33d-ba0a509fb187", "ventsislavgeorgiev@myschool.com", false, false, null, "ventsislavgeorgiev@myschool.com", "ventsislavgeorgiev", "AQAAAAEAACcQAAAAEBA+b23i8eFOklkAcbXzErzdMQr7SXb8ibrP1Ns2hmgtzql53sQanV0ml4xwy/UOtw==", null, false, "b49b74cd-2a5e-4b23-8060-6e5f6e52610f", false, "ventsislavgeorgiev" },
                    { "3f0c19e4-df31-42e7-9421-882128123af3", 0, "ad045a3b-60f1-45bf-8593-f36d2cac7079", "veselinvasilev@myschool.com", false, false, null, "veselinvasilev@myschool.com", "veselinvasilev", "AQAAAAEAACcQAAAAELql3KtuFmra4WI/x3h1+0qO6bYEd9Ko72+ET2quXW3iWgaFYbMQ/VtWhXbfBZknnQ==", null, false, "0eda5294-d760-469e-8bdb-5f1bf858a568", false, "veselinvasilev" },
                    { "3f12d8fb-1251-48f5-b566-8f4ef5b2c5d5", 0, "32f787e4-0ad6-459a-98c8-f138fd4cf900", "evelinavasileva@myschool.com", false, false, null, "evelinavasileva@myschool.com", "evelinavasileva", "AQAAAAEAACcQAAAAEJEXE4rmOKpxAAT5/EPQ8x/0Bfz54jB2vG06cTTH/8xTJwLmke6wJEw7WxNoJ4VnOw==", null, false, "6aa04913-7612-4f42-9ae7-fb46b7aa87cc", false, "evelinavasileva" },
                    { "3f13969e-28fc-4315-b44d-b0f7b827202a", 0, "acc9708b-d470-4893-ad61-3fc196f66135", "gerganadimitrova@myschool.com", false, false, null, "gerganadimitrova@myschool.com", "gerganadimitrova", "AQAAAAEAACcQAAAAEJIOS/Q5OAD0W5s3wom2aksXQSCGGv0ZGyRzLux6asqfmc1fO07s0JAI/rQScM4zeg==", null, false, "3b362be1-47d8-408c-aef4-edafad8d230d", false, "gerganadimitrova" },
                    { "41ac68c1-84c8-4a2a-9f69-8571bb50e80a", 0, "c3a334be-51d6-4312-99ac-5ec14be5b6cc", "svetladimitrova@myschool.com", false, false, null, "svetladimitrova@myschool.com", "svetladimitrova", "AQAAAAEAACcQAAAAEJ0y6NCx39A1d+RW+tUW7QELIGI6WnMBwccVA0hu79tVOIKF5HddQYNduDHtsCUwiA==", null, false, "62558f7d-4d79-4ecf-8074-c17f5a2b4e00", false, "svetladimitrova" },
                    { "41c16c1c-6345-487b-9202-18bf7a723b5e", 0, "73a32317-d263-49dc-b993-738281f44807", "ivostoyanov@myschool.com", false, false, null, "ivostoyanov@myschool.com", "ivostoyanov", "AQAAAAEAACcQAAAAEP2+qdOUPHOrbcvNF0NN7Zo1VutgcepHY3P/Tq4+Uj3A0EEi2uLnVWOS3x4jSMFNQQ==", null, false, "17c47384-1c64-4e0b-97aa-44aca72fc1a7", false, "ivostoyanov" },
                    { "4ce7832b-e2f3-446f-8c63-720db3f89237", 0, "41249362-9deb-4662-83f5-642d390384de", "dobrinkaivanova@myschool.com", false, false, null, "dobrinkaivanova@myschool.com", "dobrinkaivanova", "AQAAAAEAACcQAAAAEBmaUvaGAKc401q5EP2s61eSxPpDDAPTvn02rABayWPHKSTfmuz4grp+GhcORceEAA==", null, false, "f6ca1bae-d9a2-4250-bb2f-cefc1618e4ec", false, "dobrinkaivanova" },
                    { "4ec6a858-e99e-44a8-822d-5292c378fbb4", 0, "e0077328-f91e-4696-8a66-02cccff88878", "martinpetrov@myschool.com", false, false, null, "martinpetrov@myschool.com", "martinpetrov", "AQAAAAEAACcQAAAAENEvh+Blk/Lm9u6JJyPTdAxMRndq2j1BbN+pGBunFoG4W2uuoF5F+rKGU9jBbjbN0A==", null, false, "0a52c534-3d9b-4d9e-9a87-671c5a1588a8", false, "martinpetrov" },
                    { "4f2d3e6a-8ef0-4e6b-80c2-9b487bbba2dd", 0, "64ca5760-1d58-4f9c-a685-4f13dd311693", "b.lozanova@myschool.com", false, false, null, "b.lozanova@myschool.com", "b.lozanova@myschool.com", "AQAAAAEAACcQAAAAEJWMQ4tknkU+GRrkReCkG+yiKM3ymvqKanxURbe+FNNWmUu06PxOlgOEzUA+7qHNOw==", null, false, "5931c0fc-cb04-4a61-ba4b-ab33770fe56a", false, "b.lozanova@myschool.com" },
                    { "5038ef42-267f-4a5d-8b92-2d63052265c8", 0, "e82f0005-0d76-4f2d-8343-c3240ed88f01", "krasimirdimitrov@myschool.com", false, false, null, "krasimirdimitrov@myschool.com", "krasimirdimitrov", "AQAAAAEAACcQAAAAEOro6lyBLdvBVEbG4VYBNGyt65Arh4SFaBXPltvH1v/kqPFMbb6+A/Xxc3Zpnh+ZIw==", null, false, "e8d4dcfe-eacd-4789-bd26-eddfc3b595b0", false, "krasimirdimitrov" },
                    { "512da3a0-4861-49ac-9142-1536f5ea2cb1", 0, "56d22f86-c66d-49ad-83e5-10fc51d69d01", "sonyaivanova@myschool.com", false, false, null, "sonyaivanova@myschool.com", "sonyaivanova", "AQAAAAEAACcQAAAAEBhae5/Q7ivZG31trtrBN3EG+dlOWa98EUpwghHwitCC4KXOojtNoiTVnGEqyZx/yw==", null, false, "18aa4515-c751-45db-a7ba-16003f71c575", false, "sonyaivanova" },
                    { "57e4c1a5-4c76-4cda-98ce-2e2a0a22c764", 0, "80a4b48e-c6a9-4dfb-b04a-e34e1a902334", "tsvetangeorgiev@myschool.com", false, false, null, "tsvetangeorgiev@myschool.com", "tsvetangeorgiev", "AQAAAAEAACcQAAAAEFuEl1CdH8J8xlpg3O4wwYTzvmFGNgthNWbcYh0wFfPRfG66UuTylYr3vSL4zo12ew==", null, false, "dea1bee9-b802-4146-ba3b-c83b72c9b12e", false, "tsvetangeorgiev" },
                    { "57ef3794-e725-4d7c-9d17-7b7ac01081c5", 0, "5911842e-78c5-405b-a30e-254e89109297", "vasilaleksandrov@myschool.com", false, false, null, "vasilaleksandrov@myschool.com", "vasilaleksandrov", "AQAAAAEAACcQAAAAEBkkvxxLbiNXdAgEmYb1TKrAq+2CvLCP0BiKCYJDgst8Jw6s4UngXA6m8ToCKg8Zjw==", null, false, "e42d0720-3f6b-4303-990a-d65433112cee", false, "vasilaleksandrov" },
                    { "5a119169-b39a-4e4b-8f7f-3ab86a6cebc4", 0, "b1d3deb4-5a7f-48de-ba67-eb407eb620c8", "marianapetrova@myschool.com", false, false, null, "marianapetrova@myschool.com", "marianapetrova", "AQAAAAEAACcQAAAAEOV00ZctjAFKw10EBtr7Nu/5g/J6ACWzdZw2eAM/d6naZU1LimviyZQ3kaJ2uMXKmg==", null, false, "ede1b34d-de6f-4ce6-bdf5-5f40a760c583", false, "marianapetrova" },
                    { "5a11fb1d-76ee-4c9a-8a9e-2534297cf94e", 0, "12fa816e-6d94-49a7-872a-6f634fc9e314", "r.mekova@myschool.com", false, false, null, "r.mekova@myschool.com", "r.mekova@myschool.com", "AQAAAAEAACcQAAAAEGwI1cx23/lWCrDHin4rv7aW9DZTFe1qOEqAwnDwjSFHjNTfYaM1V0towbaXZRWB+Q==", null, false, "56212ec2-4a80-43b4-b33e-1cebe7da6c5e", false, "r.mekova@myschool.com" },
                    { "5a141fd9-2bcf-4dab-8c0a-8c15b7c8dbef", 0, "cc16c0aa-b24b-40e9-b16b-c73caa7013d9", "elenakoleva@myschool.com", false, false, null, "elenakoleva@myschool.com", "elenakoleva", "AQAAAAEAACcQAAAAEF8hs04LcSfs9Lt9vjknK/efirUgdrsC4uo3lEIFdLNdH0OUDjMS5oCAaOOEaYf0AA==", null, false, "d4438fd5-ca7d-440e-b5c4-ff4b599a590f", false, "elenakoleva" },
                    { "5a52e138-0a2c-4b1a-8a68-b95de62aa345", 0, "51df660e-be34-4fb6-ac63-bc24fb6f4780", "yoanageorgieva@myschool.com", false, false, null, "yoanageorgieva@myschool.com", "yoanageorgieva", "AQAAAAEAACcQAAAAECsRrdlu+pQbeI88/MKTXnCOo1loCjpoC6QkAikZO2UXFGv1pDSJlkaI2dZeCSU1qQ==", null, false, "a3596eaa-1984-47db-a347-1a3d0c708dc3", false, "yoanageorgieva" },
                    { "5a7d1e4a-8f4f-4e52-9d14-06f9d3a134b4", 0, "82189ab9-0ea2-4100-8521-4c6485e5d5cf", "nikolaykolev@myschool.com", false, false, null, "nikolaykolev@myschool.com", "nikolaykolev", "AQAAAAEAACcQAAAAEBxopPG6y9lDVutXTUHgD4cIy1GOocbAAm2EmoqAFkJstHTezzcUxBI977kRZKz80w==", null, false, "848b130f-d3e2-4895-a8f4-5ff13f137bdb", false, "nikolaykolev" },
                    { "5b38fb70-63e4-4d02-a14f-3b58ff14bc76", 0, "57a50482-d669-4b5e-82c7-cb03e595bd55", "yavorivanov@myschool.com", false, false, null, "yavorivanov@myschool.com", "yavorivanov", "AQAAAAEAACcQAAAAEGOUV5f2gZBxGgDGqxnddzxzw5Ys5GBa5+1Nekcf42G3RbLWDmzgA70UH0O9yv2VcQ==", null, false, "bae9dc4d-39c2-4dd9-8e57-1f998d5b2ab0", false, "yavorivanov" },
                    { "5d5313c0-7da7-4ac6-aa0d-3e6a51fe09b6", 0, "8be79456-c7db-4786-b748-e6f4028a6e52", "yordantodorov@myschool.com", false, false, null, "yordantodorov@myschool.com", "yordantodorov", "AQAAAAEAACcQAAAAEKuTDBkrCGJw68UUgXai2x3KUDFoJyY2bDiPxBZ7x/77eZrRn+boHDVBhGPUF27NsQ==", null, false, "11a6e0c6-f8d7-40fe-be21-d6023226dbf2", false, "yordantodorov" },
                    { "5dbfbd88-cb21-4784-b7e8-6b0e618ad92b", 0, "54a09390-3a80-4735-b42a-064a99c3d052", "radostinageorgieva@myschool.com", false, false, null, "radostinageorgieva@myschool.com", "radostinageorgieva", "AQAAAAEAACcQAAAAECb8h+xprFB61V4oTMLeEq+RW3/gQGy1DgrpDef2pdv3rExw1CcznfplpE4lqrlyfg==", null, false, "1ed3ab29-2868-4c16-9bd6-26112a155354", false, "radostinageorgieva" },
                    { "5e4bb853-02b0-4e76-b28b-2181be91d1fc", 0, "69a3659a-b285-4646-94b6-aff6a4fd2df6", "ralitsaivanova@myschool.com", false, false, null, "ralitsaivanova@myschool.com", "ralitsaivanova", "AQAAAAEAACcQAAAAEFAcy2b27HvkV/Ib4tW4ho70RI6bz+byUr8sy+zsEsw9/yD679ZTaMrcdXmhcqULBQ==", null, false, "e6351aad-aa13-4cc6-a23d-9aa735186988", false, "ralitsaivanova" },
                    { "5e61439f-95d5-4e2b-9b0d-91e7c4472e3e", 0, "43885712-7ff8-4970-8457-a1fed61c73cc", "bogdanivanov@myschool.com", false, false, null, "bogdanivanov@myschool.com", "bogdanivanov", "AQAAAAEAACcQAAAAEBcPWCMdwmA8Aq2v3ROC92o7lJa2i72yqZiW6yCs0YuVCWqd3OvOjVXkq4s0c2WhBA==", null, false, "11586aa5-6aeb-4876-a24f-7533a13ba17c", false, "bogdanivanov" },
                    { "61f620da-d214-4e17-852a-c96fddcc682a", 0, "6356077a-5494-43a9-9137-96e8d1f12723", "elenastoyanova@myschool.com", false, false, null, "elenastoyanova@myschool.com", "elenastoyanova", "AQAAAAEAACcQAAAAEA3TE7Y6kPZx7vWHUAyWG4hE4xlRJOrFkiLWejARWtauA2Q1Ax6/Yn+XzE5rSFv74A==", null, false, "c2674044-29bd-4b7a-8584-0c8fb1cf393b", false, "elenastoyanova" },
                    { "65aa7d12-2f5a-4381-8c69-9b01523cf5e1", 0, "dbe08895-10ed-4cc6-9167-982ec8eb1295", "polinageorgieva@myschool.com", false, false, null, "polinageorgieva@myschool.com", "polinageorgieva", "AQAAAAEAACcQAAAAENFBuIZNuFZDH1+wRcGXeIDpGDXS0Kz/7ePav03BWD0OqZ7HMvdESwEraJGXCVaRDw==", null, false, "50e3e973-7385-4193-9980-1c70349d03ee", false, "polinageorgieva" },
                    { "65c645b2-cdf7-45d1-89d1-cd881a36ed98", 0, "5ad5df80-8b52-432a-8ac0-86939adfd9f5", "yankoivanov@myschool.com", false, false, null, "yankoivanov@myschool.com", "yankoivanov", "AQAAAAEAACcQAAAAEN1nQ4ejd/kEm+Jcf3XUn+D2lFRv4jfTI3PaK+FvMHVTu70ITGJ9AVS25Xr+afuMNQ==", null, false, "6eb1389f-1f05-44ac-846b-3fd182de7241", false, "yankoivanov" },
                    { "675b60ea-ee3f-4e58-b8d4-109b9ab54d99", 0, "41633b08-792b-435e-b114-246618e6b024", "ventsislavpetrov@myschool.com", false, false, null, "ventsislavpetrov@myschool.com", "ventsislavpetrov", "AQAAAAEAACcQAAAAENFDgBfpzdKdCOPO9SR9FFM3xnmQ0evb1xVkYn1v5Y486UDxTMyW7HKffuZYaJEhAQ==", null, false, "334714e9-6a06-40af-81bd-2c41e51d29ec", false, "ventsislavpetrov" },
                    { "6a4e15d5-29ae-4b86-9015-21d61e22e947", 0, "82a6df6c-7581-4854-9ac3-6a49300a2ce2", "kalinchopetrov@myschool.com", false, false, null, "kalinchopetrov@myschool.com", "kalinchopetrov", "AQAAAAEAACcQAAAAEJ44Ar7sm5e8Qv5dqB8a40uWGeaF1gQOfa8hnfg9/NOKAOQrA5D+EdRLqzLOSZzzyA==", null, false, "c061c6e9-41a4-4842-bb44-f2d3078e8576", false, "kalinchopetrov" },
                    { "6a56e5a9-b77d-492e-82c5-eab5c9397756", 0, "753bb473-5deb-4fab-926f-7da39f67e922", "vasilenkaivanova@myschool.com", false, false, null, "vasilenkaivanova@myschool.com", "vasilenkaivanova", "AQAAAAEAACcQAAAAEPkxEvshg9eBz7PjynY8ZnBe6TzoRG4Oq33AXM3uINTiL/nFKjvmJ3xMmgyu/I+nMg==", null, false, "4fd1bdaa-fbaf-4fa2-8322-a8a81e67dcb1", false, "vasilenkaivanova" },
                    { "6a9e1770-798c-43de-aad7-8d8a6ad5eeab", 0, "7fd1b529-027f-4c6f-a422-9d2b902d337b", "kalinpetrov@myschool.com", false, false, null, "kalinpetrov@myschool.com", "kalinpetrov", "AQAAAAEAACcQAAAAENgIBc0e9rFLsgztDzrKw2AfphXwQCh8EPbf8cgzsZKd4vNBE+PzV0GH9V6K+07FXw==", null, false, "a5f52f00-c8f8-4465-aace-0c73793e9bc3", false, "kalinpetrov" },
                    { "6b04a713-c12c-4a0f-aa0b-0eafde1543ac", 0, "a37ca680-178e-487b-a5f5-816488a6994a", "tanyastoyanova@myschool.com", false, false, null, "tanyastoyanova@myschool.com", "tanyastoyanova", "AQAAAAEAACcQAAAAEClrCpESjKItXvIfu2kr0WoiMhZEljBJUl9pb3qthIAh/C2bNxDtd1AeWcgpkaNVWQ==", null, false, "2b7d450a-79a7-4343-9082-e7a071a2b984", false, "tanyastoyanova" },
                    { "6b86569b-8f22-4a5c-9511-109f06d214a8", 0, "0cb08e75-5f22-4861-a62d-3c623a32abba", "blagoygeorgiev@myschool.com", false, false, null, "blagoygeorgiev@myschool.com", "blagoygeorgiev", "AQAAAAEAACcQAAAAEI87rwfPPiiQuD8yswbmjqcAqKf02AHe8numqnfaS90+4PG07e1kpV7nhAaJEph5Ow==", null, false, "b98dd5ab-05e0-4bbb-bfdb-735033453448", false, "blagoygeorgiev" },
                    { "6c704485-8f35-4b5d-aa5b-c971b87cb442", 0, "caa9c3a6-c2d1-46bf-946e-7bd96682b9a6", "ivankolev@myschool.com", false, false, null, "ivankolev@myschool.com", "ivankolev", "AQAAAAEAACcQAAAAEDwBTPT2kijCVm4+SUts7yJO1uT5Ya48YjtqsQCnqeidRrHBs9RNicB779qDuH2x6A==", null, false, "70ade5ff-4bf7-4a54-909c-d6300bfedaf4", false, "ivankolev" },
                    { "6d42e1d8-4e45-48b4-ba42-1a7f9c2a4a5c", 0, "40659721-1d92-488a-80c5-d8f88beb6fb2", "adrianaivanova@myschool.com", false, false, null, "adrianaivanova@myschool.com", "adrianaivanova", "AQAAAAEAACcQAAAAEMSSRXEpFaB0qg/4QIGD3rqInMeMZegOkj8cFRDUsNSq2zzhZ0jG04ByqfWRi4t8rQ==", null, false, "7852f79a-b027-48be-b33e-49b464e45cff", false, "adrianaivanova" },
                    { "6e3ac05f-09b1-4e65-9ab5-81a0c787e9e3", 0, "127a22ea-38a8-4e98-af9c-b66497ab8796", "emilivanov@myschool.com", false, false, null, "emilivanov@myschool.com", "emilivanov", "AQAAAAEAACcQAAAAEAPErvZ1r0MwYTIkwDm1PPFAMkXtBojuDhAVhkFzSP9LS8Q/W3ONEefAI/HgcVr2qw==", null, false, "7379f1d3-cc0d-4ec6-8c68-f89fb5e4eda7", false, "emilivanov" },
                    { "71c4c53d-0c7e-4d33-b8b3-15b3ff206249", 0, "13689fce-f827-4119-a168-9cf4a1e25fee", "nadezhdaivanova@myschool.com", false, false, null, "nadezhdaivanova@myschool.com", "nadezhdaivanova", "AQAAAAEAACcQAAAAEPqIpcLGnetezVSxuWIdmpS8qAEdScEBPdVjocqVUHKcIOj+cAxfVMqPl7FQ6XoBrg==", null, false, "89072584-b619-4cba-aa19-546e07ee4968", false, "nadezhdaivanova" },
                    { "731e88f2-bb26-46d8-8d53-031af77b5e15", 0, "a33586c4-4735-4a0f-baf6-ea3dac4428b7", "neligeorgieva@myschool.com", false, false, null, "neligeorgieva@myschool.com", "neligeorgieva", "AQAAAAEAACcQAAAAEGIdSnBdTF4p2c3JaVMmpIArRwfCUCI7/ImDE++TGo1+v0XZJdqMAnawvz9Bmp/SCQ==", null, false, "e99eb9f7-5d7a-4980-b59b-9133dc307f14", false, "neligeorgieva" },
                    { "7a68960f-439a-42ab-9a4c-10720fd21c95", 0, "d4d7da54-a300-4576-ad66-c9a64ed9fc48", "s.gancheva@myschool.com", false, false, null, "s.gancheva@myschool.com", "s.gancheva@myschool.com", "AQAAAAEAACcQAAAAEBxvjz7J9aLla3bR9dAle26F2ej7ADn73WAgXFIegzfOkvV4xDRye3/LcETp5Av5uw==", null, false, "2e874c12-4fe1-46c9-9015-b42a230066f9", false, "s.gancheva@myschool.com" },
                    { "7b1a2e32-bc36-4bf7-9b65-07fbfa810baa", 0, "05ec050f-fadf-4209-be33-0ca80161bb5e", "kalinadimitrova@myschool.com", false, false, null, "kalinadimitrova@myschool.com", "kalinadimitrova", "AQAAAAEAACcQAAAAEL7shwuWiU9zONsnmScGSdSfMNFM5m9vAedr7tCBzf7rTgSZO9cQ5EnL/BZGZ+1/1w==", null, false, "f29f01c8-9f24-44c2-8d5e-7ebfd0a52582", false, "kalinadimitrova" },
                    { "7d2f14fb-b3b5-4598-8989-ba10d3612c96", 0, "5706f041-c609-496b-8710-5f5cc48f19a8", "petarpetrov@myschool.com", false, false, null, "petarpetrov@myschool.com", "petarpetrov", "AQAAAAEAACcQAAAAECqI2+X534E34CpynBJaAh2eiDVuXUazUPPbdPyytedrAzFOouoIMVV0q613SxugmQ==", null, false, "6abe9518-c0e5-4117-9879-08c2dde37029", false, "petarpetrov" },
                    { "7d4e1b42-7463-4bcf-9d0f-eeb02a87d0c5", 0, "d8bc6251-5368-4146-a9de-d84c5e135795", "v.stoeva@myschool.com", false, false, null, "v.stoeva@myschool.com", "v.stoeva@myschool.com", "AQAAAAEAACcQAAAAEEPMTSUCIKeWm8LWkjVdRbDOhEVKB+Z/79dqRMiEIVuf9Yfn2UxeBgXpAk6H6TBUyQ==", null, false, "670bfdb3-445e-42cb-95ea-7ed356d4af08", false, "v.stoeva@myschool.com" },
                    { "7edf5ac1-2d87-4bf0-b2ed-4d2e4a7b9657", 0, "35748d02-5c14-41ae-9fa0-2d58b07e1ea2", "rumenivanov@myschool.com", false, false, null, "rumenivanov@myschool.com", "rumenivanov", "AQAAAAEAACcQAAAAEFlwkPgOf5eL64zoKDzlMJCzyqVg0S9u7KDO2fl+qSFk5VwR9zroB54HxHaMYV1ptQ==", null, false, "28f0f74f-5d35-4080-ace7-54153f4e5aa7", false, "rumenivanov" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7fbd8c2e-38c6-4a97-aa74-6321ee1f0e2a", 0, "004769e0-998e-4bfc-afcc-37749da1fe2b", "teodoravasileva@myschool.com", false, false, null, "teodoravasileva@myschool.com", "teodoravasileva", "AQAAAAEAACcQAAAAEMd0M6r7ie/JxgyB1GdLxaP6eC8nPgukhvmPHZ9OWt4TCP5ZEjjBiU7eGE4qywDyRA==", null, false, "ae5dc7a8-2e50-4e33-969a-98dc3f78703b", false, "teodoravasileva" },
                    { "7fc4b81c-0b22-4e35-bc17-c7c3e73d1874", 0, "76cfd2e8-301f-4f23-a3df-679e807ab550", "viktoriaivanova@myschool.com", false, false, null, "viktoriaivanova@myschool.com", "viktoriaivanova", "AQAAAAEAACcQAAAAEKJESY6tANNETo9NR4MWjaWPiLmZXAjk2gNu3h50vfHI4Oi0NU6ykzyCdWQCL4hNug==", null, false, "12d78908-5136-42d1-978f-6e111aebbf1c", false, "viktoriaivanova" },
                    { "80a73e8d-3a08-44b3-ba99-8a5ea3ebd012", 0, "96ec2dea-4521-455f-a500-227cab8d4dbc", "militsapetrova@myschool.com", false, false, null, "militsapetrova@myschool.com", "militsapetrova", "AQAAAAEAACcQAAAAEM85vWocFHfkZ0+RhEB/k2o0E6E282ry+fJw2r4BaQ9ev35FyB6UVgjOSf3lnpfYLg==", null, false, "1a944265-b7d5-45c2-b28b-b8656340079b", false, "militsapetrova" },
                    { "80f4cb68-199a-4f6d-8b82-6ad3521c0b52", 0, "10d09d7f-2081-4e70-a0f5-c367f6890e49", "yordangeorgiev@myschool.com", false, false, null, "yordangeorgiev@myschool.com", "yordangeorgiev", "AQAAAAEAACcQAAAAEJuFAHwzpIzXL353B5fQ4YWKhsU9RLDUK6BxAA4Z9UMdRazLnQ/wxvdMrkk7tqJkLA==", null, false, "8fd8d813-08c3-4cba-aff3-57f4a3ca93dc", false, "yordangeorgiev" },
                    { "8270e9b1-2c24-43e1-9f93-22d9923de12c", 0, "ebbb5453-11dc-4490-a9ec-fb0569d6a3d7", "lyubenmarinov@myschool.com", false, false, null, "lyubenmarinov@myschool.com", "lyubenmarinov", "AQAAAAEAACcQAAAAEARQGbO9pd1KH6LOl1O8zjqqQLnv+NZdqjp/km9XeIF8irZiAZAKME1yJxOdcpNfQA==", null, false, "138e1409-eac7-421e-9910-ec7dafd4870b", false, "lyubenmarinov" },
                    { "844dd2c8-e20b-4423-827f-349e0bbd2761", 0, "6f6a92ee-1ef0-48e8-b16b-ad4c708b4f34", "zdravkokolev@myschool.com", false, false, null, "zdravkokolev@myschool.com", "zdravkokolev", "AQAAAAEAACcQAAAAEG6z/CLlMkRCHq8Omj27cNHjoRZPPOJEiWaAd1IfFl0pdJM7evQr4qK8KtPHrXhl8Q==", null, false, "80a9ae0a-26d3-449d-b4d9-bcc2582d66ed", false, "zdravkokolev" },
                    { "84ab245c-804d-4ac7-8f9e-bcda15863c5c", 0, "721684ac-bf6c-45c2-9200-520318e89bf4", "asengeorgiev@myschool.com", false, false, null, "asengeorgiev@myschool.com", "asengeorgiev", "AQAAAAEAACcQAAAAEIBzu2wwGE90qLhhjgIqx/v4NRkL+GaR0R+JA+vbJSFE4nJFSo4/M8EYZdMIHQrN+g==", null, false, "47111771-a5b1-45ee-968c-9f2e8aaf78b1", false, "asengeorgiev" },
                    { "85bb508a-2d95-42d9-aa43-0e4fe33497a0", 0, "2cb84878-e150-470b-a489-daa2b4e34b88", "ekaterinageorgieva@myschool.com", false, false, null, "ekaterinageorgieva@myschool.com", "ekaterinageorgieva", "AQAAAAEAACcQAAAAEEnNSKxJ8Qiza1PGzvWKQeaDfRbTBR3gKp6LKKUa3EzNTFydGtN+AcDrTvPDZXBEXg==", null, false, "955c8c36-6a3c-4c5a-936c-3482c9eebcae", false, "ekaterinageorgieva" },
                    { "87c52768-9d12-46c1-ae72-0dcf9f415f39", 0, "13e7643c-4485-48e1-9f74-2103ce3b0f90", "veronikapetrova@myschool.com", false, false, null, "veronikapetrova@myschool.com", "veronikapetrova", "AQAAAAEAACcQAAAAEF2KnzHL9ttbchzOuu0GNpbZj3c3s7NSZ3klB6MOGfU2GTkE1zaz9tO0qBIIQRFmNw==", null, false, "67a98adf-4abe-4afd-a60e-32e3bf62673a", false, "veronikapetrova" },
                    { "87e879c3-5c01-41d1-9e08-0a667172a0c7", 0, "942491b1-4453-4225-bd0c-fff29a947261", "zhivkaivanova@myschool.com", false, false, null, "zhivkaivanova@myschool.com", "zhivkaivanova", "AQAAAAEAACcQAAAAECCR16hgYqeN1NvyQwZVNwUH9Jwf4oWfvtf0Cgtkbbowm5A5gSbRNGl8pddC6Ut7vw==", null, false, "b568803d-8b4c-4f5e-91a4-a7e1c661548a", false, "zhivkaivanova" },
                    { "8a4b8f2d-72e8-46d1-8a9f-2d06b1d9ecf1", 0, "0731e79b-cb87-47a8-bce6-84e9361ccb48", "lyubomiratodorova@myschool.com", false, false, null, "lyubomiratodorova@myschool.com", "lyubomiratodorova", "AQAAAAEAACcQAAAAEE/aK6Zkst3SYFmXhL0LgJAr30JHRoaPU1k6vTJDkM2UKu9mlbanGSPOzQXC1cPD9A==", null, false, "c0e593cb-374a-4ca5-a551-1e7ddb1ac16e", false, "lyubomiratodorova" },
                    { "8a7389a7-17c1-4f0a-96e9-0929cfa1c9b1", 0, "8092cd92-6900-4a08-9f45-2b835dde9c9a", "t.hristov@myschool.com", false, false, null, "t.hristov@myschool.com", "t.hristov@myschool.com", "AQAAAAEAACcQAAAAEPf6qKU07E/9mLTH1YpF4lU6tuCZwqF4HlYoKcba14a/xu1We/CAS76N+k2sxy0UNg==", null, false, "9aeef0d2-43a7-40b0-8bb1-4b14ab29a979", false, "t.hristov@myschool.com" },
                    { "8b7f9c67-7985-4f3f-a2a1-271189e22a0d", 0, "671e1c28-d99a-4603-b3b1-ebb46595c1eb", "kameliyatodorova@myschool.com", false, false, null, "kameliyatodorova@myschool.com", "kameliyatodorova", "AQAAAAEAACcQAAAAEHI13RiKh63LpigAYWg/1xo+6fZ1rcaalOEi2ZIctZn9BwJtCSam+6tdZ2SagM3gbg==", null, false, "f9884465-eb6b-45fc-a51f-16988c844fe0", false, "kameliyatodorova" },
                    { "8c0cb95d-0e1a-40c4-9e2f-2542d530dbaa", 0, "294efebc-9dd1-4806-b82a-dd7a432fb936", "aleksandartodorov@myschool.com", false, false, null, "aleksandartodorov@myschool.com", "aleksandartodorov", "AQAAAAEAACcQAAAAECqKmwJgdkHmjSggL9kcrqdKYz2w0UfX3EvQ87rfwgXBs1FZRn/3XvyhPfY0amngLA==", null, false, "add13a78-129b-4262-b84a-4aa145ada470", false, "aleksandartodorov" },
                    { "8c9965a3-36a4-4a6b-ba5a-7f3a262aa0c3", 0, "42c74afc-f4ae-4aaf-a837-af65ba2821b2", "yulianpetrov@myschool.com", false, false, null, "yulianpetrov@myschool.com", "yulianpetrov", "AQAAAAEAACcQAAAAENw9J1GXUIAZPaJVhzD5BZ9oOb9Uw0P2gvKkn07ZvKTF02xIzRc/BKoGwRwZ9sFS0g==", null, false, "b05458dd-dc34-491d-aaf6-8c70bba0743a", false, "yulianpetrov" },
                    { "8d0a37e9-91a1-4b3a-86a9-b57595b104ab", 0, "e3876d4c-f762-417b-9388-5dbc8716fea0", "vanyakoleva@myschool.com", false, false, null, "vanyakoleva@myschool.com", "vanyakoleva", "AQAAAAEAACcQAAAAEBN5N5nXQPr3yMJ27MSNINJrLNExAYfAqFyMpAwXptE5MdY6mTGyhabGxwG3lZkfVQ==", null, false, "5fbbfa4d-e3f1-42cc-b625-2e4f8be0d940", false, "vanyakoleva" },
                    { "8d9f8a3f-16a2-4fe5-b12a-32c3f3c66fb1", 0, "8457e22a-969e-426e-b116-19ded9f0df88", "kirildimitrov@myschool.com", false, false, null, "kirildimitrov@myschool.com", "kirildimitrov", "AQAAAAEAACcQAAAAECFGbTm2Tk1HUgzTcxvw7Kk7sBmVVyM6dw0yhIsWUSLljwwO/kXvhqHLYwT27RhPPQ==", null, false, "cc65fd39-7141-4f34-90cf-8d0163278867", false, "kirildimitrov" },
                    { "8e9d7e5c-3429-426e-8bf7-256f874a189a", 0, "167b1eb5-78b6-41f0-97c2-7042839eb5cf", "kaloyanivanov@myschool.com", false, false, null, "kaloyanivanov@myschool.com", "kaloyanivanov", "AQAAAAEAACcQAAAAEPSF22bpj9IGUvmhF0cUlGneAXs9zHZxfF8zmlWLhYeyRyQAxjZl3+ocvp/Tz5deFA==", null, false, "d11fe0ee-0445-4086-8e84-61c6a3247e33", false, "kaloyanivanov" },
                    { "8f35f8dd-b52a-4084-818b-3e1813e42f19", 0, "6990d412-9e64-448d-8218-5f8f7e388de4", "danielamarinova@myschool.com", false, false, null, "danielamarinova@myschool.com", "danielamarinova", "AQAAAAEAACcQAAAAEH6dbuTXMItPhFOMVCITXCBNJ8FlBZIvmz3kXr3VrVY04d6+rvtWJ6xecKMSNoC0KQ==", null, false, "57870ae2-3cc8-4e80-abbd-3939243dca0f", false, "danielamarinova" },
                    { "923f8d7d-c02d-4177-a5f8-6b6975a7119b", 0, "61937d36-c4c9-4e99-8830-4a14a6619b3d", "iskrakoleva@myschool.com", false, false, null, "iskrakoleva@myschool.com", "iskrakoleva", "AQAAAAEAACcQAAAAELLVgFrmXRJdSE/6e3RP+qXCzsHMSQMX2Z5QG08cRQGHmIkfjAWBnSwvHLgEaVuymw==", null, false, "b608aff6-c3b2-4b91-b297-ee114201b87a", false, "iskrakoleva" },
                    { "93a6ac3b-c8c9-4a24-a00b-4f54e2f4d2d7", 0, "1e0d97fa-9d3b-4732-ae6d-6f93d543e5ab", "mariavasileva@myschool.com", false, false, null, "mariavasileva@myschool.com", "mariavasileva", "AQAAAAEAACcQAAAAEAz4vX+8xEzqM93ko9teHQoYdUEsU7du4vLo0DchVHlgVwYtZKZId5RXhHpZY1o4yg==", null, false, "558311b3-5b95-47fa-8964-4a406ef88a39", false, "mariavasileva" },
                    { "95226fbf-1ebd-49c2-aaaf-71788a690ac5", 0, "2e63548b-ea89-4f6c-a872-029a4639b183", "vasilpetrov@myschool.com", false, false, null, "vasilpetrov@myschool.com", "vasilpetrov", "AQAAAAEAACcQAAAAEFNCuueAxkHmG8bpzSZBoaOsBPkYvketSdIYYCV63X9+s6g9BZZd8lCJGou/hUFnQA==", null, false, "ad2835fc-c42a-4cf2-8f21-f0a87bc7e0a7", false, "vasilpetrov" },
                    { "961b318b-7e65-4ef9-bf8e-3e22f74cdd6d", 0, "2231b773-17c0-4792-a684-a845fdacca5e", "iliyapetrov@myschool.com", false, false, null, "iliyapetrov@myschool.com", "iliyapetrov", "AQAAAAEAACcQAAAAED+r0nbpDABN+Zdxaqkk+2C6swpT9a7tM8zy3UsPTPKG/wx5uV/pXpMtaiEmrwCu0w==", null, false, "24e41f55-0b3f-48cd-ac39-a6afb69843b7", false, "iliyapetrov" },
                    { "98fb09c1-54d0-4d9c-86ee-7f7b510695ef", 0, "d5bbb9e1-7304-4e97-8c4d-c57e57c41a28", "bozhidardimitrov@myschool.com", false, false, null, "bozhidardimitrov@myschool.com", "bozhidardimitrov", "AQAAAAEAACcQAAAAEOqMG0ylNAyqVfOWV6xDD0lq5+AGaPEb1j3lCiOO8kIhYZWEQV0eCvexZsJODYeLug==", null, false, "c242e21c-21e4-4eb5-a941-4cd45f33f761", false, "bozhidardimitrov" },
                    { "9b9474b0-06ab-4953-8f23-cff7e88c7a0b", 0, "2123a1be-94a2-4bcf-ad38-392f54df57b1", "margaritageorgeiva@myschool.com", false, false, null, "margaritageorgeiva@myschool.com", "margaritageorgeiva", "AQAAAAEAACcQAAAAEJYPWPFgbmO8hoXF926/I1qVmJAVjSRN8pfBg/MI8J3SPNwL/oKd8CFUpTx3im67Vg==", null, false, "207d60af-5213-4965-ba8e-7da1dfd23a41", false, "margaritageorgeiva" },
                    { "9c1e0838-6a1b-4158-92a2-36c6234e9d41", 0, "6abfc53f-ab4a-4b5b-8d53-6792b7e2d0c9", "lyubomirgeorgiev@myschool.com", false, false, null, "lyubomirgeorgiev@myschool.com", "lyubomirgeorgiev", "AQAAAAEAACcQAAAAEIUOZKss+DnMkpXZ8OxZtgVA57OB4OdJ7oP6wDQnaylaVtehJAQt/rPTcbZ11mN6Tw==", null, false, "7d1182c6-4176-4826-ab3b-dd4d9524a3d2", false, "lyubomirgeorgiev" },
                    { "9e32eab9-84e3-4b35-bb92-89b3dfb8e98f", 0, "9a3c3966-fe7e-4c24-85e9-529be2c7cd92", "silviyaivanova@myschool.com", false, false, null, "silviyaivanova@myschool.com", "silviyaivanova", "AQAAAAEAACcQAAAAENR8qYWsXDmX0A08h1LKEMQfTBoVdR9cOLPxcmNhenP00DZDHIt1ycjPHYnKhylx2A==", null, false, "5bac8ad7-05a2-4e07-b396-f9266ecdb1a5", false, "silviyaivanova" },
                    { "9e3dbbc2-33d7-4c57-a3ee-5b7e19b1c3c2", 0, "c65d5e4a-8dda-4913-8721-28cb11dd1bdc", "ivaylokolev@myschool.com", false, false, null, "ivaylokolev@myschool.com", "ivaylokolev", "AQAAAAEAACcQAAAAECSD7Q/5syi5wLV8tBAxU0PukyOkKbfq5+SI6KiT2FWt1GrYxQfbaOyaaIzd4vaNKA==", null, false, "aa7fec6d-ed22-4133-b364-d8a2fe9bd8a2", false, "ivaylokolev" },
                    { "9e8741d5-65d9-4cc0-b7b6-ff1b688c34f1", 0, "65d07e86-f406-4da2-aedd-953285ccd0cc", "adriyanastoyanova@myschool.com", false, false, null, "adriyanastoyanova@myschool.com", "adriyanastoyanova", "AQAAAAEAACcQAAAAENQrXnBPJGWuDEbON+YRwcjwAupdWuxRIHBBf+fa1qMMT30Sgf+BQAIX/wtEln8tmQ==", null, false, "1cb1a8f4-e7d9-4b30-a290-5f25ec87c2aa", false, "adriyanastoyanova" },
                    { "a0e8ee4a-4dbb-4a5e-b97f-e35c542b778e", 0, "59947127-4499-4bc2-a74b-5e6dc7e585f0", "krasimirtodorov@myschool.com", false, false, null, "krasimirtodorov@myschool.com", "krasimirtodorov", "AQAAAAEAACcQAAAAEH+fe8nZMY5jcA/pHzhvfU5Rnmf+pF8MeVHLgs5s52/ZZEgbFHHNR8rtRQEsSXPSrw==", null, false, "e3c8b763-90ba-4462-9243-0feb866bf61e", false, "krasimirtodorov" },
                    { "a15da546-3bc8-4ee7-90cd-172a2180f220", 0, "666be425-8f13-43c9-9752-1c2c8fba3c24", "m.mitkov@myschool.com", false, false, null, "m.mitkov@myschool.com", "m.mitkov@myschool.com", "AQAAAAEAACcQAAAAELpPHiCH8X8lsAB5qw34QFg3PXZhNXqbPel/oN9Ni/CdX9+SwigsnIhlB61d6WuUWw==", null, false, "90ed39fd-0647-4a85-a90d-479dd692e602", false, "m.mitkov@myschool.com" },
                    { "a22b38b9-85b0-4fe0-9d5c-7e3d9aa55a45", 0, "5ac1bc8d-2b5a-491f-9b0a-1a6199f8b12c", "snezhanageorgieva@myschool.com", false, false, null, "snezhanageorgieva@myschool.com", "snezhanageorgieva", "AQAAAAEAACcQAAAAEHQlZQcXYIjvuLT8lJYSQnQoagDwgzWuPaDBVrulZkUg649oxg1ffyDl6cs9kKfg5Q==", null, false, "94817fde-f629-476a-ad6b-24bfcc1dfc9a", false, "snezhanageorgieva" },
                    { "a3bd2a1d-5061-439e-aec9-0e54720e3ed5", 0, "236f0f52-1592-43f6-a1f7-7306d4d8e5ba", "stefaniyapetrova@myschool.com", false, false, null, "stefaniyapetrova@myschool.com", "stefaniyapetrova", "AQAAAAEAACcQAAAAEFTGjaqb8WFT2uj9r7Y5jPDpXJDTI22h5bd30sg/+h6bR02VhKVK+75+epK4Ya9dBQ==", null, false, "2ea00cb3-f69e-415e-be2e-6801ad206f6c", false, "stefaniyapetrova" },
                    { "a4d2bcdc-23da-4395-9b9b-2087cc52bafe", 0, "1608b240-cd61-4a57-a5db-4f800256a1c4", "krasimivanov@myschool.com", false, false, null, "krasimivanov@myschool.com", "krasimivanov", "AQAAAAEAACcQAAAAEL1WE4gsycLr4ElicOlXEkbYGpvURGcmJR7Vgq9yN8WmKlsFQJs1uZV7dUAUpNINcw==", null, false, "3f95300a-e93b-4a12-ad12-410be15051fd", false, "krasimivanov" },
                    { "a7201fc2-3e05-4ad0-a0f3-1f925f05e0b1", 0, "721ad385-1d51-4bb6-8170-0fd3680b5dea", "dilyanaaleksandrova@myschool.com", false, false, null, "dilyanaaleksandrova@myschool.com", "dilyanaaleksandrova", "AQAAAAEAACcQAAAAEMW4+EWSnrp9Fl7pk8WXROz+bcXLLyWDScVtM2Ws15Bj3jzKgCzZtgjzJ7+xHgWJjQ==", null, false, "09c5f746-aa4f-4d32-a67e-92356a72105e", false, "dilyanaaleksandrova" },
                    { "a7f2842b-bfd9-4e04-994a-c5f16bfefc10", 0, "00d8ad44-3a16-4368-abbe-70573f5a8849", "ivodimitrov@myschool.com", false, false, null, "ivodimitrov@myschool.com", "ivodimitrov", "AQAAAAEAACcQAAAAEJXTx5y59PUpSNic1cSovL5b1+zcYp85x3+CfOZawSrqvgBPO6a5b0RpEDlKXHYdAw==", null, false, "32ff6a2f-d792-4efa-bdd9-8879d3915d59", false, "ivodimitrov" },
                    { "a8f87e34-d5ae-4c46-aa1d-2f3cc6e11d2a", 0, "81779737-854d-4dd3-b791-05f752b3f622", "bozhidarakolev@myschool.com", false, false, null, "bozhidarakolev@myschool.com", "bozhidarakolev", "AQAAAAEAACcQAAAAEN0/cikXKEEF4ce9vTjx4O0wrAAqdTI/SkHpERjw+LP05WTWWzMd4g+uEchitr5cNw==", null, false, "130ee667-860e-46c9-80db-ba09a54742c0", false, "bozhidarakolev" },
                    { "b122f303-2d44-4f3d-bdd8-dac3626da548", 0, "88c3b6c3-9be4-4941-941c-917a4e3a037d", "hristodimitrov@myschool.com", false, false, null, "hristodimitrov@myschool.com", "hristodimitrov", "AQAAAAEAACcQAAAAEGF3o1RE57hfFy3zhDS6hwamCvSSKgZHamaN8GV/gpyRXgeO457xcNskwLbtEoJf5g==", null, false, "ba3f9d37-ccd4-4ada-894a-4c2c90adb3c2", false, "hristodimitrov" },
                    { "b2c8a67c-5a1d-4e23-9c85-0c57454de9ee", 0, "d83e75a3-edc9-47c2-83a7-9fdd0c5cd5d3", "krasimirapetrova@myschool.com", false, false, null, "krasimirapetrova@myschool.com", "krasimirapetrova", "AQAAAAEAACcQAAAAENyz0oiSaJ1xNpoHP0BSAjADbUALHEy/e6qT4gSFr5nnSYAR2oXGIAZXhSa0wZX27w==", null, false, "a68e23e4-d349-4633-9832-ae84ca8acfef", false, "krasimirapetrova" },
                    { "b2f18679-974f-4648-891b-05df89900b85", 0, "f41519d6-c86f-4286-930b-b6f9d9cc862c", "galyaivanova@myschool.com", false, false, null, "galyaivanova@myschool.com", "galyaivanova", "AQAAAAEAACcQAAAAELtxM3ZdcSUi9eHrlF30wSw1p+Ga7tD5ijk/9k6M6qEH5ufQ7CgFIQP2CZssLlBGbg==", null, false, "e6885c53-b782-44a5-a5bc-818ed9de9ea6", false, "galyaivanova" },
                    { "b4c1c7da-6491-48d6-91d5-3c4f43105fc1", 0, "cea2eb15-4078-4397-925a-ea3db3fd6b78", "emiliageorgieva@myschool.com", false, false, null, "emiliageorgieva@myschool.com", "emiliageorgieva", "AQAAAAEAACcQAAAAEJoJiutXpvSg21yQXBTzzXC4WQ/85qlaCdapHPAXsxp6QdsYOXDfypmDDtA3IM/eMw==", null, false, "c7062b87-75af-4c35-8f35-51d26a3e4116", false, "emiliageorgieva" },
                    { "b5245ba7-c0e2-4e7d-b144-e9b7d8889e6e", 0, "c45ab322-f882-478d-9739-08e84429d9d7", "simeongeorgiev@myschool.com", false, false, null, "simeongeorgiev@myschool.com", "simeongeorgiev", "AQAAAAEAACcQAAAAEGmSAqRdEkTzzev7FYxVAMVB/1up3nk7SEwTc+PTjoWDVe/pwJnBpA37V4B6P+lTrQ==", null, false, "b7d618b3-967c-4acf-ac0e-2713a410361d", false, "simeongeorgiev" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b685f57e-87da-4d6f-8d52-1597c109a1f9", 0, "79132bc1-f41f-44ce-97ea-2f737a10a9f5", "galyadimitrova@myschool.com", false, false, null, "galyadimitrova@myschool.com", "galyadimitrova", "AQAAAAEAACcQAAAAEI1DEaBt0ysnAQ7+ji6/H1+gUeY1Gy+yO9pchfumKhn+3DctU1nt2ffdG0OD2kG4yA==", null, false, "3d1c99d7-2767-4d77-9fbc-68d9dfbc0ce0", false, "galyadimitrova" },
                    { "b6f0b26e-4baf-4a7c-bb7d-02e5f3a12a6c", 0, "3740aae3-b385-4bce-b557-ac599a096cc6", "krumivanov@myschool.com", false, false, null, "krumivanov@myschool.com", "krumivanov", "AQAAAAEAACcQAAAAEA4sUV6a77/QRW/lxLR4ciNVYsUImom5Y4nmLeA3mpxvQ7Sn3PtiEdT7tKgXzcb9zw==", null, false, "93064513-02e8-4498-aa9a-e6cf62208eed", false, "krumivanov" },
                    { "b7395fbb-59e7-4687-9b69-0f135abf8e72", 0, "aa1dee67-1b3d-4115-8f67-cdae54ec7e5c", "emiltodorov@myschool.com", false, false, null, "emiltodorov@myschool.com", "emiltodorov", "AQAAAAEAACcQAAAAEPoa/0WDgrbridxABKIKnqcOeq+ibwCkvCK1tUK/1G5F2gKWjExn/nckHaJIV00wRQ==", null, false, "859ea545-1449-495a-b488-3df96fb9f80d", false, "emiltodorov" },
                    { "b87b71e9-8db3-4f09-b865-5402a08d0b8b", 0, "dc286714-2170-4db6-8f13-edfd79fc0e9c", "lyubomirdimitrov@myschool.com", false, false, null, "lyubomirdimitrov@myschool.com", "lyubomirdimitrov", "AQAAAAEAACcQAAAAEFkNcG2T9hxCHSrnX3CFGJYfoRWZP1me44Zw0UrIe4lwyTJm4PO2ca39vKhb5JzrBw==", null, false, "274f9ff3-a24f-4942-b95e-370043f5e300", false, "lyubomirdimitrov" },
                    { "bfb57c7b-4d3d-44e5-8e4f-bf68bfdb542d", 0, "5b52a464-7f92-4f79-955d-6cd1b242686f", "t.gerganova@myschool.com", false, false, null, "t.gerganova@myschool.com", "t.gerganova@myschool.com", "AQAAAAEAACcQAAAAEHJbESSPoan5WKY2PaKc8AP/JPu5s0DrMVgzm716Q4XKV+ZrIPl5taKhy7pHOaeDrw==", null, false, "5cf2ebce-7418-4ae7-9546-b110e33e01f6", false, "t.gerganova@myschool.com" },
                    { "c173c3a5-2bf3-40cd-86bb-27b18a2d3b7a", 0, "5a4b7b5c-73cc-497e-b189-fa739c1c3c87", "radoslavtodorov@myschool.com", false, false, null, "radoslavtodorov@myschool.com", "radoslavtodorov", "AQAAAAEAACcQAAAAEM2lLmbG07IUZJ7H5vBJq/rkavIprsrA5nI8oHuiwRAF54NA5CHj866muLAztBG0YA==", null, false, "bb4c4a37-d3b9-4864-b713-e620fbf2c9b5", false, "radoslavtodorov" },
                    { "c3926be0-cc65-4a5d-92c7-4c8917d390bf", 0, "d273c55e-a94b-47f2-be99-7a3e02f781d4", "c.ambursa@myschool.com", false, false, null, "c.ambursa@myschool.com", "c.ambursa@myschool.com", "AQAAAAEAACcQAAAAED9M8vTTqzXp9vT40AOJ5sk3Vt/m9zTNthgBjeXAC70ythi1q4J3rWVh7d3u9xT8sQ==", null, false, "53f97bae-b3f6-43e7-80e2-5068794c2e0a", false, "c.ambursa@myschool.com" },
                    { "c3d2b72a-bbf1-448f-9d87-ef1dd620e91d", 0, "16a03f51-a972-4345-abfb-e24d921310f8", "nadezhdadimitrova@myschool.com", false, false, null, "nadezhdadimitrova@myschool.com", "nadezhdadimitrova", "AQAAAAEAACcQAAAAEA8tZOFLOFY3fbX4XLKbf54mkJHe6vV9TLX4NsZ4Sml+KUdAVxl5LQonbfQ7mL2jdw==", null, false, "c054a3d6-6441-4699-9861-4ecc157eace3", false, "nadezhdadimitrova" },
                    { "c5422b1e-16ed-4d05-8d45-9202c7d85d77", 0, "f6a359e8-05d6-42db-b057-fb460800c786", "hristinastefanova@myschool.com", false, false, null, "hristinastefanova@myschool.com", "hristinastefanova", "AQAAAAEAACcQAAAAEIwd9KddwFuR7igdQJqkg6iKvqy05PnUzM769gXTNEJvopCltRVpCJWjJmKmNwkERA==", null, false, "ce205d77-0a2c-4abc-9d5e-7fdad9107ef9", false, "hristinastefanova" },
                    { "c618a246-9af9-4a37-9e0d-257ec4b2b854", 0, "286a4243-c22c-4937-add0-aa6ffa842738", "gabrielastoyanova@myschool.com", false, false, null, "gabrielastoyanova@myschool.com", "gabrielastoyanova", "AQAAAAEAACcQAAAAECF5B3ABu0msxJ/j2QLUjRGgw/ow7BtErbpAa+zbeFx0NcesMktGkjvziLMSuYSHuw==", null, false, "1156a236-b87e-48a1-b688-7926afb9f2da", false, "gabrielastoyanova" },
                    { "c6aa9e1c-1894-4ef8-9a29-29c110f31949", 0, "9f5e4ae9-2022-478d-82ed-b84e4d1a2cbd", "stefchodimitrov@myschool.com", false, false, null, "stefchodimitrov@myschool.com", "stefchodimitrov", "AQAAAAEAACcQAAAAEIsH3MIQo0/zJrPpTiOoXcT64tNJCFx7gN3xIr9Rc/HHCQiFkVhVUyj96J8z3Jir9w==", null, false, "926a82db-50aa-4de1-a864-2f957b3caf10", false, "stefchodimitrov" },
                    { "cff038d2-716a-4c45-8f21-81b1e7769a74", 0, "eb062037-b9ec-4ed5-9b4d-d0f7c56ff3a9", "ralitsadimitrova@myschool.com", false, false, null, "ralitsadimitrova@myschool.com", "ralitsadimitrova", "AQAAAAEAACcQAAAAEHtpdJP/Z4lg3l4XYFMriH0Ytddr67Y4PNnbHvuJzPkDfi7mEvQ/bo4ZZpPDMCZ1EA==", null, false, "ed08214e-1114-4c37-a84c-dc4b7f98f007", false, "ralitsadimitrova" },
                    { "d071556f-89ee-4819-86b2-7eb3b63f65a2", 0, "9006e52d-38a6-46c5-a5df-671f9cf81723", "ivaylopetrov@myschool.com", false, false, null, "ivaylopetrov@myschool.com", "ivaylopetrov", "AQAAAAEAACcQAAAAEMHPNQNnG4Z0BxSu/rcfJLbFAvED659eCEpYu3u7mIYI9AkN5TjR9b/B8Z+rUC3dMA==", null, false, "5ce6e938-28c8-4dcf-9c9e-c472929b96c8", false, "ivaylopetrov" },
                    { "d0b3c3d4-5803-4f42-9f3f-5879926e2f3f", 0, "4f4189b4-1489-4260-97c1-1257cf6af129", "hristopetrov@myschool.com", false, false, null, "hristopetrov@myschool.com", "hristopetrov", "AQAAAAEAACcQAAAAEA0LMuQn+zog5t08vfQ5WuT0/8QDzMUPrlqELA34nDFZiUawgrUV/8zezdlhzvsxwg==", null, false, "134dd4e2-9e5f-422f-b620-a4910b597d1e", false, "hristopetrov" },
                    { "d1983bf8-cb42-4da2-88d2-5297be88a146", 0, "3bc434b9-52a9-46c8-96cd-4a0cf9419a51", "plamenivanov@myschool.com", false, false, null, "plamenivanov@myschool.com", "plamenivanov", "AQAAAAEAACcQAAAAEAT/LewDf5f/yJ6jSLHjF+1ys0mEQC0qHcJaEgcQpjQokPxE2noxkX7FD3rfp3Ak1A==", null, false, "4ed2f61f-1073-4a91-8aca-397b4604d8aa", false, "plamenivanov" },
                    { "d3a9008b-85c3-4a1a-8f57-36ad03b32a72", 0, "8c75c549-c0de-44e9-b949-33eadcdbee5a", "e.stoyanov@myschool.com", false, false, null, "e.stoyanov@myschool.com", "e.stoyanov@myschool.com", "AQAAAAEAACcQAAAAEPW3/aIBZ+wec1aWulTazMUiFSuxMaubS/64gdrI1CC8Nms2/iRIDqAXbVrcWO7H7w==", null, false, "2e6d3582-570b-49a7-94ee-0c5f35fbc17e", false, "e.stoyanov@myschool.com" },
                    { "d3d28ff2-79fe-4e7a-bf85-8e4fe2e0a097", 0, "6299d604-b818-447f-9955-a2f75d749be1", "elenapetrova@myschool.com", false, false, null, "elenapetrova@myschool.com", "elenapetrova", "AQAAAAEAACcQAAAAEAex+kaLjB1GA9ZDPdcERE16ZWSxyNtlAHYssqAY+xIYLGklJaxOeqG1S8HQezRkrA==", null, false, "106e3a45-dd44-4561-8281-0e68c0bf02f7", false, "elenapetrova" },
                    { "d68684c7-c3a8-4c21-8042-b76a4f43ff33", 0, "6019c9f5-b5b0-4f0f-8bfd-21279c6a3ce3", "kamenchopetrov@myschool.com", false, false, null, "kamenchopetrov@myschool.com", "kamenchopetrov", "AQAAAAEAACcQAAAAEKdI/ssO5Hv3ol6ZkG2l+2fT0Cg8+6OLSuTTibm99aE2lTc8bKhe6HLo8a9bJODg4g==", null, false, "8c594fee-797e-4579-a259-5b166ad82a3d", false, "kamenchopetrov" },
                    { "d6ab2e2d-bcc6-4e32-82eb-8c77280d482d", 0, "8e407180-1514-4fde-bf60-78ca90e5999c", "dimiturivanov@myschool.com", false, false, null, "dimiturivanov@myschool.com", "dimiturivanov", "AQAAAAEAACcQAAAAEK9RYL96GaWJIZSLLQRHC8DBVCC4QQpNaOerwvHz8zzFVOp6umNpViIhgWmtmhS43Q==", null, false, "61cc4f0f-5ef7-4fca-93d8-2dcb3689b6b1", false, "dimiturivanov" },
                    { "d6ddbe61-7627-4b88-bc3c-8c2b3a7e89a4", 0, "14a6f79b-b398-4aea-a0b2-ef775d30d3df", "rositsageorgieva@myschool.com", false, false, null, "rositsageorgieva@myschool.com", "rositsageorgieva", "AQAAAAEAACcQAAAAEFqPdoFTDxoIGTmDTvoYjSObiAnvoZ0xG4Cbk4MFDcrckjM8O3DTzL69Wi4VCSmmEw==", null, false, "9190ea09-662f-4fe5-b5d4-7f854fc7db21", false, "rositsageorgieva" },
                    { "d7cde10b-1785-4e74-92b3-c18c8f3d9e0a", 0, "c39b778b-2071-4eb8-a97c-22a4dc29df95", "stoyanpetrov@myschool.com", false, false, null, "stoyanpetrov@myschool.com", "stoyanpetrov", "AQAAAAEAACcQAAAAECITJETT0EW83lXQJ3PonDrVqDE5BmiwEuG5LP33y2ITuivz2vmiM2Detyc1XYwPHQ==", null, false, "3859d856-9a0b-4d72-ac8b-881abe99a535", false, "stoyanpetrov" },
                    { "d8b46962-25a4-4977-8363-d43e7076c85f", 0, "99d5cb7a-d065-4e16-9c7f-247cece87a83", "dilyanaivanova@myschool.com", false, false, null, "dilyanaivanova@myschool.com", "dilyanaivanova", "AQAAAAEAACcQAAAAEAcnOc25VkxEsYN2S6gGr2OM1WszmNRyC7BmTRimAySZwDhgA/hwat0aIDHv9fUncg==", null, false, "c0434f8b-3fb4-423f-ba8f-b5ac3bf8126f", false, "dilyanaivanova" },
                    { "e06a86ef-9ed7-4852-b9e3-0c0c62b741fe", 0, "485376bf-c77a-4f9e-8b2b-1b27cdbc900f", "yavorkolev@myschool.com", false, false, null, "yavorkolev@myschool.com", "yavorkolev", "AQAAAAEAACcQAAAAEFRKvFdm00PS/vYookaAx1FyGLdw4FOhBpRyNgbRpRiHOpv/zb0RHLxIDrEDYCNHAw==", null, false, "3d6b5a68-2f0c-43e3-9b30-4aebefbbf3c5", false, "yavorkolev" },
                    { "e192e1fe-5680-4ad9-a5e8-4c8328f7840c", 0, "5dcba77b-c0a3-4c95-a230-ca0219c11c76", "milenadimitrova@myschool.com", false, false, null, "milenadimitrova@myschool.com", "milenadimitrova", "AQAAAAEAACcQAAAAEItRDadcoOaDpoRl8TrhLHGIK5/4GvpEfgAaUSZoLciuRBdezfbQ7XKCL9PyiW3EBQ==", null, false, "ab0d7579-033e-4be2-85d8-d243ac68db39", false, "milenadimitrova" },
                    { "e20a8a8b-7038-45c5-b292-91c7b5e196d1", 0, "7b0bb9ce-93ab-4a54-a7ea-a9228af609aa", "rosenpetrov@myschool.com", false, false, null, "rosenpetrov@myschool.com", "rosenpetrov", "AQAAAAEAACcQAAAAEJfM5SPuWlF77w/6pLutbspYseFCABiE6GgajB1ltTkxGBzsD+nFtn7W5/YaVegGwg==", null, false, "930cada0-6d45-4376-b407-b23fb39bf191", false, "rosenpetrov" },
                    { "e2b8904e-9a9e-471d-af7b-ef17f62f0e35", 0, "163890f5-5f8a-497b-b744-ddf854a3b704", "hristiyanivanov@myschool.com", false, false, null, "hristiyanivanov@myschool.com", "hristiyanivanov", "AQAAAAEAACcQAAAAEMscKZPPh2IypZAH3Crt3N1fX9FKoesOqNcOQ0JGun3nz8GVJ05Z0/VQD1yzj9YShg==", null, false, "00a78e88-f052-4e44-b669-807ea866306a", false, "hristiyanivanov" },
                    { "e9f13942-e518-46f3-8b3e-d332b26d18fc", 0, "135cbcc1-36e6-4944-8635-e37a5ab87874", "asenmarinov@myschool.com", false, false, null, "asenmarinov@myschool.com", "asenmarinov", "AQAAAAEAACcQAAAAEDw62AegvIdsVfJEVAt8iclVp/wbjFnIB8hGKpWgVoiTxRazacvXHJCPutB5cgegYQ==", null, false, "fd9dea02-4a54-4ce5-b079-f2d096b54957", false, "asenmarinov" },
                    { "f0578b4d-49cc-4c3c-8b61-62ebc8c196e9", 0, "2f98753f-5cb0-40c2-a7c0-5969fa3162d6", "tanyageorgieva@myschool.com", false, false, null, "tanyageorgieva@myschool.com", "tanyageorgieva", "AQAAAAEAACcQAAAAELN+3dmVq4agn1AJoE95K5CZxm+9HWxfAYwm8+THUPz17sChfXKolAyHvWA9jjTbEw==", null, false, "25157172-ade2-4a4e-b5da-7fbad8c318ce", false, "tanyageorgieva" },
                    { "f05ad822-8530-4f4d-9f43-d8908ee1ad48", 0, "527b9623-8b65-44d3-9390-db256d58b2b1", "rositsapetrova@myschool.com", false, false, null, "rositsapetrova@myschool.com", "rositsapetrova", "AQAAAAEAACcQAAAAEGGPhgY6zE3w1JI58wcvKQgORl/favjvIrJmhtxESJbBwrzhq3U8bowkrKFepz+YnA==", null, false, "7a47188e-0374-4f6e-b3e5-da9d84f0a606", false, "rositsapetrova" },
                    { "f09a28d8-2ad2-465e-8ab6-7b4bd4a82ec6", 0, "de5e178d-9701-4614-9b91-0b0cd4c01db3", "k.kutin@myschool.com", false, false, null, "k.kutin@myschool.com", "k.kutin@myschool.com", "AQAAAAEAACcQAAAAEMSREtWOxmEHmN91JgvsPDB02heLA5o4jqOqEn2RNXdYIPXdwD92BUXcpogd9+NSXQ==", null, false, "ccd42a5b-e74e-47ce-9e74-6cf0c5cf1ef1", false, "k.kutin@myschool.com" },
                    { "f3dd26e0-e2eb-4e1f-9ea2-d260e779a5e3", 0, "9ea7a032-f71a-4954-ab46-55e8fbab63e0", "rumchoivanov@myschool.com", false, false, null, "rumchoivanov@myschool.com", "rumchoivanov", "AQAAAAEAACcQAAAAEGnGGMNcP/Dr3U8HHY6qp3LpQQRuPXGLw6gEoodYkmEPK5hhKmzi5QC05P2wYLedog==", null, false, "95d5c400-6ce5-444c-9421-b66ad9b9476a", false, "rumchoivanov" },
                    { "f4ec527a-d87f-4e87-b948-26e7d4c3351f", 0, "fce570b1-63c3-4d32-ad07-7b4b6c06b6f7", "antonivanov@myschool.com", false, false, null, "antonivanov@myschool.com", "antonivanov", "AQAAAAEAACcQAAAAELgB3g/Q1ZVO0UbfV9lQ9onzXz+o9tk8MgqjSlQY4wJikzX+uaLeKr9p7iSKmSckFQ==", null, false, "cc2def2e-cb08-46c6-9c64-51709385afc3", false, "antonivanov" },
                    { "f51a7a24-9aa3-4a93-9dd6-8d8e682ef64d", 0, "e7a01370-8817-4f58-90aa-589e025a0d67", "zlatinageorieva@myschool.com", false, false, null, "zlatinageorieva@myschool.com", "zlatinageorieva", "AQAAAAEAACcQAAAAELhLRqnkd/WhssN9tGXMrL4dcjtTHbgMH2Qz1W7Lc9NWyqFF0HNii23fnYoRiziByA==", null, false, "3db72852-6cc4-4dd2-af4d-304ae39e52dd", false, "zlatinageorieva" },
                    { "f75d44bf-9f2d-4d0f-a20a-b28d8eac0d7d", 0, "29e5d226-6a11-4bdd-a235-459ed836413b", "zornitsatodorova@myschool.com", false, false, null, "zornitsatodorova@myschool.com", "zornitsatodorova", "AQAAAAEAACcQAAAAEHh3fKsV9BndWj+7sUcHX/jLTRCDxtd1CLNKkckvZj34VcBqfLg/yxJ6ydndUO1MPg==", null, false, "d610ed9f-4e19-4e54-aea8-2fa2dd57722f", false, "zornitsatodorova" },
                    { "fbb84d19-1715-4d08-87bb-c87966c442b8", 0, "be86263f-f6c1-45c4-81ab-170bb90c4e0c", "y.petkova@myschool.com", false, false, null, "y.petkova@myschool.com", "y.petkova@myschool.com", "AQAAAAEAACcQAAAAEOuvRON+ehwW8ry4wudYl4xgLuwIgypzWGNEoc6a4nQQSw+Ecyq47ImqpZDJSpkRYg==", null, false, "a059b27a-a757-433f-ada2-1340ad8306e6", false, "y.petkova@myschool.com" }
                });

            migrationBuilder.InsertData(
                table: "Principals",
                columns: new[] { "Id", "Email", "FullName", "PhoneNumber", "UserId" },
                values: new object[,]
                {
                    { 1, "r.mekova@myschool.com", "Radostina Mekova", "8642097531", "5a11fb1d-76ee-4c9a-8a9e-2534297cf94e" },
                    { 2, "v.stoeva@myschool.com", "Valentina Stoeva", "8742035918", "7d4e1b42-7463-4bcf-9d0f-eeb02a87d0c5" },
                    { 3, "y.petkova@myschool.com", "Yuliana Petkova", "5268793407", "fbb84d19-1715-4d08-87bb-c87966c442b8" }
                });


            migrationBuilder.InsertData(
               table: "Teachers",
               columns: new[] { "Id", "Email", "FullName", "IsClassTeacher", "PhoneNumber", "UserId" },
               values: new object[,]
               {
                    { 1, "t.gerganova@myschool.com", "Tatyana Gerganova", true, "1357924680", "bfb57c7b-4d3d-44e5-8e4f-bf68bfdb542d" },
                    { 2, "b.lozanova@myschool.com", "Bilyana Lozanova", true, "5738291467", "4f2d3e6a-8ef0-4e6b-80c2-9b487bbba2dd" },
                    { 3, "k.kutin@myschool.com", "Krasimira Kutin", false, "6248371095", "f09a28d8-2ad2-465e-8ab6-7b4bd4a82ec6" },
                    { 4, "t.hristov@myschool.com", "Teodor Hristov", false, "8902145673", "8a7389a7-17c1-4f0a-96e9-0929cfa1c9b1" },
                    { 5, "s.gancheva@myschool.com", "Silviya Gancheva", false, "4512067839", "7a68960f-439a-42ab-9a4c-10720fd21c95" },
                    { 6, "c.ambursa@myschool.com", "Cvetomir Ambursa", true, "7263489510", "c3926be0-cc65-4a5d-92c7-4c8917d390bf" },
                    { 7, "m.mitkov@myschool.com", "Mitko Mitkov", false, "5031982467", "a15da546-3bc8-4ee7-90cd-172a2180f220" },
                    { 8, "e.stoyanov@myschool.com", "Emil Stoyanov", true, "3156924708", "d3a9008b-85c3-4a1a-8f57-36ad03b32a72" },
                    { 9, "b.bangeeva@myschool.com", "Borislava Bangeeva", false, "9785402163", "2db4cc9f-8d87-4e13-97f0-8eb8b7ea00e7" },
                    { 10, "m.ivanova@myschool.com", "Maria Ivanova", true, "2047856931", "0c2174fe-5bfc-4842-9cb3-882a35a09902" }
               });



            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "AverageScore", "Name", "TeacherId" },
                values: new object[,]
                {
                    { 1, 0m, "8\"g\"", 8 },
                    { 2, 0m, "9\"b\"", 2 },
                    { 3, 0m, "10\"v\"", 1 },
                    { 4, 0m, "11\"e\"", 6 },
                    { 5, 0m, "12\"d\"", 10 }
                });



            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "AverageScore", "ClassId", "ClassTeacherId", "FirstName", "LastName", "UserId" },
                values: new object[,]
                {
                    { 1, 0m, 1, 8, "Dimitar", "Ivanov", "21d56e3d-8c91-431e-a6e2-760848cf2aae" },
                    { 2, 0m, 1, 8, "Elena", "Petrova", "d3d28ff2-79fe-4e7a-bf85-8e4fe2e0a097" },
                    { 3, 0m, 1, 8, "Stefcho", "Dimitrov", "c6aa9e1c-1894-4ef8-9a29-29c110f31949" },
                    { 4, 0m, 1, 8, "Milena", "Georgieva", "109824cc-6b9f-4b1f-af65-87bb5a4ff79b" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "AverageScore", "ClassId", "ClassTeacherId", "FirstName", "LastName", "UserId" },
                values: new object[,]
                {
                    { 5, 0m, 1, 8, "Aleksandar", "Todorov", "8c0cb95d-0e1a-40c4-9e2f-2542d530dbaa" },
                    { 6, 0m, 1, 8, "Viktoria", "Ivanova", "7fc4b81c-0b22-4e35-bc17-c7c3e73d1874" },
                    { 7, 0m, 1, 8, "Nikolay", "Kolev", "5a7d1e4a-8f4f-4e52-9d14-06f9d3a134b4" },
                    { 8, 0m, 1, 8, "Maria", "Vasileva", "93a6ac3b-c8c9-4a24-a00b-4f54e2f4d2d7" },
                    { 9, 0m, 1, 8, "Ivaylo", "Petrov", "d071556f-89ee-4819-86b2-7eb3b63f65a2" },
                    { 10, 0m, 1, 8, "Gabriela", "Stoyanova", "c618a246-9af9-4a37-9e0d-257ec4b2b854" },
                    { 11, 0m, 1, 8, "Georgi", "Marinov", "172ef32c-2c8e-49f9-8c0f-0d8236a98fc7" },
                    { 12, 0m, 1, 8, "Kristina", "Petrova", "1f49e02f-784c-4b51-856b-0fc301da5bf0" },
                    { 13, 0m, 1, 8, "Rumcho", "Ivanov", "f3dd26e0-e2eb-4e1f-9ea2-d260e779a5e3" },
                    { 14, 0m, 1, 8, "Emilia", "Georgieva", "b4c1c7da-6491-48d6-91d5-3c4f43105fc1" },
                    { 15, 0m, 2, 2, "Krasimir", "Dimitrov", "5038ef42-267f-4a5d-8b92-2d63052265c8" },
                    { 16, 0m, 2, 2, "Silviya", "Ivanova", "9e32eab9-84e3-4b35-bb92-89b3dfb8e98f" },
                    { 17, 0m, 2, 2, "Asen", "Georgiev", "84ab245c-804d-4ac7-8f9e-bcda15863c5c" },
                    { 18, 0m, 2, 2, "Elena", "Koleva", "5a141fd9-2bcf-4dab-8c0a-8c15b7c8dbef" },
                    { 19, 0m, 2, 2, "Stanimir", "Todorov", "31b1f166-5412-40c7-b0cb-38aaec6a5ba6" },
                    { 20, 0m, 2, 2, "Magdalena", "Ivanova", "1443d844-bfd9-45a1-94a5-83c18f140c0e" },
                    { 21, 0m, 2, 2, "Hristo", "Petrov", "d0b3c3d4-5803-4f42-9f3f-5879926e2f3f" },
                    { 22, 0m, 2, 2, "Kalina", "Dimitrova", "7b1a2e32-bc36-4bf7-9b65-07fbfa810baa" },
                    { 23, 0m, 2, 2, "Tsvetancho", "Georgiev", "321efec2-563e-4f66-a158-7c2e4f7db24b" },
                    { 24, 0m, 2, 2, "Nadezhda", "Ivanova", "71c4c53d-0c7e-4d33-b8b3-15b3ff206249" },
                    { 25, 0m, 2, 2, "Boris", "Stefanov", "0e119a09-9c6b-46c2-bb9b-5151d5b8a8d7" },
                    { 26, 0m, 2, 2, "Aneliya", "Koleva", "2b765779-8f0d-4d01-b822-41fb42f9d173" },
                    { 27, 0m, 2, 2, "Rosen", "Petrov", "e20a8a8b-7038-45c5-b292-91c7b5e196d1" },
                    { 28, 0m, 2, 2, "Radostina", "Ivanova", "39b55a1b-d8b5-4bb2-9e71-cc994a1463d5" },
                    { 29, 0m, 2, 2, "Vasil", "Aleksandrov", "57ef3794-e725-4d7c-9d17-7b7ac01081c5" },
                    { 30, 0m, 2, 2, "Rositsa", "Georgieva", "d6ddbe61-7627-4b88-bc3c-8c2b3a7e89a4" },
                    { 31, 0m, 2, 2, "Plamen", "Ivanov", "d1983bf8-cb42-4da2-88d2-5297be88a146" },
                    { 32, 0m, 3, 1, "Valentina", "Dimitrova", "162d8979-1a84-4642-9b27-49973518a040" },
                    { 33, 0m, 3, 1, "Ivo", "Stoyanov", "41c16c1c-6345-487b-9202-18bf7a723b5e" },
                    { 34, 0m, 3, 1, "Stefaniya", "Petrova", "a3bd2a1d-5061-439e-aec9-0e54720e3ed5" },
                    { 35, 0m, 3, 1, "Martin", "Kolev", "2c537f9a-c6ef-43d1-98da-e63d947de2bd" },
                    { 36, 0m, 3, 1, "Sonya", "Ivanova", "512da3a0-4861-49ac-9142-1536f5ea2cb1" },
                    { 37, 0m, 3, 1, "Lyubomir", "Georgiev", "9c1e0838-6a1b-4158-92a2-36c6234e9d41" },
                    { 38, 0m, 3, 1, "Nataliya", "Vasileva", "17b6757b-33e6-4d97-b8f4-22e3ec4e34a3" },
                    { 39, 0m, 3, 1, "Petar", "Petrov", "7d2f14fb-b3b5-4598-8989-ba10d3612c96" },
                    { 40, 0m, 3, 1, "Gergana", "Dimitrova", "3f13969e-28fc-4315-b44d-b0f7b827202a" },
                    { 41, 0m, 3, 1, "Lyubomira", "Todorova", "8a4b8f2d-72e8-46d1-8a9f-2d06b1d9ecf1" },
                    { 42, 0m, 3, 1, "Anton", "Ivanov", "f4ec527a-d87f-4e87-b948-26e7d4c3351f" },
                    { 43, 0m, 3, 1, "Tanya", "Georgieva", "f0578b4d-49cc-4c3c-8b61-62ebc8c196e9" },
                    { 44, 0m, 4, 6, "Kamencho", "Petrov", "d68684c7-c3a8-4c21-8042-b76a4f43ff33" },
                    { 45, 0m, 4, 6, "Vanya", "Koleva", "8d0a37e9-91a1-4b3a-86a9-b57595b104ab" },
                    { 46, 0m, 4, 6, "Radoslav", "Georgiev", "23dbfde3-00c5-47d9-b1b4-23f97379881e" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "AverageScore", "ClassId", "ClassTeacherId", "FirstName", "LastName", "UserId" },
                values: new object[,]
                {
                    { 47, 0m, 4, 6, "Vasilenka", "Ivanova", "6a56e5a9-b77d-492e-82c5-eab5c9397756" },
                    { 48, 0m, 4, 6, "Kiril", "Dimitrov", "8d9f8a3f-16a2-4fe5-b12a-32c3f3c66fb1" },
                    { 49, 0m, 4, 6, "Kameliya", "Todorova", "8b7f9c67-7985-4f3f-a2a1-271189e22a0d" },
                    { 50, 0m, 4, 6, "Iliya", "Petrov", "961b318b-7e65-4ef9-bf8e-3e22f74cdd6d" },
                    { 51, 0m, 4, 6, "Dilyana", "Ivanova", "d8b46962-25a4-4977-8363-d43e7076c85f" },
                    { 52, 0m, 4, 6, "Bogdan", "Kolev", "15b7349f-c184-42e7-9a18-0c0dd1a05bea" },
                    { 53, 0m, 4, 6, "Daniela", "Marinova", "8f35f8dd-b52a-4084-818b-3e1813e42f19" },
                    { 54, 0m, 4, 6, "Hristiyan", "Ivanov", "e2b8904e-9a9e-471d-af7b-ef17f62f0e35" },
                    { 55, 0m, 4, 6, "Teodora", "Vasileva", "7fbd8c2e-38c6-4a97-aa74-6321ee1f0e2a" },
                    { 56, 0m, 4, 6, "Desislav", "Dimitrov", "3251a6f3-1415-4173-8d95-509d9b57a4bb" },
                    { 57, 0m, 4, 6, "Galya", "Ivanova", "b2f18679-974f-4648-891b-05df89900b85" },
                    { 58, 0m, 4, 6, "Ivan", "Kolev", "6c704485-8f35-4b5d-aa5b-c971b87cb442" },
                    { 59, 0m, 4, 6, "Mariya", "Petrova", "2e07c9b0-d2a4-41e7-b8d8-0e0384c5e81b" },
                    { 60, 0m, 5, 10, "Simeon", "Georgiev", "b5245ba7-c0e2-4e7d-b144-e9b7d8889e6e" },
                    { 61, 0m, 5, 10, "Magdalina", "Ivanova", "10b1bb25-7f3e-4ec5-bb68-9f8282850711" },
                    { 62, 0m, 5, 10, "Emil", "Todorov", "b7395fbb-59e7-4687-9b69-0f135abf8e72" },
                    { 63, 0m, 5, 10, "Kalincho", "Petrov", "6a4e15d5-29ae-4b86-9015-21d61e22e947" },
                    { 64, 0m, 5, 10, "Ralitsa", "Dimitrova", "cff038d2-716a-4c45-8f21-81b1e7769a74" },
                    { 65, 0m, 5, 10, "Yordan", "Georgiev", "80f4cb68-199a-4f6d-8b82-6ad3521c0b52" },
                    { 66, 0m, 5, 10, "Radinka", "Ivanova", "1b441729-6f7d-4d13-9f0b-3fe4e76727c3" },
                    { 67, 0m, 5, 10, "Ventsislav", "Petrov", "675b60ea-ee3f-4e58-b8d4-109b9ab54d99" },
                    { 68, 0m, 5, 10, "Darina", "Koleva", "2bd002d3-ff51-4a18-a155-dc76bba5130a" },
                    { 69, 0m, 5, 10, "Bozhidar", "Dimitrov", "98fb09c1-54d0-4d9c-86ee-7f7b510695ef" },
                    { 70, 0m, 5, 10, "Neli", "Georgieva", "731e88f2-bb26-46d8-8d53-031af77b5e15" },
                    { 71, 0m, 5, 10, "Yavor", "Ivanov", "5b38fb70-63e4-4d02-a14f-3b58ff14bc76" },
                    { 72, 0m, 5, 10, "Militsa", "Petrova", "80a73e8d-3a08-44b3-ba99-8a5ea3ebd012" },
                    { 73, 0m, 5, 10, "Zdravko", "Kolev", "844dd2c8-e20b-4423-827f-349e0bbd2761" },
                    { 74, 0m, 5, 10, "Elena", "Stoyanova", "61f620da-d214-4e17-852a-c96fddcc682a" }
                });

            migrationBuilder.InsertData(
                table: "StudentsSubjectsGrades",
                columns: new[] { "StudentId", "SubjectId", "Grade" },
                values: new object[,]
                {
                    { 1, 1, 5.00m },
                    { 1, 2, 4.00m },
                    { 1, 3, 6.00m },
                    { 1, 4, 6.00m },
                    { 1, 5, 3.00m },
                    { 1, 6, 4.00m },
                    { 1, 7, 2.00m },
                    { 1, 8, 2.00m },
                    { 1, 9, 6.00m },
                    { 1, 10, 5.00m },
                    { 2, 1, 6.00m },
                    { 2, 2, 6.00m },
                    { 2, 3, 3.00m },
                    { 2, 4, 2.00m }
                });

            migrationBuilder.InsertData(
                table: "StudentsSubjectsGrades",
                columns: new[] { "StudentId", "SubjectId", "Grade" },
                values: new object[,]
                {
                    { 2, 5, 2.00m },
                    { 2, 6, 5.00m },
                    { 2, 7, 5.00m },
                    { 2, 8, 2.00m },
                    { 2, 9, 6.00m },
                    { 2, 10, 6.00m },
                    { 3, 1, 4.00m },
                    { 3, 2, 2.00m },
                    { 3, 3, 2.00m },
                    { 3, 4, 3.00m },
                    { 3, 5, 5.00m },
                    { 3, 6, 5.00m },
                    { 3, 7, 4.00m },
                    { 3, 8, 4.00m },
                    { 3, 9, 4.00m },
                    { 3, 10, 3.00m },
                    { 4, 1, 6.00m },
                    { 4, 2, 6.00m },
                    { 4, 3, 5.00m },
                    { 4, 4, 4.00m },
                    { 4, 5, 4.00m },
                    { 4, 6, 2.00m },
                    { 4, 7, 2.00m },
                    { 4, 8, 3.00m },
                    { 4, 9, 3.00m },
                    { 4, 10, 3.00m },
                    { 5, 1, 5.00m },
                    { 5, 2, 5.00m },
                    { 5, 3, 6.00m },
                    { 5, 4, 5.00m },
                    { 5, 5, 4.00m },
                    { 5, 6, 5.00m },
                    { 5, 7, 3.00m },
                    { 5, 8, 3.00m },
                    { 5, 9, 5.00m },
                    { 5, 10, 5.00m },
                    { 6, 1, 6.00m },
                    { 6, 2, 6.00m },
                    { 6, 3, 6.00m },
                    { 6, 4, 2.00m },
                    { 6, 5, 2.00m },
                    { 6, 6, 3.00m }
                });

            migrationBuilder.InsertData(
                table: "StudentsSubjectsGrades",
                columns: new[] { "StudentId", "SubjectId", "Grade" },
                values: new object[,]
                {
                    { 6, 7, 3.00m },
                    { 6, 8, 4.00m },
                    { 6, 9, 4.00m },
                    { 6, 10, 4.00m },
                    { 7, 1, 6.00m },
                    { 7, 2, 6.00m },
                    { 7, 3, 5.00m },
                    { 7, 4, 5.00m },
                    { 7, 5, 2.00m },
                    { 7, 6, 4.00m },
                    { 7, 7, 5.00m },
                    { 7, 8, 5.00m },
                    { 7, 9, 4.00m },
                    { 7, 10, 6.00m },
                    { 8, 1, 5.00m },
                    { 8, 2, 4.00m },
                    { 8, 3, 6.00m },
                    { 8, 4, 5.00m },
                    { 8, 5, 3.00m },
                    { 8, 6, 4.00m },
                    { 8, 7, 2.00m },
                    { 8, 8, 5.00m },
                    { 8, 9, 3.00m },
                    { 8, 10, 4.00m },
                    { 9, 1, 4.00m },
                    { 9, 2, 5.00m },
                    { 9, 3, 6.00m },
                    { 9, 4, 5.00m },
                    { 9, 5, 3.00m },
                    { 9, 6, 2.00m },
                    { 9, 7, 5.00m },
                    { 9, 8, 6.00m },
                    { 9, 9, 6.00m },
                    { 9, 10, 4.00m },
                    { 10, 1, 5.00m },
                    { 10, 2, 5.00m },
                    { 10, 3, 6.00m },
                    { 10, 4, 3.00m },
                    { 10, 5, 4.00m },
                    { 10, 6, 3.00m },
                    { 10, 7, 3.00m },
                    { 10, 8, 6.00m }
                });

            migrationBuilder.InsertData(
                table: "StudentsSubjectsGrades",
                columns: new[] { "StudentId", "SubjectId", "Grade" },
                values: new object[,]
                {
                    { 10, 9, 6.00m },
                    { 10, 10, 5.00m },
                    { 11, 1, 4.00m },
                    { 11, 2, 5.00m },
                    { 11, 3, 6.00m },
                    { 11, 4, 5.00m },
                    { 11, 5, 5.00m },
                    { 11, 6, 4.00m },
                    { 11, 7, 2.00m },
                    { 11, 8, 2.00m },
                    { 11, 9, 4.00m },
                    { 11, 10, 4.00m },
                    { 12, 1, 5.00m },
                    { 12, 2, 3.00m },
                    { 12, 3, 3.00m },
                    { 12, 4, 6.00m },
                    { 12, 5, 5.00m },
                    { 12, 6, 4.00m },
                    { 12, 7, 3.00m },
                    { 12, 8, 4.00m },
                    { 12, 9, 5.00m },
                    { 12, 10, 6.00m },
                    { 13, 1, 6.00m },
                    { 13, 2, 3.00m },
                    { 13, 3, 2.00m },
                    { 13, 4, 2.00m },
                    { 13, 5, 4.00m },
                    { 13, 6, 5.00m },
                    { 13, 7, 4.00m },
                    { 13, 8, 4.00m },
                    { 13, 9, 6.00m },
                    { 13, 10, 6.00m },
                    { 14, 1, 4.00m },
                    { 14, 2, 5.00m },
                    { 14, 3, 4.00m },
                    { 14, 4, 4.00m },
                    { 14, 5, 3.00m },
                    { 14, 6, 4.00m },
                    { 14, 7, 4.00m },
                    { 14, 8, 5.00m },
                    { 14, 9, 5.00m },
                    { 14, 10, 6.00m }
                });

            migrationBuilder.InsertData(
                table: "StudentsSubjectsGrades",
                columns: new[] { "StudentId", "SubjectId", "Grade" },
                values: new object[,]
                {
                    { 15, 1, 6.00m },
                    { 15, 2, 5.00m },
                    { 15, 3, 6.00m },
                    { 15, 4, 5.00m },
                    { 15, 5, 2.00m },
                    { 15, 6, 2.00m },
                    { 15, 7, 4.00m },
                    { 15, 8, 4.00m },
                    { 15, 9, 5.00m },
                    { 15, 10, 2.00m },
                    { 16, 1, 3.00m },
                    { 16, 2, 3.00m },
                    { 16, 3, 6.00m },
                    { 16, 4, 5.00m },
                    { 16, 5, 6.00m },
                    { 16, 6, 4.00m },
                    { 16, 7, 3.00m },
                    { 16, 8, 3.00m },
                    { 16, 9, 2.00m },
                    { 16, 10, 5.00m },
                    { 17, 1, 6.00m },
                    { 17, 2, 5.00m },
                    { 17, 3, 4.00m },
                    { 17, 4, 5.00m },
                    { 17, 5, 5.00m },
                    { 17, 6, 3.00m },
                    { 17, 7, 2.00m },
                    { 17, 8, 4.00m },
                    { 17, 9, 4.00m },
                    { 17, 10, 6.00m },
                    { 18, 1, 5.00m },
                    { 18, 2, 3.00m },
                    { 18, 3, 2.00m },
                    { 18, 4, 4.00m },
                    { 18, 5, 5.00m },
                    { 18, 6, 6.00m },
                    { 18, 7, 6.00m },
                    { 18, 8, 4.00m },
                    { 18, 9, 4.00m },
                    { 18, 10, 3.00m },
                    { 19, 1, 3.00m },
                    { 19, 2, 4.00m }
                });

            migrationBuilder.InsertData(
                table: "StudentsSubjectsGrades",
                columns: new[] { "StudentId", "SubjectId", "Grade" },
                values: new object[,]
                {
                    { 19, 3, 5.00m },
                    { 19, 4, 6.00m },
                    { 19, 5, 5.00m },
                    { 19, 6, 4.00m },
                    { 19, 7, 6.00m },
                    { 19, 8, 6.00m },
                    { 19, 9, 6.00m },
                    { 19, 10, 4.00m },
                    { 20, 1, 3.00m },
                    { 20, 2, 2.00m },
                    { 20, 3, 4.00m },
                    { 20, 4, 5.00m },
                    { 20, 5, 6.00m },
                    { 20, 6, 5.00m },
                    { 20, 7, 6.00m },
                    { 20, 8, 5.00m },
                    { 20, 9, 4.00m },
                    { 20, 10, 6.00m },
                    { 21, 1, 2.00m },
                    { 21, 2, 2.00m },
                    { 21, 3, 4.00m },
                    { 21, 4, 5.00m },
                    { 21, 5, 6.00m },
                    { 21, 6, 5.00m },
                    { 21, 7, 4.00m },
                    { 21, 8, 3.00m },
                    { 21, 9, 6.00m },
                    { 21, 10, 6.00m },
                    { 22, 1, 5.00m },
                    { 22, 2, 4.00m },
                    { 22, 3, 4.00m },
                    { 22, 4, 2.00m },
                    { 22, 5, 2.00m },
                    { 22, 6, 2.00m },
                    { 22, 7, 4.00m },
                    { 22, 8, 5.00m },
                    { 22, 9, 5.00m },
                    { 22, 10, 4.00m },
                    { 23, 1, 3.00m },
                    { 23, 2, 2.00m },
                    { 23, 3, 3.00m },
                    { 23, 4, 4.00m }
                });

            migrationBuilder.InsertData(
                table: "StudentsSubjectsGrades",
                columns: new[] { "StudentId", "SubjectId", "Grade" },
                values: new object[,]
                {
                    { 23, 5, 5.00m },
                    { 23, 6, 5.00m },
                    { 23, 7, 5.00m },
                    { 23, 8, 6.00m },
                    { 23, 9, 5.00m },
                    { 23, 10, 6.00m },
                    { 24, 1, 6.00m },
                    { 24, 2, 5.00m },
                    { 24, 3, 5.00m },
                    { 24, 4, 6.00m },
                    { 24, 5, 4.00m },
                    { 24, 6, 3.00m },
                    { 24, 7, 6.00m },
                    { 24, 8, 5.00m },
                    { 24, 9, 5.00m },
                    { 24, 10, 6.00m },
                    { 25, 1, 4.00m },
                    { 25, 2, 3.00m },
                    { 25, 3, 5.00m },
                    { 25, 4, 4.00m },
                    { 25, 5, 3.00m },
                    { 25, 6, 6.00m },
                    { 25, 7, 4.00m },
                    { 25, 8, 3.00m },
                    { 25, 9, 2.00m },
                    { 25, 10, 2.00m },
                    { 26, 1, 4.00m },
                    { 26, 2, 2.00m },
                    { 26, 3, 5.00m },
                    { 26, 4, 2.00m },
                    { 26, 5, 2.00m },
                    { 26, 6, 6.00m },
                    { 26, 7, 5.00m },
                    { 26, 8, 4.00m },
                    { 26, 9, 4.00m },
                    { 26, 10, 6.00m },
                    { 27, 1, 6.00m },
                    { 27, 2, 5.00m },
                    { 27, 3, 4.00m },
                    { 27, 4, 6.00m },
                    { 27, 5, 6.00m },
                    { 27, 6, 4.00m }
                });

            migrationBuilder.InsertData(
                table: "StudentsSubjectsGrades",
                columns: new[] { "StudentId", "SubjectId", "Grade" },
                values: new object[,]
                {
                    { 27, 7, 3.00m },
                    { 27, 8, 2.00m },
                    { 27, 9, 5.00m },
                    { 27, 10, 4.00m },
                    { 28, 1, 6.00m },
                    { 28, 2, 4.00m },
                    { 28, 3, 3.00m },
                    { 28, 4, 2.00m },
                    { 28, 5, 4.00m },
                    { 28, 6, 5.00m },
                    { 28, 7, 6.00m },
                    { 28, 8, 4.00m },
                    { 28, 9, 3.00m },
                    { 28, 10, 2.00m },
                    { 29, 1, 5.00m },
                    { 29, 2, 6.00m },
                    { 29, 3, 4.00m },
                    { 29, 4, 5.00m },
                    { 29, 5, 3.00m },
                    { 29, 6, 4.00m },
                    { 29, 7, 5.00m },
                    { 29, 8, 6.00m },
                    { 29, 9, 5.00m },
                    { 29, 10, 4.00m },
                    { 30, 1, 3.00m },
                    { 30, 2, 3.00m },
                    { 30, 3, 5.00m },
                    { 30, 4, 4.00m },
                    { 30, 5, 2.00m },
                    { 30, 6, 2.00m },
                    { 30, 7, 5.00m },
                    { 30, 8, 6.00m },
                    { 30, 9, 4.00m },
                    { 30, 10, 3.00m },
                    { 31, 1, 2.00m },
                    { 31, 2, 2.00m },
                    { 31, 3, 4.00m },
                    { 31, 4, 5.00m },
                    { 31, 5, 6.00m },
                    { 31, 6, 5.00m },
                    { 31, 7, 4.00m },
                    { 31, 8, 3.00m }
                });

            migrationBuilder.InsertData(
                table: "StudentsSubjectsGrades",
                columns: new[] { "StudentId", "SubjectId", "Grade" },
                values: new object[,]
                {
                    { 31, 9, 2.00m },
                    { 31, 10, 3.00m },
                    { 32, 1, 4.00m },
                    { 32, 2, 5.00m },
                    { 32, 3, 6.00m },
                    { 32, 4, 6.00m },
                    { 32, 5, 5.00m },
                    { 32, 6, 4.00m },
                    { 32, 7, 3.00m },
                    { 32, 8, 2.00m },
                    { 32, 9, 4.00m },
                    { 32, 10, 5.00m },
                    { 33, 1, 4.00m },
                    { 33, 2, 5.00m },
                    { 33, 3, 4.00m },
                    { 33, 4, 3.00m },
                    { 33, 5, 3.00m },
                    { 33, 6, 6.00m },
                    { 33, 7, 6.00m },
                    { 33, 8, 5.00m },
                    { 33, 9, 2.00m },
                    { 33, 10, 2.00m },
                    { 34, 1, 5.00m },
                    { 34, 2, 4.00m },
                    { 34, 3, 4.00m },
                    { 34, 4, 6.00m },
                    { 34, 5, 6.00m },
                    { 34, 6, 3.00m },
                    { 34, 7, 3.00m },
                    { 34, 8, 3.00m },
                    { 34, 9, 5.00m },
                    { 34, 10, 2.00m },
                    { 35, 1, 2.00m },
                    { 35, 2, 2.00m },
                    { 35, 3, 4.00m },
                    { 35, 4, 5.00m },
                    { 35, 5, 6.00m },
                    { 35, 6, 5.00m },
                    { 35, 7, 4.00m },
                    { 35, 8, 3.00m },
                    { 35, 9, 6.00m },
                    { 35, 10, 6.00m }
                });

            migrationBuilder.InsertData(
                table: "StudentsSubjectsGrades",
                columns: new[] { "StudentId", "SubjectId", "Grade" },
                values: new object[,]
                {
                    { 36, 1, 6.00m },
                    { 36, 2, 3.00m },
                    { 36, 3, 3.00m },
                    { 36, 4, 5.00m },
                    { 36, 5, 4.00m },
                    { 36, 6, 6.00m },
                    { 36, 7, 4.00m },
                    { 36, 8, 3.00m },
                    { 36, 9, 2.00m },
                    { 36, 10, 5.00m },
                    { 37, 1, 5.00m },
                    { 37, 2, 6.00m },
                    { 37, 3, 4.00m },
                    { 37, 4, 3.00m },
                    { 37, 5, 2.00m },
                    { 37, 6, 2.00m },
                    { 37, 7, 4.00m },
                    { 37, 8, 5.00m },
                    { 37, 9, 3.00m },
                    { 37, 10, 3.00m },
                    { 38, 1, 3.00m },
                    { 38, 2, 6.00m },
                    { 38, 3, 5.00m },
                    { 38, 4, 3.00m },
                    { 38, 5, 3.00m },
                    { 38, 6, 4.00m },
                    { 38, 7, 4.00m },
                    { 38, 8, 5.00m },
                    { 38, 9, 3.00m },
                    { 38, 10, 3.00m },
                    { 39, 1, 3.00m },
                    { 39, 2, 5.00m },
                    { 39, 3, 6.00m },
                    { 39, 4, 2.00m },
                    { 39, 5, 2.00m },
                    { 39, 6, 2.00m },
                    { 39, 7, 5.00m },
                    { 39, 8, 4.00m },
                    { 39, 9, 3.00m },
                    { 39, 10, 4.00m },
                    { 40, 1, 5.00m },
                    { 40, 2, 6.00m }
                });

            migrationBuilder.InsertData(
                table: "StudentsSubjectsGrades",
                columns: new[] { "StudentId", "SubjectId", "Grade" },
                values: new object[,]
                {
                    { 40, 3, 6.00m },
                    { 40, 4, 5.00m },
                    { 40, 5, 4.00m },
                    { 40, 6, 4.00m },
                    { 40, 7, 5.00m },
                    { 40, 8, 5.00m },
                    { 40, 9, 6.00m },
                    { 40, 10, 6.00m },
                    { 41, 1, 5.00m },
                    { 41, 2, 4.00m },
                    { 41, 3, 4.00m },
                    { 41, 4, 3.00m },
                    { 41, 5, 4.00m },
                    { 41, 6, 5.00m },
                    { 41, 7, 6.00m },
                    { 41, 8, 5.00m },
                    { 41, 9, 4.00m },
                    { 41, 10, 4.00m },
                    { 42, 1, 5.00m },
                    { 42, 2, 4.00m },
                    { 42, 3, 4.00m },
                    { 42, 4, 3.00m },
                    { 42, 5, 4.00m },
                    { 42, 6, 5.00m },
                    { 42, 7, 6.00m },
                    { 42, 8, 5.00m },
                    { 42, 9, 4.00m },
                    { 42, 10, 4.00m },
                    { 43, 1, 5.00m },
                    { 43, 2, 4.00m },
                    { 43, 3, 3.00m },
                    { 43, 4, 4.00m },
                    { 43, 5, 5.00m },
                    { 43, 6, 6.00m },
                    { 43, 7, 6.00m },
                    { 43, 8, 6.00m },
                    { 43, 9, 5.00m },
                    { 43, 10, 4.00m },
                    { 44, 1, 2.00m },
                    { 44, 2, 2.00m },
                    { 44, 3, 2.00m },
                    { 44, 4, 4.00m }
                });

            migrationBuilder.InsertData(
                table: "StudentsSubjectsGrades",
                columns: new[] { "StudentId", "SubjectId", "Grade" },
                values: new object[,]
                {
                    { 44, 5, 5.00m },
                    { 44, 6, 6.00m },
                    { 44, 7, 4.00m },
                    { 44, 8, 3.00m },
                    { 44, 9, 4.00m },
                    { 44, 10, 5.00m },
                    { 45, 1, 6.00m },
                    { 45, 2, 4.00m },
                    { 45, 3, 4.00m },
                    { 45, 4, 4.00m },
                    { 45, 5, 3.00m },
                    { 45, 6, 3.00m },
                    { 45, 7, 5.00m },
                    { 45, 8, 5.00m },
                    { 45, 9, 3.00m },
                    { 45, 10, 3.00m },
                    { 46, 1, 3.00m },
                    { 46, 2, 2.00m },
                    { 46, 3, 4.00m },
                    { 46, 4, 5.00m },
                    { 46, 5, 5.00m },
                    { 46, 6, 6.00m },
                    { 46, 7, 6.00m },
                    { 46, 8, 6.00m },
                    { 46, 9, 5.00m },
                    { 46, 10, 4.00m },
                    { 47, 1, 3.00m },
                    { 47, 2, 3.00m },
                    { 47, 3, 6.00m },
                    { 47, 4, 6.00m },
                    { 47, 5, 4.00m },
                    { 47, 6, 4.00m },
                    { 47, 7, 5.00m },
                    { 47, 8, 5.00m },
                    { 47, 9, 6.00m },
                    { 47, 10, 6.00m },
                    { 48, 1, 3.00m },
                    { 48, 2, 3.00m },
                    { 48, 3, 2.00m },
                    { 48, 4, 6.00m },
                    { 48, 5, 6.00m },
                    { 48, 6, 6.00m }
                });

            migrationBuilder.InsertData(
                table: "StudentsSubjectsGrades",
                columns: new[] { "StudentId", "SubjectId", "Grade" },
                values: new object[,]
                {
                    { 48, 7, 3.00m },
                    { 48, 8, 3.00m },
                    { 48, 9, 3.00m },
                    { 48, 10, 5.00m },
                    { 49, 1, 5.00m },
                    { 49, 2, 5.00m },
                    { 49, 3, 4.00m },
                    { 49, 4, 4.00m },
                    { 49, 5, 6.00m },
                    { 49, 6, 6.00m },
                    { 49, 7, 4.00m },
                    { 49, 8, 6.00m },
                    { 49, 9, 4.00m },
                    { 49, 10, 6.00m },
                    { 50, 1, 3.00m },
                    { 50, 2, 3.00m },
                    { 50, 3, 2.00m },
                    { 50, 4, 4.00m },
                    { 50, 5, 5.00m },
                    { 50, 6, 6.00m },
                    { 50, 7, 4.00m },
                    { 50, 8, 4.00m },
                    { 50, 9, 5.00m },
                    { 50, 10, 3.00m },
                    { 51, 1, 3.00m },
                    { 51, 2, 5.00m },
                    { 51, 3, 3.00m },
                    { 51, 4, 2.00m },
                    { 51, 5, 5.00m },
                    { 51, 6, 3.00m },
                    { 51, 7, 4.00m },
                    { 51, 8, 4.00m },
                    { 51, 9, 3.00m },
                    { 51, 10, 2.00m },
                    { 52, 1, 3.00m },
                    { 52, 2, 4.00m },
                    { 52, 3, 5.00m },
                    { 52, 4, 6.00m },
                    { 52, 5, 5.00m },
                    { 52, 6, 4.00m },
                    { 52, 7, 5.00m },
                    { 52, 8, 6.00m }
                });

            migrationBuilder.InsertData(
                table: "StudentsSubjectsGrades",
                columns: new[] { "StudentId", "SubjectId", "Grade" },
                values: new object[,]
                {
                    { 52, 9, 4.00m },
                    { 52, 10, 3.00m },
                    { 53, 1, 3.00m },
                    { 53, 2, 5.00m },
                    { 53, 3, 3.00m },
                    { 53, 4, 2.00m },
                    { 53, 5, 5.00m },
                    { 53, 6, 3.00m },
                    { 53, 7, 4.00m },
                    { 53, 8, 4.00m },
                    { 53, 9, 3.00m },
                    { 53, 10, 2.00m },
                    { 54, 1, 6.00m },
                    { 54, 2, 6.00m },
                    { 54, 3, 5.00m },
                    { 54, 4, 4.00m },
                    { 54, 5, 5.00m },
                    { 54, 6, 3.00m },
                    { 54, 7, 4.00m },
                    { 54, 8, 3.00m },
                    { 54, 9, 2.00m },
                    { 54, 10, 2.00m },
                    { 55, 1, 4.00m },
                    { 55, 2, 5.00m },
                    { 55, 3, 3.00m },
                    { 55, 4, 4.00m },
                    { 55, 5, 3.00m },
                    { 55, 6, 2.00m },
                    { 55, 7, 2.00m },
                    { 55, 8, 4.00m },
                    { 55, 9, 5.00m },
                    { 55, 10, 4.00m },
                    { 56, 1, 6.00m },
                    { 56, 2, 6.00m },
                    { 56, 3, 4.00m },
                    { 56, 4, 5.00m },
                    { 56, 5, 6.00m },
                    { 56, 6, 2.00m },
                    { 56, 7, 3.00m },
                    { 56, 8, 4.00m },
                    { 56, 9, 5.00m },
                    { 56, 10, 4.00m }
                });

            migrationBuilder.InsertData(
                table: "StudentsSubjectsGrades",
                columns: new[] { "StudentId", "SubjectId", "Grade" },
                values: new object[,]
                {
                    { 57, 1, 3.00m },
                    { 57, 2, 4.00m },
                    { 57, 3, 5.00m },
                    { 57, 4, 4.00m },
                    { 57, 5, 3.00m },
                    { 57, 6, 2.00m },
                    { 57, 7, 4.00m },
                    { 57, 8, 5.00m },
                    { 57, 9, 4.00m },
                    { 57, 10, 3.00m },
                    { 58, 1, 5.00m },
                    { 58, 2, 3.00m },
                    { 58, 3, 4.00m },
                    { 58, 4, 6.00m },
                    { 58, 5, 5.00m },
                    { 58, 6, 4.00m },
                    { 58, 7, 2.00m },
                    { 58, 8, 3.00m },
                    { 58, 9, 4.00m },
                    { 58, 10, 2.00m },
                    { 59, 1, 5.00m },
                    { 59, 2, 6.00m },
                    { 59, 3, 4.00m },
                    { 59, 4, 3.00m },
                    { 59, 5, 5.00m },
                    { 59, 6, 6.00m },
                    { 59, 7, 4.00m },
                    { 59, 8, 3.00m },
                    { 59, 9, 2.00m },
                    { 59, 10, 4.00m },
                    { 60, 1, 3.00m },
                    { 60, 2, 5.00m },
                    { 60, 3, 6.00m },
                    { 60, 4, 4.00m },
                    { 60, 5, 3.00m },
                    { 60, 6, 2.00m },
                    { 60, 7, 5.00m },
                    { 60, 8, 5.00m },
                    { 60, 9, 6.00m },
                    { 60, 10, 4.00m },
                    { 61, 1, 3.00m },
                    { 61, 2, 6.00m }
                });

            migrationBuilder.InsertData(
                table: "StudentsSubjectsGrades",
                columns: new[] { "StudentId", "SubjectId", "Grade" },
                values: new object[,]
                {
                    { 61, 3, 6.00m },
                    { 61, 4, 5.00m },
                    { 61, 5, 4.00m },
                    { 61, 6, 3.00m },
                    { 61, 7, 5.00m },
                    { 61, 8, 5.00m },
                    { 61, 9, 6.00m },
                    { 61, 10, 6.00m },
                    { 62, 1, 6.00m },
                    { 62, 2, 4.00m },
                    { 62, 3, 6.00m },
                    { 62, 4, 6.00m },
                    { 62, 5, 5.00m },
                    { 62, 6, 4.00m },
                    { 62, 7, 6.00m },
                    { 62, 8, 6.00m },
                    { 62, 9, 6.00m },
                    { 62, 10, 4.00m },
                    { 63, 1, 3.00m },
                    { 63, 2, 4.00m },
                    { 63, 3, 5.00m },
                    { 63, 4, 6.00m },
                    { 63, 5, 3.00m },
                    { 63, 6, 2.00m },
                    { 63, 7, 2.00m },
                    { 63, 8, 4.00m },
                    { 63, 9, 5.00m },
                    { 63, 10, 6.00m },
                    { 64, 1, 4.00m },
                    { 64, 2, 3.00m },
                    { 64, 3, 5.00m },
                    { 64, 4, 6.00m },
                    { 64, 5, 2.00m },
                    { 64, 6, 2.00m },
                    { 64, 7, 2.00m },
                    { 64, 8, 4.00m },
                    { 64, 9, 2.00m },
                    { 64, 10, 3.00m },
                    { 65, 1, 3.00m },
                    { 65, 2, 5.00m },
                    { 65, 3, 3.00m },
                    { 65, 4, 6.00m }
                });

            migrationBuilder.InsertData(
                table: "StudentsSubjectsGrades",
                columns: new[] { "StudentId", "SubjectId", "Grade" },
                values: new object[,]
                {
                    { 65, 5, 4.00m },
                    { 65, 6, 3.00m },
                    { 65, 7, 2.00m },
                    { 65, 8, 5.00m },
                    { 65, 9, 3.00m },
                    { 65, 10, 2.00m },
                    { 66, 1, 4.00m },
                    { 66, 2, 5.00m },
                    { 66, 3, 6.00m },
                    { 66, 4, 3.00m },
                    { 66, 5, 6.00m },
                    { 66, 6, 4.00m },
                    { 66, 7, 3.00m },
                    { 66, 8, 5.00m },
                    { 66, 9, 3.00m },
                    { 66, 10, 2.00m },
                    { 67, 1, 4.00m },
                    { 67, 2, 5.00m },
                    { 67, 3, 6.00m },
                    { 67, 4, 3.00m },
                    { 67, 5, 4.00m },
                    { 67, 6, 5.00m },
                    { 67, 7, 6.00m },
                    { 67, 8, 3.00m },
                    { 67, 9, 4.00m },
                    { 67, 10, 5.00m },
                    { 68, 1, 2.00m },
                    { 68, 2, 3.00m },
                    { 68, 3, 5.00m },
                    { 68, 4, 4.00m },
                    { 68, 5, 6.00m },
                    { 68, 6, 3.00m },
                    { 68, 7, 3.00m },
                    { 68, 8, 6.00m },
                    { 68, 9, 6.00m },
                    { 68, 10, 4.00m },
                    { 69, 1, 5.00m },
                    { 69, 2, 5.00m },
                    { 69, 3, 6.00m },
                    { 69, 4, 4.00m },
                    { 69, 5, 6.00m },
                    { 69, 6, 6.00m }
                });

            migrationBuilder.InsertData(
                table: "StudentsSubjectsGrades",
                columns: new[] { "StudentId", "SubjectId", "Grade" },
                values: new object[,]
                {
                    { 69, 7, 5.00m },
                    { 69, 8, 3.00m },
                    { 69, 9, 6.00m },
                    { 69, 10, 4.00m },
                    { 70, 1, 5.00m },
                    { 70, 2, 2.00m },
                    { 70, 3, 2.00m },
                    { 70, 4, 5.00m },
                    { 70, 5, 3.00m },
                    { 70, 6, 4.00m },
                    { 70, 7, 2.00m },
                    { 70, 8, 2.00m },
                    { 70, 9, 4.00m },
                    { 70, 10, 5.00m },
                    { 71, 1, 3.00m },
                    { 71, 2, 2.00m },
                    { 71, 3, 4.00m },
                    { 71, 4, 5.00m },
                    { 71, 5, 6.00m },
                    { 71, 6, 4.00m },
                    { 71, 7, 6.00m },
                    { 71, 8, 6.00m },
                    { 71, 9, 5.00m },
                    { 71, 10, 6.00m },
                    { 72, 1, 2.00m },
                    { 72, 2, 5.00m },
                    { 72, 3, 6.00m },
                    { 72, 4, 3.00m },
                    { 72, 5, 4.00m },
                    { 72, 6, 6.00m },
                    { 72, 7, 4.00m },
                    { 72, 8, 3.00m },
                    { 72, 9, 5.00m },
                    { 72, 10, 6.00m },
                    { 73, 1, 4.00m },
                    { 73, 2, 6.00m },
                    { 73, 3, 4.00m },
                    { 73, 4, 5.00m },
                    { 73, 5, 3.00m },
                    { 73, 6, 4.00m },
                    { 73, 7, 6.00m },
                    { 73, 8, 4.00m }
                });

            migrationBuilder.InsertData(
                table: "StudentsSubjectsGrades",
                columns: new[] { "StudentId", "SubjectId", "Grade" },
                values: new object[,]
                {
                    { 73, 9, 5.00m },
                    { 73, 10, 5.00m },
                    { 74, 1, 3.00m },
                    { 74, 2, 6.00m },
                    { 74, 3, 4.00m },
                    { 74, 4, 3.00m },
                    { 74, 5, 5.00m },
                    { 74, 6, 6.00m },
                    { 74, 7, 6.00m },
                    { 74, 8, 4.00m },
                    { 74, 9, 3.00m },
                    { 74, 10, 5.00m }
                });

            


            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "ChildId", "FullName", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "Krum Ivanov", "b6f0b26e-4baf-4a7c-bb7d-02e5f3a12a6c" },
                    { 2, 2, "Veronika Petrova", "87c52768-9d12-46c1-ae72-0dcf9f415f39" },
                    { 3, 3, "Plamen Dimitrov", "2d8f5db8-876c-4c0a-9c3a-91a4e724cbdd" },
                    { 4, 4, "Zlatina Georgieva", "f51a7a24-9aa3-4a93-9dd6-8d8e682ef64d" },
                    { 5, 5, "Radoslav Todorov", "c173c3a5-2bf3-40cd-86bb-27b18a2d3b7a" },
                    { 6, 6, "Adriana Ivanova", "6d42e1d8-4e45-48b4-ba42-1a7f9c2a4a5c" },
                    { 7, 7, "Bozhidar Kolev", "a8f87e34-d5ae-4c46-aa1d-2f3cc6e11d2a" },
                    { 8, 8, "Evelina Vasileva", "3f12d8fb-1251-48f5-b566-8f4ef5b2c5d5" },
                    { 9, 9, "Stoyan Petrov", "d7cde10b-1785-4e74-92b3-c18c8f3d9e0a" },
                    { 10, 10, "Tsvetelina Stoyanova", "2f978b4c-4d9c-4ee1-aa1b-bdca0d1f89d6" },
                    { 11, 11, "Lyuben Marinov", "8270e9b1-2c24-43e1-9f93-22d9923de12c" },
                    { 12, 12, "Rositsa Petrova", "f05ad822-8530-4f4d-9f43-d8908ee1ad48" },
                    { 13, 13, "Kaloyan Ivanov", "8e9d7e5c-3429-426e-8bf7-256f874a189a" },
                    { 14, 14, "Ekaterina Georgieva", "85bb508a-2d95-42d9-aa43-0e4fe33497a0" },
                    { 15, 15, "Hristo Dimitrov", "b122f303-2d44-4f3d-bdd8-dac3626da548" },
                    { 16, 16, "Dobrinka Ivanova", "4ce7832b-e2f3-446f-8c63-720db3f89237" },
                    { 17, 17, "Blagoy Georgiev", "6b86569b-8f22-4a5c-9511-109f06d214a8" },
                    { 18, 18, "Iskra Koleva", "923f8d7d-c02d-4177-a5f8-6b6975a7119b" },
                    { 19, 19, "Krasimir Todorov", "a0e8ee4a-4dbb-4a5e-b97f-e35c542b778e" },
                    { 20, 20, "Gergana Ivanova", "0fe8a18a-0f52-4e41-8d44-292001678e5b" },
                    { 21, 21, "Vasil Petrov", "95226fbf-1ebd-49c2-aaaf-71788a690ac5" },
                    { 22, 22, "Nadezhda Dimitrova", "c3d2b72a-bbf1-448f-9d87-ef1dd620e91d" },
                    { 23, 23, "Todor Georgiev", "3670d992-3c68-43a1-9862-1e14d65f8888" },
                    { 24, 24, "Radka Ivanova", "04870e99-9ba7-4640-8ef2-01fc2a1190d7" },
                    { 25, 25, "Hristina Stefanova", "c5422b1e-16ed-4d05-8d45-9202c7d85d77" },
                    { 26, 26, "Yavor Kolev", "e06a86ef-9ed7-4852-b9e3-0c0c62b741fe" },
                    { 27, 27, "Kamelia Petrova", "0dbed053-0ea2-43c1-b4b1-99a1d1197084" },
                    { 28, 28, "Emil Ivanov", "6e3ac05f-09b1-4e65-9ab5-81a0c787e9e3" },
                    { 29, 29, "Dilyana Aleksandrova", "a7201fc2-3e05-4ad0-a0f3-1f925f05e0b1" },
                    { 30, 30, "Tsvetan Georgiev", "57e4c1a5-4c76-4cda-98ce-2e2a0a22c764" },
                    { 31, 31, "Zhivka Ivanova", "87e879c3-5c01-41d1-9e08-0a667172a0c7" },
                    { 32, 32, "Ivo Dimitrov", "a7f2842b-bfd9-4e04-994a-c5f16bfefc10" },
                    { 33, 33, "Adriyana Stoyanova", "9e8741d5-65d9-4cc0-b7b6-ff1b688c34f1" },
                    { 34, 34, "Kamen Petrov", "0f76fe6a-91ed-496d-aa60-ba07cda9c7e1" },
                    { 35, 35, "Kristina Koleva", "2e3c6d85-136f-4878-819b-9f982e6e4ed8" },
                    { 36, 36, "Yanko Ivanov", "65c645b2-cdf7-45d1-89d1-cd881a36ed98" },
                    { 37, 37, "Polina Georgieva", "65aa7d12-2f5a-4381-8c69-9b01523cf5e1" }
                });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "ChildId", "FullName", "UserId" },
                values: new object[,]
                {
                    { 38, 38, "Veselin Vasilev", "3f0c19e4-df31-42e7-9421-882128123af3" },
                    { 39, 39, "Antoniya Petrova", "2ef3d2b3-3d7f-4d52-8a04-5433e1f869ec" },
                    { 40, 40, "Lyubomir Dimitrov", "b87b71e9-8db3-4f09-b865-5402a08d0b8b" },
                    { 41, 41, "Zornitsa Todorova", "f75d44bf-9f2d-4d0f-a20a-b28d8eac0d7d" },
                    { 42, 42, "Stefan Ivanov", "1e1b85b7-6c15-4f2c-b1c4-47ad0c8bf5f9" },
                    { 43, 43, "Yoana Georgieva", "5a52e138-0a2c-4b1a-8a68-b95de62aa345" },
                    { 44, 44, "Krasimira Petrova", "b2c8a67c-5a1d-4e23-9c85-0c57454de9ee" },
                    { 45, 45, "Ivaylo Kolev", "9e3dbbc2-33d7-4c57-a3ee-5b7e19b1c3c2" },
                    { 46, 46, "Margarita Georgieva", "9b9474b0-06ab-4953-8f23-cff7e88c7a0b" },
                    { 47, 47, "Rumen Ivanov", "7edf5ac1-2d87-4bf0-b2ed-4d2e4a7b9657" },
                    { 48, 48, "Milena Dimitrova", "e192e1fe-5680-4ad9-a5e8-4c8328f7840c" },
                    { 49, 49, "Yordan Todorov", "5d5313c0-7da7-4ac6-aa0d-3e6a51fe09b6" },
                    { 50, 50, "Silviya Petrova", "31d9f6c5-c9a8-48c8-8b5f-c990d06200ad" },
                    { 51, 51, "Bogdan Ivanov", "5e61439f-95d5-4e2b-9b0d-91e7c4472e3e" },
                    { 52, 52, "Petya Koleva", "32d43d0a-632a-48fe-bc8f-68bb3f72f083" },
                    { 53, 53, "Asen Marinov", "e9f13942-e518-46f3-8b3e-d332b26d18fc" },
                    { 54, 54, "Ralitsa Ivanova", "5e4bb853-02b0-4e76-b28b-2181be91d1fc" },
                    { 55, 55, "Velko Vasilev", "2b7e8569-4edf-46d1-8b07-d2a09977e361" },
                    { 56, 56, "Galya Dimitrova", "b685f57e-87da-4d6f-8d52-1597c109a1f9" },
                    { 57, 57, "Dimitur Ivanov", "d6ab2e2d-bcc6-4e32-82eb-8c77280d482d" },
                    { 58, 58, "Nadia Koleva", "30936933-775b-4687-8e1a-5a758bc5ed38" },
                    { 59, 59, "Yulian Petrov", "8c9965a3-36a4-4a6b-ba5a-7f3a262aa0c3" },
                    { 60, 60, "Radostina Georgieva", "5dbfbd88-cb21-4784-b7e8-6b0e618ad92b" },
                    { 61, 61, "Krasim Ivanov", "a4d2bcdc-23da-4395-9b9b-2087cc52bafe" },
                    { 62, 62, "Teodora Todorova", "23fb4de4-1bf9-4e72-9764-4c2d1f870990" },
                    { 63, 63, "Kalin Petrov", "6a9e1770-798c-43de-aad7-8d8a6ad5eeab" },
                    { 64, 64, "Svetla Dimitrova", "41ac68c1-84c8-4a2a-9f69-8571bb50e80a" },
                    { 65, 65, "Ventsislav Georgiev", "3b3202f3-3f0c-4e15-9eb1-2c49b78aeb3b" },
                    { 66, 66, "Vasilena Ivanova", "35af9309-d2fb-46a4-84b4-d3dfdaa6b7d3" },
                    { 67, 67, "Martin Petrov", "4ec6a858-e99e-44a8-822d-5292c378fbb4" },
                    { 68, 68, "Ralitsa Koleva", "1a36c289-32ed-42d0-8b6b-1f5490ecf0ab" },
                    { 69, 69, "Stefan Dimitrov", "1b56c7bf-0f4e-4c3d-94db-7e81f4c32ebf" },
                    { 70, 70, "Snezhana Georgieva", "a22b38b9-85b0-4fe0-9d5c-7e3d9aa55a45" },
                    { 71, 71, "Ivaylo Ivanov", "11b2f953-01c9-446a-818f-778ce6a1f1a3" },
                    { 72, 72, "Mariana Petrova", "5a119169-b39a-4e4b-8f7f-3ab86a6cebc4" },
                    { 73, 73, "Rosen Kolev", "2b7c8f64-17f7-42f5-bb92-84b8f4d35f4f" },
                    { 74, 74, "Tanya Stoyanova", "6b04a713-c12c-4a0f-aa0b-0eafde1543ac" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[,]
                {
                    { 1, "Bulgarian", 1 },
                    { 2, "Mathematics", 2 },
                    { 3, "English", 3 },
                    { 4, "SoftwareDesign", 4 },
                    { 5, "ComputerScience", 5 }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[,]
                {
                    { 6, "Business", 6 },
                    { 7, "Physics", 7 },
                    { 8, "Programming", 8 },
                    { 9, "Engineering", 9 },
                    { 10, "History", 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_TeacherId",
                table: "Classes",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Parents_ChildId",
                table: "Parents",
                column: "ChildId");

            migrationBuilder.CreateIndex(
                name: "IX_Parents_UserId",
                table: "Parents",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Principals_UserId",
                table: "Principals",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId",
                table: "Students",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassTeacherId",
                table: "Students",
                column: "ClassTeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserId",
                table: "Students",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubject_SubjectsId",
                table: "StudentSubject",
                column: "SubjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_TeacherId",
                table: "Subjects",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Parents");

            migrationBuilder.DropTable(
                name: "Principals");

            migrationBuilder.DropTable(
                name: "StudentsSubjectsGrades");

            migrationBuilder.DropTable(
                name: "StudentSubject");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}

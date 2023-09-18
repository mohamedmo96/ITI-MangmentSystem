using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_LAP.Migrations
{
    /// <inheritdoc />
    public partial class V1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Dept_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dept_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dept_Manger = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Dept_Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Crs_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Crs_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Crs_Degree = table.Column<int>(type: "int", nullable: false),
                    Crs_MinDegree = table.Column<int>(type: "int", nullable: false),
                    Dept_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Crs_Id);
                    table.ForeignKey(
                        name: "FK_Courses_Departments_Dept_Id",
                        column: x => x.Dept_Id,
                        principalTable: "Departments",
                        principalColumn: "Dept_Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Trainees",
                columns: table => new
                {
                    Trn_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Trn_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trn_Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trn_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trn_Grade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dept_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainees", x => x.Trn_Id);
                    table.ForeignKey(
                        name: "FK_Trainees_Departments_Dept_Id",
                        column: x => x.Dept_Id,
                        principalTable: "Departments",
                        principalColumn: "Dept_Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Ins_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ins_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ins_Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    Ins_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dept_Id = table.Column<int>(type: "int", nullable: false),
                    Crs_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Ins_Id);
                    table.ForeignKey(
                        name: "FK_Instructors_Courses_Crs_Id",
                        column: x => x.Crs_Id,
                        principalTable: "Courses",
                        principalColumn: "Crs_Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Instructors_Departments_Dept_Id",
                        column: x => x.Dept_Id,
                        principalTable: "Departments",
                        principalColumn: "Dept_Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CourseTrainees",
                columns: table => new
                {
                    TC_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TC_Degree = table.Column<int>(type: "int", nullable: false),
                    Crs_Id = table.Column<int>(type: "int", nullable: false),
                    Trn_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTrainees", x => x.TC_Id);
                    table.ForeignKey(
                        name: "FK_CourseTrainees_Courses_Crs_Id",
                        column: x => x.Crs_Id,
                        principalTable: "Courses",
                        principalColumn: "Crs_Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CourseTrainees_Trainees_Trn_Id",
                        column: x => x.Trn_Id,
                        principalTable: "Trainees",
                        principalColumn: "Trn_Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Dept_Id",
                table: "Courses",
                column: "Dept_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CourseTrainees_Crs_Id",
                table: "CourseTrainees",
                column: "Crs_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CourseTrainees_Trn_Id",
                table: "CourseTrainees",
                column: "Trn_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Crs_Id",
                table: "Instructors",
                column: "Crs_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Dept_Id",
                table: "Instructors",
                column: "Dept_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Trainees_Dept_Id",
                table: "Trainees",
                column: "Dept_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseTrainees");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Trainees");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}

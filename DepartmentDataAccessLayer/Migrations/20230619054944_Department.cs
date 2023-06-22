﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DepartmentDataAccessLayer.Migrations
{
    public partial class Department : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DeptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    depatmentCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    departmentLocaton = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    departmentEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DeptId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}

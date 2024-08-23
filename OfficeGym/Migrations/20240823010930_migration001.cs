using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OfficeGym.Migrations
{
    /// <inheritdoc />
    public partial class migration001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OfficePhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Car = table.Column<bool>(type: "bit", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "OfficeEquipmentsGym",
                columns: table => new
                {
                    OfficeEquipmentGymId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipmentGymName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvailableEquipments = table.Column<int>(type: "int", nullable: false),
                    MotorHorsePower = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeEquipmentsGym", x => x.OfficeEquipmentGymId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeesSales",
                columns: table => new
                {
                    EmployeeSalesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    StoresQuantity = table.Column<int>(type: "int", nullable: false),
                    ProductsQuantity = table.Column<int>(type: "int", nullable: false),
                    SalesTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesSales", x => x.EmployeeSalesId);
                    table.ForeignKey(
                        name: "FK_EmployeesSales_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vacations",
                columns: table => new
                {
                    VacationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    VacationDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    AboutVacation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FunVacationCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacations", x => x.VacationId);
                    table.ForeignKey(
                        name: "FK_Vacations_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeesOfficeEquipmentsGym",
                columns: table => new
                {
                    EmployeeOfficeEquipmentGymId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OfficeEquipmentGymId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EquipmentGymTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesOfficeEquipmentsGym", x => x.EmployeeOfficeEquipmentGymId);
                    table.ForeignKey(
                        name: "FK_EmployeesOfficeEquipmentsGym_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeesOfficeEquipmentsGym_OfficeEquipmentsGym_OfficeEquipmentGymId",
                        column: x => x.OfficeEquipmentGymId,
                        principalTable: "OfficeEquipmentsGym",
                        principalColumn: "OfficeEquipmentGymId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesOfficeEquipmentsGym_EmployeeId",
                table: "EmployeesOfficeEquipmentsGym",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesOfficeEquipmentsGym_OfficeEquipmentGymId",
                table: "EmployeesOfficeEquipmentsGym",
                column: "OfficeEquipmentGymId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesSales_EmployeeId",
                table: "EmployeesSales",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacations_EmployeeId",
                table: "Vacations",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeesOfficeEquipmentsGym");

            migrationBuilder.DropTable(
                name: "EmployeesSales");

            migrationBuilder.DropTable(
                name: "Vacations");

            migrationBuilder.DropTable(
                name: "OfficeEquipmentsGym");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}

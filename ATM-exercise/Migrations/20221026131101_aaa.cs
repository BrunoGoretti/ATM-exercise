using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATM_exercise.Migrations
{
    public partial class aaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ATM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsCardInserted = table.Column<bool>(type: "bit", nullable: false),
                    IsOperatorMode = table.Column<bool>(type: "bit", nullable: false),
                    ATMmachineBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WithdrawalFeeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WithdrawalDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ATM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PinCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ATM");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}

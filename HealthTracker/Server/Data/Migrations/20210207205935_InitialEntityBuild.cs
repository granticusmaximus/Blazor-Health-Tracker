using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthTracker.Server.Data.Migrations
{
    public partial class InitialEntityBuild : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodIntake",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(nullable: true),
                    Calories = table.Column<int>(nullable: false),
                    Carbs = table.Column<int>(nullable: false),
                    Fats = table.Column<int>(nullable: false),
                    Fiber = table.Column<int>(nullable: true),
                    Protein = table.Column<int>(nullable: false),
                    TotalNeeded = table.Column<int>(nullable: false),
                    TotalTaken = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodIntake", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Goals",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartingWeight = table.Column<int>(nullable: false),
                    GoalWeight = table.Column<int>(nullable: false),
                    AmountLost = table.Column<int>(nullable: false),
                    AmountGained = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goals", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Routine",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Routines = table.Column<int>(nullable: false),
                    CaloriesBurned = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routine", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodIntake");

            migrationBuilder.DropTable(
                name: "Goals");

            migrationBuilder.DropTable(
                name: "Routine");
        }
    }
}

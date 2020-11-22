using Microsoft.EntityFrameworkCore.Migrations;

namespace Deniz.StaffTaskManager.DataAccess.Migrations
{
    public partial class UpdateUrgencyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Level",
                table: "Urgencies",
                newName: "UrgancyLevel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UrgancyLevel",
                table: "Urgencies",
                newName: "Level");
        }
    }
}

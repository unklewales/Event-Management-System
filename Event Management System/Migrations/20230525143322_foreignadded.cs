using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Event_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class foreignadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Events_EventModelID",
                table: "Registrations");

            migrationBuilder.RenameColumn(
                name: "EventModelID",
                table: "Registrations",
                newName: "EventModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Registrations_EventModelID",
                table: "Registrations",
                newName: "IX_Registrations_EventModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Events_EventModelId",
                table: "Registrations",
                column: "EventModelId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Events_EventModelId",
                table: "Registrations");

            migrationBuilder.RenameColumn(
                name: "EventModelId",
                table: "Registrations",
                newName: "EventModelID");

            migrationBuilder.RenameIndex(
                name: "IX_Registrations_EventModelId",
                table: "Registrations",
                newName: "IX_Registrations_EventModelID");

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Events_EventModelID",
                table: "Registrations",
                column: "EventModelID",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

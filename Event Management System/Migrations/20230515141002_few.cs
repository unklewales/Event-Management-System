using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Event_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class few : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventModelRegistration_EventModels_EventsId",
                table: "EventModelRegistration");

            migrationBuilder.RenameColumn(
                name: "EventsId",
                table: "EventModelRegistration",
                newName: "EventModelsId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventModelRegistration_EventModels_EventModelsId",
                table: "EventModelRegistration",
                column: "EventModelsId",
                principalTable: "EventModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventModelRegistration_EventModels_EventModelsId",
                table: "EventModelRegistration");

            migrationBuilder.RenameColumn(
                name: "EventModelsId",
                table: "EventModelRegistration",
                newName: "EventsId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventModelRegistration_EventModels_EventsId",
                table: "EventModelRegistration",
                column: "EventsId",
                principalTable: "EventModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

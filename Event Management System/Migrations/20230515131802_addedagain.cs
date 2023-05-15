using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Event_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class addedagain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Registrations_RegistrationId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_RegistrationId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "RegistrationId",
                table: "Events");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RegistrationId",
                table: "Events",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_RegistrationId",
                table: "Events",
                column: "RegistrationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Registrations_RegistrationId",
                table: "Events",
                column: "RegistrationId",
                principalTable: "Registrations",
                principalColumn: "Id");
        }
    }
}

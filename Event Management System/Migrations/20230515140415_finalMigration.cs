using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Event_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class finalMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Events_EventModelId",
                table: "Registrations");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_EventModelId",
                table: "Registrations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Events",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "EventModelId",
                table: "Registrations");

            migrationBuilder.RenameTable(
                name: "Events",
                newName: "EventModels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventModels",
                table: "EventModels",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "EventModelRegistration",
                columns: table => new
                {
                    EventsId = table.Column<int>(type: "INTEGER", nullable: false),
                    RegistrationsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventModelRegistration", x => new { x.EventsId, x.RegistrationsId });
                    table.ForeignKey(
                        name: "FK_EventModelRegistration_EventModels_EventsId",
                        column: x => x.EventsId,
                        principalTable: "EventModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventModelRegistration_Registrations_RegistrationsId",
                        column: x => x.RegistrationsId,
                        principalTable: "Registrations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventModelRegistration_RegistrationsId",
                table: "EventModelRegistration",
                column: "RegistrationsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventModelRegistration");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventModels",
                table: "EventModels");

            migrationBuilder.RenameTable(
                name: "EventModels",
                newName: "Events");

            migrationBuilder.AddColumn<int>(
                name: "EventModelId",
                table: "Registrations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Events",
                table: "Events",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_EventModelId",
                table: "Registrations",
                column: "EventModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Events_EventModelId",
                table: "Registrations",
                column: "EventModelId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

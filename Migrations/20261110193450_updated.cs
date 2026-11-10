using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace G_NET69_EF_Assignment_2.Migrations
{
    /// <inheritdoc />
    public partial class updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrganizerID1",
                table: "organizersProfile",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_organizersProfile_OrganizerID1",
                table: "organizersProfile",
                column: "OrganizerID1",
                unique: true,
                filter: "[OrganizerID1] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_organizersProfile_EventOrganizers_OrganizerID1",
                table: "organizersProfile",
                column: "OrganizerID1",
                principalTable: "EventOrganizers",
                principalColumn: "OrganizerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_organizersProfile_EventOrganizers_OrganizerID1",
                table: "organizersProfile");

            migrationBuilder.DropIndex(
                name: "IX_organizersProfile_OrganizerID1",
                table: "organizersProfile");

            migrationBuilder.DropColumn(
                name: "OrganizerID1",
                table: "organizersProfile");
        }
    }
}

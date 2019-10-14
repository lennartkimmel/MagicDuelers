using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MDLproject.Data.Migrations
{
    public partial class formats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Formats_Standard_StandardID",
                table: "Formats");

            migrationBuilder.DropTable(
                name: "Standard");

            migrationBuilder.DropIndex(
                name: "IX_Formats_StandardID",
                table: "Formats");

            migrationBuilder.DropColumn(
                name: "Advanced",
                table: "Formats");

            migrationBuilder.DropColumn(
                name: "Commander",
                table: "Formats");

            migrationBuilder.DropColumn(
                name: "Constructed",
                table: "Formats");

            migrationBuilder.DropColumn(
                name: "Legacy",
                table: "Formats");

            migrationBuilder.DropColumn(
                name: "Limited",
                table: "Formats");

            migrationBuilder.DropColumn(
                name: "Modern",
                table: "Formats");

            migrationBuilder.DropColumn(
                name: "SealedDeck",
                table: "Formats");

            migrationBuilder.DropColumn(
                name: "StandardID",
                table: "Formats");

            migrationBuilder.DropColumn(
                name: "Traditional",
                table: "Formats");

            migrationBuilder.RenameColumn(
                name: "Vintage",
                table: "Formats",
                newName: "Label");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Label",
                table: "Formats",
                newName: "Vintage");

            migrationBuilder.AddColumn<string>(
                name: "Advanced",
                table: "Formats",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Commander",
                table: "Formats",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Constructed",
                table: "Formats",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Legacy",
                table: "Formats",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Limited",
                table: "Formats",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Modern",
                table: "Formats",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SealedDeck",
                table: "Formats",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StandardID",
                table: "Formats",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Traditional",
                table: "Formats",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Standard",
                columns: table => new
                {
                    StandardID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Standard", x => x.StandardID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Formats_StandardID",
                table: "Formats",
                column: "StandardID");

            migrationBuilder.AddForeignKey(
                name: "FK_Formats_Standard_StandardID",
                table: "Formats",
                column: "StandardID",
                principalTable: "Standard",
                principalColumn: "StandardID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

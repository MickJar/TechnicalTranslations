using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechnicalTranslations.Migrations
{
    public partial class Version2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Word",
                table: "Word");

            migrationBuilder.DropColumn(
                name: "Original",
                table: "Word");

            migrationBuilder.RenameColumn(
                name: "Translation",
                table: "Word",
                newName: "Swedish");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Word",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "English",
                table: "Word",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Word",
                table: "Word",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Word",
                table: "Word");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Word");

            migrationBuilder.DropColumn(
                name: "English",
                table: "Word");

            migrationBuilder.RenameColumn(
                name: "Swedish",
                table: "Word",
                newName: "Translation");

            migrationBuilder.AddColumn<string>(
                name: "Original",
                table: "Word",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Word",
                table: "Word",
                column: "Original");
        }
    }
}

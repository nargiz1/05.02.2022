using Microsoft.EntityFrameworkCore.Migrations;

namespace homework.Migrations
{
    public partial class addcounteritem2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_counterItems",
                table: "counterItems");

            migrationBuilder.RenameTable(
                name: "counterItems",
                newName: "CounterItem");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CounterItem",
                table: "CounterItem",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CounterItem",
                table: "CounterItem");

            migrationBuilder.RenameTable(
                name: "CounterItem",
                newName: "counterItems");

            migrationBuilder.AddPrimaryKey(
                name: "PK_counterItems",
                table: "counterItems",
                column: "Id");
        }
    }
}

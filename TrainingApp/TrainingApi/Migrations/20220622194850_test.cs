using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingApi.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingPlans_BodyPartType_BodyPartTypeId",
                table: "TrainingPlans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BodyPartType",
                table: "BodyPartType");

            migrationBuilder.RenameTable(
                name: "BodyPartType",
                newName: "BodyPartTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BodyPartTypes",
                table: "BodyPartTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingPlans_BodyPartTypes_BodyPartTypeId",
                table: "TrainingPlans",
                column: "BodyPartTypeId",
                principalTable: "BodyPartTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingPlans_BodyPartTypes_BodyPartTypeId",
                table: "TrainingPlans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BodyPartTypes",
                table: "BodyPartTypes");

            migrationBuilder.RenameTable(
                name: "BodyPartTypes",
                newName: "BodyPartType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BodyPartType",
                table: "BodyPartType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingPlans_BodyPartType_BodyPartTypeId",
                table: "TrainingPlans",
                column: "BodyPartTypeId",
                principalTable: "BodyPartType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

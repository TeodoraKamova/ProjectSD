using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class BLChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Doctors_DocId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Sicknesses_SicknessId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_DocId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DocId",
                table: "Patients");

            migrationBuilder.AlterColumn<int>(
                name: "SicknessId",
                table: "Patients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Patients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DoctorId",
                table: "Patients",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Doctors_DoctorId",
                table: "Patients",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Sicknesses_SicknessId",
                table: "Patients",
                column: "SicknessId",
                principalTable: "Sicknesses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Doctors_DoctorId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Sicknesses_SicknessId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_DoctorId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Patients");

            migrationBuilder.AlterColumn<int>(
                name: "SicknessId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DocId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DocId",
                table: "Patients",
                column: "DocId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Doctors_DocId",
                table: "Patients",
                column: "DocId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Sicknesses_SicknessId",
                table: "Patients",
                column: "SicknessId",
                principalTable: "Sicknesses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

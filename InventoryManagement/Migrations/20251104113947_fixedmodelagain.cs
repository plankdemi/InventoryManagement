using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagement.Migrations
{
    /// <inheritdoc />
    public partial class fixedmodelagain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "FullInventories",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "FullInventories",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CustomSingleStringName3",
                table: "FullInventories",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CustomSingleStringName2",
                table: "FullInventories",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CustomSingleStringName1",
                table: "FullInventories",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CustomMultiStringName3",
                table: "FullInventories",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CustomMultiStringName2",
                table: "FullInventories",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CustomMultiStringName1",
                table: "FullInventories",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CustomLinkName3",
                table: "FullInventories",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CustomLinkName2",
                table: "FullInventories",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CustomLinkName1",
                table: "FullInventories",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CustomIntName3",
                table: "FullInventories",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CustomIntName2",
                table: "FullInventories",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CustomIntName1",
                table: "FullInventories",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CustomBoolName3",
                table: "FullInventories",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CustomBoolName2",
                table: "FullInventories",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CustomBoolName1",
                table: "FullInventories",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "InventoryId",
                table: "FullInventories",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "CustomBoolValue1",
                table: "FullInventories",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CustomBoolValue2",
                table: "FullInventories",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CustomBoolValue3",
                table: "FullInventories",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "CustomIntValue1",
                table: "FullInventories",
                type: "int",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomIntValue2",
                table: "FullInventories",
                type: "int",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomIntValue3",
                table: "FullInventories",
                type: "int",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CustomLinkValue1",
                table: "FullInventories",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CustomLinkValue2",
                table: "FullInventories",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CustomLinkValue3",
                table: "FullInventories",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "CustomMultiStringValue1",
                table: "FullInventories",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CustomMultiStringValue2",
                table: "FullInventories",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CustomMultiStringValue3",
                table: "FullInventories",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CustomSingleStringValue1",
                table: "FullInventories",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CustomSingleStringValue2",
                table: "FullInventories",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CustomSingleStringValue3",
                table: "FullInventories",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomBoolValue1",
                table: "FullInventories");

            migrationBuilder.DropColumn(
                name: "CustomBoolValue2",
                table: "FullInventories");

            migrationBuilder.DropColumn(
                name: "CustomBoolValue3",
                table: "FullInventories");

            migrationBuilder.DropColumn(
                name: "CustomIntValue1",
                table: "FullInventories");

            migrationBuilder.DropColumn(
                name: "CustomIntValue2",
                table: "FullInventories");

            migrationBuilder.DropColumn(
                name: "CustomIntValue3",
                table: "FullInventories");

            migrationBuilder.DropColumn(
                name: "CustomLinkValue1",
                table: "FullInventories");

            migrationBuilder.DropColumn(
                name: "CustomLinkValue2",
                table: "FullInventories");

            migrationBuilder.DropColumn(
                name: "CustomLinkValue3",
                table: "FullInventories");

            migrationBuilder.DropColumn(
                name: "CustomMultiStringValue1",
                table: "FullInventories");

            migrationBuilder.DropColumn(
                name: "CustomMultiStringValue2",
                table: "FullInventories");

            migrationBuilder.DropColumn(
                name: "CustomMultiStringValue3",
                table: "FullInventories");

            migrationBuilder.DropColumn(
                name: "CustomSingleStringValue1",
                table: "FullInventories");

            migrationBuilder.DropColumn(
                name: "CustomSingleStringValue2",
                table: "FullInventories");

            migrationBuilder.DropColumn(
                name: "CustomSingleStringValue3",
                table: "FullInventories");

            migrationBuilder.UpdateData(
                table: "FullInventories",
                keyColumn: "ImageUrl",
                keyValue: null,
                column: "ImageUrl",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "FullInventories",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "FullInventories",
                keyColumn: "Description",
                keyValue: null,
                column: "Description",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "FullInventories",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "FullInventories",
                keyColumn: "CustomSingleStringName3",
                keyValue: null,
                column: "CustomSingleStringName3",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CustomSingleStringName3",
                table: "FullInventories",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "FullInventories",
                keyColumn: "CustomSingleStringName2",
                keyValue: null,
                column: "CustomSingleStringName2",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CustomSingleStringName2",
                table: "FullInventories",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "FullInventories",
                keyColumn: "CustomSingleStringName1",
                keyValue: null,
                column: "CustomSingleStringName1",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CustomSingleStringName1",
                table: "FullInventories",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "FullInventories",
                keyColumn: "CustomMultiStringName3",
                keyValue: null,
                column: "CustomMultiStringName3",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CustomMultiStringName3",
                table: "FullInventories",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "FullInventories",
                keyColumn: "CustomMultiStringName2",
                keyValue: null,
                column: "CustomMultiStringName2",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CustomMultiStringName2",
                table: "FullInventories",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "FullInventories",
                keyColumn: "CustomMultiStringName1",
                keyValue: null,
                column: "CustomMultiStringName1",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CustomMultiStringName1",
                table: "FullInventories",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "FullInventories",
                keyColumn: "CustomLinkName3",
                keyValue: null,
                column: "CustomLinkName3",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CustomLinkName3",
                table: "FullInventories",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "FullInventories",
                keyColumn: "CustomLinkName2",
                keyValue: null,
                column: "CustomLinkName2",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CustomLinkName2",
                table: "FullInventories",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "FullInventories",
                keyColumn: "CustomLinkName1",
                keyValue: null,
                column: "CustomLinkName1",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CustomLinkName1",
                table: "FullInventories",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "FullInventories",
                keyColumn: "CustomIntName3",
                keyValue: null,
                column: "CustomIntName3",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CustomIntName3",
                table: "FullInventories",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "FullInventories",
                keyColumn: "CustomIntName2",
                keyValue: null,
                column: "CustomIntName2",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CustomIntName2",
                table: "FullInventories",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "FullInventories",
                keyColumn: "CustomIntName1",
                keyValue: null,
                column: "CustomIntName1",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CustomIntName1",
                table: "FullInventories",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<bool>(
                name: "CustomBoolName3",
                table: "FullInventories",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<bool>(
                name: "CustomBoolName2",
                table: "FullInventories",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<bool>(
                name: "CustomBoolName1",
                table: "FullInventories",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "InventoryId",
                table: "FullInventories",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(256)",
                oldMaxLength: 256)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}

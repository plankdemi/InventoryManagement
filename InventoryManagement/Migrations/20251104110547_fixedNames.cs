using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagement.Migrations
{
    /// <inheritdoc />
    public partial class fixedNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "title",
                table: "FullInventories",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "isPublic",
                table: "FullInventories",
                newName: "IsPublic");

            migrationBuilder.RenameColumn(
                name: "imageUrl",
                table: "FullInventories",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "FullInventories",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "customSingleStringState3",
                table: "FullInventories",
                newName: "CustomSingleStringState3");

            migrationBuilder.RenameColumn(
                name: "customSingleStringState2",
                table: "FullInventories",
                newName: "CustomSingleStringState2");

            migrationBuilder.RenameColumn(
                name: "customSingleStringState1",
                table: "FullInventories",
                newName: "CustomSingleStringState1");

            migrationBuilder.RenameColumn(
                name: "customSingleStringName3",
                table: "FullInventories",
                newName: "CustomSingleStringName3");

            migrationBuilder.RenameColumn(
                name: "customSingleStringName2",
                table: "FullInventories",
                newName: "CustomSingleStringName2");

            migrationBuilder.RenameColumn(
                name: "customSingleStringName1",
                table: "FullInventories",
                newName: "CustomSingleStringName1");

            migrationBuilder.RenameColumn(
                name: "customMultiStringState3",
                table: "FullInventories",
                newName: "CustomMultiStringState3");

            migrationBuilder.RenameColumn(
                name: "customMultiStringState2",
                table: "FullInventories",
                newName: "CustomMultiStringState2");

            migrationBuilder.RenameColumn(
                name: "customMultiStringName3",
                table: "FullInventories",
                newName: "CustomMultiStringName3");

            migrationBuilder.RenameColumn(
                name: "customMultiStringName2",
                table: "FullInventories",
                newName: "CustomMultiStringName2");

            migrationBuilder.RenameColumn(
                name: "customMultiStringName1",
                table: "FullInventories",
                newName: "CustomMultiStringName1");

            migrationBuilder.RenameColumn(
                name: "customMultStringState1",
                table: "FullInventories",
                newName: "CustomMultStringState1");

            migrationBuilder.RenameColumn(
                name: "customLinkState3",
                table: "FullInventories",
                newName: "CustomLinkState3");

            migrationBuilder.RenameColumn(
                name: "customLinkState2",
                table: "FullInventories",
                newName: "CustomLinkState2");

            migrationBuilder.RenameColumn(
                name: "customLinkState1",
                table: "FullInventories",
                newName: "CustomLinkState1");

            migrationBuilder.RenameColumn(
                name: "customLinkName3",
                table: "FullInventories",
                newName: "CustomLinkName3");

            migrationBuilder.RenameColumn(
                name: "customLinkName2",
                table: "FullInventories",
                newName: "CustomLinkName2");

            migrationBuilder.RenameColumn(
                name: "customLinkName1",
                table: "FullInventories",
                newName: "CustomLinkName1");

            migrationBuilder.RenameColumn(
                name: "customIntState3",
                table: "FullInventories",
                newName: "CustomIntState3");

            migrationBuilder.RenameColumn(
                name: "customIntState2",
                table: "FullInventories",
                newName: "CustomIntState2");

            migrationBuilder.RenameColumn(
                name: "customIntState1",
                table: "FullInventories",
                newName: "CustomIntState1");

            migrationBuilder.RenameColumn(
                name: "customIntName3",
                table: "FullInventories",
                newName: "CustomIntName3");

            migrationBuilder.RenameColumn(
                name: "customIntName2",
                table: "FullInventories",
                newName: "CustomIntName2");

            migrationBuilder.RenameColumn(
                name: "customIntName1",
                table: "FullInventories",
                newName: "CustomIntName1");

            migrationBuilder.RenameColumn(
                name: "customBoolState3",
                table: "FullInventories",
                newName: "CustomBoolState3");

            migrationBuilder.RenameColumn(
                name: "customBoolState2",
                table: "FullInventories",
                newName: "CustomBoolState2");

            migrationBuilder.RenameColumn(
                name: "customBoolState1",
                table: "FullInventories",
                newName: "CustomBoolState1");

            migrationBuilder.RenameColumn(
                name: "customBoolName3",
                table: "FullInventories",
                newName: "CustomBoolName3");

            migrationBuilder.RenameColumn(
                name: "customBoolName2",
                table: "FullInventories",
                newName: "CustomBoolName2");

            migrationBuilder.RenameColumn(
                name: "customBoolName1",
                table: "FullInventories",
                newName: "CustomBoolName1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "FullInventories",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "IsPublic",
                table: "FullInventories",
                newName: "isPublic");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "FullInventories",
                newName: "imageUrl");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "FullInventories",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "CustomSingleStringState3",
                table: "FullInventories",
                newName: "customSingleStringState3");

            migrationBuilder.RenameColumn(
                name: "CustomSingleStringState2",
                table: "FullInventories",
                newName: "customSingleStringState2");

            migrationBuilder.RenameColumn(
                name: "CustomSingleStringState1",
                table: "FullInventories",
                newName: "customSingleStringState1");

            migrationBuilder.RenameColumn(
                name: "CustomSingleStringName3",
                table: "FullInventories",
                newName: "customSingleStringName3");

            migrationBuilder.RenameColumn(
                name: "CustomSingleStringName2",
                table: "FullInventories",
                newName: "customSingleStringName2");

            migrationBuilder.RenameColumn(
                name: "CustomSingleStringName1",
                table: "FullInventories",
                newName: "customSingleStringName1");

            migrationBuilder.RenameColumn(
                name: "CustomMultiStringState3",
                table: "FullInventories",
                newName: "customMultiStringState3");

            migrationBuilder.RenameColumn(
                name: "CustomMultiStringState2",
                table: "FullInventories",
                newName: "customMultiStringState2");

            migrationBuilder.RenameColumn(
                name: "CustomMultiStringName3",
                table: "FullInventories",
                newName: "customMultiStringName3");

            migrationBuilder.RenameColumn(
                name: "CustomMultiStringName2",
                table: "FullInventories",
                newName: "customMultiStringName2");

            migrationBuilder.RenameColumn(
                name: "CustomMultiStringName1",
                table: "FullInventories",
                newName: "customMultiStringName1");

            migrationBuilder.RenameColumn(
                name: "CustomMultStringState1",
                table: "FullInventories",
                newName: "customMultStringState1");

            migrationBuilder.RenameColumn(
                name: "CustomLinkState3",
                table: "FullInventories",
                newName: "customLinkState3");

            migrationBuilder.RenameColumn(
                name: "CustomLinkState2",
                table: "FullInventories",
                newName: "customLinkState2");

            migrationBuilder.RenameColumn(
                name: "CustomLinkState1",
                table: "FullInventories",
                newName: "customLinkState1");

            migrationBuilder.RenameColumn(
                name: "CustomLinkName3",
                table: "FullInventories",
                newName: "customLinkName3");

            migrationBuilder.RenameColumn(
                name: "CustomLinkName2",
                table: "FullInventories",
                newName: "customLinkName2");

            migrationBuilder.RenameColumn(
                name: "CustomLinkName1",
                table: "FullInventories",
                newName: "customLinkName1");

            migrationBuilder.RenameColumn(
                name: "CustomIntState3",
                table: "FullInventories",
                newName: "customIntState3");

            migrationBuilder.RenameColumn(
                name: "CustomIntState2",
                table: "FullInventories",
                newName: "customIntState2");

            migrationBuilder.RenameColumn(
                name: "CustomIntState1",
                table: "FullInventories",
                newName: "customIntState1");

            migrationBuilder.RenameColumn(
                name: "CustomIntName3",
                table: "FullInventories",
                newName: "customIntName3");

            migrationBuilder.RenameColumn(
                name: "CustomIntName2",
                table: "FullInventories",
                newName: "customIntName2");

            migrationBuilder.RenameColumn(
                name: "CustomIntName1",
                table: "FullInventories",
                newName: "customIntName1");

            migrationBuilder.RenameColumn(
                name: "CustomBoolState3",
                table: "FullInventories",
                newName: "customBoolState3");

            migrationBuilder.RenameColumn(
                name: "CustomBoolState2",
                table: "FullInventories",
                newName: "customBoolState2");

            migrationBuilder.RenameColumn(
                name: "CustomBoolState1",
                table: "FullInventories",
                newName: "customBoolState1");

            migrationBuilder.RenameColumn(
                name: "CustomBoolName3",
                table: "FullInventories",
                newName: "customBoolName3");

            migrationBuilder.RenameColumn(
                name: "CustomBoolName2",
                table: "FullInventories",
                newName: "customBoolName2");

            migrationBuilder.RenameColumn(
                name: "CustomBoolName1",
                table: "FullInventories",
                newName: "customBoolName1");
        }
    }
}

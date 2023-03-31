using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkApi.Migrations
{
    public partial class MoreSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1,
                column: "Description",
                value: "A national park in Wyoming known for its geysers, hot springs, and wildlife.");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2,
                column: "Description",
                value: "A national park in California known for its waterfalls, giant sequoia groves, and wildlife.");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3,
                column: "Description",
                value: "A national park in Arizona known for its steep canyon walls, desert landscape, and wildlife.");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4,
                column: "Description",
                value: "A national park in Utah known for its red sandstone cliffs, canyons, and hiking trails.");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5,
                column: "Description",
                value: "A national park in Montana known for its rugged mountains, alpine lakes, and abundant wildlife.");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6,
                column: "Description",
                value: "A national park in Washington known for its rainforests, mountains, and beaches.");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7,
                column: "Description",
                value: "A national park in Colorado known for its rugged mountains, alpine lakes, and abundant wildlife.");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 8,
                column: "Description",
                value: "A national park in Wyoming known for its rugged mountains, alpine lakes, and abundant wildlife.");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 9,
                column: "Description",
                value: "A national park in Maine known for its rugged mountains, alpine lakes, and abundant wildlife.");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10,
                column: "Description",
                value: "A national park in Utah known for its rugged mountains, alpine lakes, and abundant wildlife.");

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "Name", "State" },
                values: new object[,]
                {
                    { 11, "A caldera lake in Oregon known for its deep blue color and water clarity.", "Crater Lake", "Oregon" },
                    { 12, "A volcano in Washington known for its snow-capped peak and hiking trails.", "Mount Rainier", "Washington" },
                    { 13, "A national park in California known for its old-growth coast redwood forests.", "Redwood", "California" },
                    { 14, "A national park in South Dakota known for its rugged mountains, alpine lakes, and abundant wildlife.", "Badlands", "South Dakota" },
                    { 15, "A national park in Texas known for its rugged mountains, alpine lakes, and abundant wildlife.", "Big Bend", "Texas" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1,
                column: "Description",
                value: "PlaceHolder Text");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2,
                column: "Description",
                value: "PlaceHolder Text");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3,
                column: "Description",
                value: "PlaceHolder Text");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4,
                column: "Description",
                value: "PlaceHolder Text");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5,
                column: "Description",
                value: "PlaceHolder Text");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6,
                column: "Description",
                value: "PlaceHolder Text");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7,
                column: "Description",
                value: "PlaceHolder Text");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 8,
                column: "Description",
                value: "PlaceHolder Text");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 9,
                column: "Description",
                value: "PlaceHolder Text");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10,
                column: "Description",
                value: "PlaceHolder Text");
        }
    }
}

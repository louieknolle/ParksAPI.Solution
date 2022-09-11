using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksAPI.Migrations
{
    public partial class SearchEndpointAndParkType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Parks");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Parks");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Parks",
                type: "varchar(40) CHARACTER SET utf8mb4",
                maxLength: 40,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParkName",
                table: "Parks",
                type: "varchar(50) CHARACTER SET utf8mb4",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TypeOfPark",
                table: "Parks",
                type: "varchar(20) CHARACTER SET utf8mb4",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Acadia National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "American Samoa National Park	", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Arches National Park	", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Badlands National Park ", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Big Bend National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Biscayne National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Black Canyon of the Gunnison National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 8,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Bryce Canyon National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 9,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Canyonlands National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Capitol Reef National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 11,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Carlsbad Caverns National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 12,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Channel Islands National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 13,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Congaree National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 14,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Crater Lake National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 15,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Cuyahoga Valley National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 16,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Death Valley National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 17,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Denali National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 18,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Dry Tortugas National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 19,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Everglades National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 20,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Gates of the Arctic National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 21,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Gateway Arch National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 22,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Glacier National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 23,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Glacier Bay National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 24,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Grand Canyon National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 25,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Grand Teton National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 26,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Great Basin National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 27,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Great Sand Dunes National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 28,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Great Smoky Mountains National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 29,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Guadalupe Mountains National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 30,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Haleakala National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 31,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Hawaii Volcanoes National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 32,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Hot Springs National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 33,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Indiana Dunes National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 34,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Isle Royale National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 35,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Joshua Tree National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 36,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Katmai National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 37,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Kenai Fjords National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 38,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Kings Canyon National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 39,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Kobuk Valley National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 40,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Lake Clark National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 41,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Lassen Volcanic Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 42,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Mammoth Cave Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 43,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Mesa Verde National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 44,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Mount Rainier National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 45,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "North Cascades National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 46,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Olympic National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 47,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Petrified Forest National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 48,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Pinnacles National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 49,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Redwood National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 50,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Rocky Mountain National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 51,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Saguaro National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 52,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Sequoia National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 53,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Shenandoah National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 54,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Theodore Roosevelt National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 55,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Virgin Islands National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 56,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Voyageurs National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 57,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Wind Cave National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 58,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Wrangell-St. Elias National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 59,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Yellowstone National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 60,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Yosemite National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 61,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Zion National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 62,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Goose Lake State Recreation Area", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 63,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Frenchglen Hotel State Heritage Site", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 64,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Ontario State Recreation Site", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 65,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Farewell Bend State Recreation Area", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 66,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Kam Wah Chung State Heritage Site", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 67,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Unity Forest State Scenic Corridor", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 68,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Unity Lake State Recreation Site", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 69,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Clyde Holliday State Recreation Site", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 70,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Succor Creek State Natural Area", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 71,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Lake Owyhee State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 72,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Catherine Creek State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 73,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Hat Rock State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 74,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Hilgard Junction State Recreation Area", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 75,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Red Bridge State Wayside", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 76,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Ukiah & Dale Forest State Scenic Corridor", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 77,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Emigrant Springs State Heritage Area", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 78,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Wallowa Lake Highway Forest State Scenic Corridor", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 79,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Wallowa River Rest Area", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 80,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Minam State Recreation Area", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 81,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Wallowa Lake State Recreation Area", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 82,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Iwetemlaykin State Heritage Site", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 83,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Casey State Recreation Site,Recreation Site", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 84,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Prospect State Scenic Viewpoint", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 85,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Joseph H. Stewart State Recreation Area", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 86,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "The Cove Palisades State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 87,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Jasper Point Campground", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 88,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Prineville Reservoir State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 89,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Heritage Landing (Deschutes)", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 90,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "White River Falls State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 91,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Deschutes River State Recreation Area", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 92,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Cline Falls State Scenic Viewpoint", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 93,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Fort Rock State Natural Area", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 94,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "La Pine State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 95,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Pilot Butte State Scenic Viewpoint", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 96,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Tumalo State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 97,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Smith Rock State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 98,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Booth State Scenic Corridor", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 99,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Humbug Mountain State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 100,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Port Orford Heads State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 101,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Cape Blanco State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 102,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Bullards Beach State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 103,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Alfred A. Loeb State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 104,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Elijah Bristow State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 105,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Cape Arago State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 106,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Shore Acres State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 107,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "William M. Tugman State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 108,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Sunset Bay State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 109,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Illinois River Forks State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 110,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Molalla River State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 111,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Beaver Creek State Natural Area", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 112,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Umpqua Lighthouse State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 113,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Carl G. Washburne Memorial State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 114,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Jessie M. Honeyman Memorial State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 115,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Willamette Mission State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 116,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Milo McIver State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 117,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Ainsworth State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 118,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Guy W. Talbot State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 119,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Mayer State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 120,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Memaloose State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 121,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Starvation Creek State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 122,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Viento State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 123,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Rooster Rock State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 124,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Fort Stevens State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 125,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Bob Straub State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 126,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Ecola State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 127,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Oswald West State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 128,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Nehalem Bay State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 129,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Ona Beach State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 130,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "South Beach State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 131,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Cascadia State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 132,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Silver Falls State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 133,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Beverly Beach State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 134,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Collier Memorial State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 135,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "L. L. 'Stub' Stewart State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 136,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "State Capitol State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 137,
                columns: new[] { "ParkName", "TypeOfPark" },
                values: new object[] { "Cottonwood Canyon State Park", "State" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParkName",
                table: "Parks");

            migrationBuilder.DropColumn(
                name: "TypeOfPark",
                table: "Parks");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Parks",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(40) CHARACTER SET utf8mb4",
                oldMaxLength: 40);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Parks",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Parks",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Acadia National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2,
                columns: new[] { "Name", "Type" },
                values: new object[] { "American Samoa National Park	", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Arches National Park	", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Badlands National Park ", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Big Bend National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Biscayne National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Black Canyon of the Gunnison National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 8,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Bryce Canyon National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 9,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Canyonlands National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Capitol Reef National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 11,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Carlsbad Caverns National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 12,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Channel Islands National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 13,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Congaree National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 14,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Crater Lake National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 15,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Cuyahoga Valley National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 16,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Death Valley National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 17,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Denali National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 18,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Dry Tortugas National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 19,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Everglades National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 20,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Gates of the Arctic National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 21,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Gateway Arch National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 22,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Glacier National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 23,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Glacier Bay National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 24,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Grand Canyon National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 25,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Grand Teton National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 26,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Great Basin National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 27,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Great Sand Dunes National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 28,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Great Smoky Mountains National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 29,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Guadalupe Mountains National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 30,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Haleakala National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 31,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Hawaii Volcanoes National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 32,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Hot Springs National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 33,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Indiana Dunes National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 34,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Isle Royale National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 35,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Joshua Tree National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 36,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Katmai National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 37,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Kenai Fjords National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 38,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Kings Canyon National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 39,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Kobuk Valley National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 40,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Lake Clark National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 41,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Lassen Volcanic Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 42,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Mammoth Cave Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 43,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Mesa Verde National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 44,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Mount Rainier National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 45,
                columns: new[] { "Name", "Type" },
                values: new object[] { "North Cascades National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 46,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Olympic National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 47,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Petrified Forest National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 48,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Pinnacles National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 49,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Redwood National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 50,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Rocky Mountain National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 51,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Saguaro National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 52,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Sequoia National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 53,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Shenandoah National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 54,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Theodore Roosevelt National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 55,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Virgin Islands National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 56,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Voyageurs National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 57,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Wind Cave National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 58,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Wrangell-St. Elias National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 59,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Yellowstone National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 60,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Yosemite National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 61,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Zion National Park", "National" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 62,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Goose Lake State Recreation Area", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 63,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Frenchglen Hotel State Heritage Site", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 64,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Ontario State Recreation Site", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 65,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Farewell Bend State Recreation Area", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 66,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Kam Wah Chung State Heritage Site", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 67,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Unity Forest State Scenic Corridor", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 68,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Unity Lake State Recreation Site", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 69,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Clyde Holliday State Recreation Site", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 70,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Succor Creek State Natural Area", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 71,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Lake Owyhee State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 72,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Catherine Creek State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 73,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Hat Rock State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 74,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Hilgard Junction State Recreation Area", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 75,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Red Bridge State Wayside", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 76,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Ukiah & Dale Forest State Scenic Corridor", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 77,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Emigrant Springs State Heritage Area", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 78,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Wallowa Lake Highway Forest State Scenic Corridor", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 79,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Wallowa River Rest Area", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 80,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Minam State Recreation Area", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 81,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Wallowa Lake State Recreation Area", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 82,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Iwetemlaykin State Heritage Site", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 83,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Casey State Recreation Site,Recreation Site", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 84,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Prospect State Scenic Viewpoint", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 85,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Joseph H. Stewart State Recreation Area", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 86,
                columns: new[] { "Name", "Type" },
                values: new object[] { "The Cove Palisades State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 87,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Jasper Point Campground", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 88,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Prineville Reservoir State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 89,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Heritage Landing (Deschutes)", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 90,
                columns: new[] { "Name", "Type" },
                values: new object[] { "White River Falls State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 91,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Deschutes River State Recreation Area", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 92,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Cline Falls State Scenic Viewpoint", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 93,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Fort Rock State Natural Area", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 94,
                columns: new[] { "Name", "Type" },
                values: new object[] { "La Pine State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 95,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Pilot Butte State Scenic Viewpoint", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 96,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Tumalo State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 97,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Smith Rock State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 98,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Booth State Scenic Corridor", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 99,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Humbug Mountain State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 100,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Port Orford Heads State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 101,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Cape Blanco State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 102,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Bullards Beach State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 103,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Alfred A. Loeb State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 104,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Elijah Bristow State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 105,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Cape Arago State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 106,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Shore Acres State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 107,
                columns: new[] { "Name", "Type" },
                values: new object[] { "William M. Tugman State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 108,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Sunset Bay State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 109,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Illinois River Forks State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 110,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Molalla River State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 111,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Beaver Creek State Natural Area", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 112,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Umpqua Lighthouse State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 113,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Carl G. Washburne Memorial State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 114,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Jessie M. Honeyman Memorial State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 115,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Willamette Mission State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 116,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Milo McIver State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 117,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Ainsworth State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 118,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Guy W. Talbot State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 119,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Mayer State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 120,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Memaloose State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 121,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Starvation Creek State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 122,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Viento State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 123,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Rooster Rock State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 124,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Fort Stevens State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 125,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Bob Straub State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 126,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Ecola State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 127,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Oswald West State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 128,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Nehalem Bay State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 129,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Ona Beach State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 130,
                columns: new[] { "Name", "Type" },
                values: new object[] { "South Beach State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 131,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Cascadia State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 132,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Silver Falls State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 133,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Beverly Beach State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 134,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Collier Memorial State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 135,
                columns: new[] { "Name", "Type" },
                values: new object[] { "L. L. 'Stub' Stewart State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 136,
                columns: new[] { "Name", "Type" },
                values: new object[] { "State Capitol State Park", "State" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 137,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Cottonwood Canyon State Park", "State" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StateLocation",
                table: "Parks",
                newName: "Type");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Parks",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Location", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Maine", "Acadia National Park", "National" },
                    { 100, "Oregon", "Port Orford Heads State Park", "State" },
                    { 99, "Oregon", "Humbug Mountain State Park", "State" },
                    { 98, "Oregon", "Booth State Scenic Corridor", "State" },
                    { 97, "Oregon", "Smith Rock State Park", "State" },
                    { 96, "Oregon", "Tumalo State Park", "State" },
                    { 95, "Oregon", "Pilot Butte State Scenic Viewpoint", "State" },
                    { 94, "Oregon", "La Pine State Park", "State" },
                    { 93, "Oregon", "Fort Rock State Natural Area", "State" },
                    { 92, "Oregon", "Cline Falls State Scenic Viewpoint", "State" },
                    { 91, "Oregon", "Deschutes River State Recreation Area", "State" },
                    { 90, "Oregon", "White River Falls State Park", "State" },
                    { 89, "Oregon", "Heritage Landing (Deschutes)", "State" },
                    { 88, "Oregon", "Prineville Reservoir State Park", "State" },
                    { 87, "Oregon", "Jasper Point Campground", "State" },
                    { 101, "Oregon", "Cape Blanco State Park", "State" },
                    { 86, "Oregon", "The Cove Palisades State Park", "State" },
                    { 84, "Oregon", "Prospect State Scenic Viewpoint", "State" },
                    { 83, "Oregon", "Casey State Recreation Site,Recreation Site", "State" },
                    { 82, "Oregon", "Iwetemlaykin State Heritage Site", "State" },
                    { 81, "Oregon", "Wallowa Lake State Recreation Area", "State" },
                    { 80, "Oregon", "Minam State Recreation Area", "State" },
                    { 79, "Oregon", "Wallowa River Rest Area", "State" },
                    { 78, "Oregon", "Wallowa Lake Highway Forest State Scenic Corridor", "State" },
                    { 77, "Oregon", "Emigrant Springs State Heritage Area", "State" },
                    { 76, "Oregon", "Ukiah & Dale Forest State Scenic Corridor", "State" },
                    { 75, "Oregon", "Red Bridge State Wayside", "State" },
                    { 74, "Oregon", "Hilgard Junction State Recreation Area", "State" },
                    { 73, "Oregon", "Hat Rock State Park", "State" },
                    { 72, "Oregon", "Catherine Creek State Park", "State" },
                    { 71, "Oregon", "Lake Owyhee State Park", "State" },
                    { 85, "Oregon", "Joseph H. Stewart State Recreation Area", "State" },
                    { 102, "Oregon", "Bullards Beach State Park", "State" },
                    { 103, "Oregon", "Alfred A. Loeb State Park", "State" },
                    { 104, "Oregon", "Elijah Bristow State Park", "State" },
                    { 135, "Oregon", "L. L. 'Stub' Stewart State Park", "State" },
                    { 134, "Oregon", "Collier Memorial State Park", "State" },
                    { 133, "Oregon", "Beverly Beach State Park", "State" },
                    { 132, "Oregon", "Silver Falls State Park", "State" },
                    { 131, "Oregon", "Cascadia State Park", "State" },
                    { 130, "Oregon", "South Beach State Park", "State" },
                    { 129, "Oregon", "Ona Beach State Park", "State" },
                    { 128, "Oregon", "Nehalem Bay State Park", "State" },
                    { 127, "Oregon", "Oswald West State Park", "State" },
                    { 126, "Oregon", "Ecola State Park", "State" },
                    { 125, "Oregon", "Bob Straub State Park", "State" },
                    { 124, "Oregon", "Fort Stevens State Park", "State" },
                    { 123, "Oregon", "Rooster Rock State Park", "State" },
                    { 122, "Oregon", "Viento State Park", "State" },
                    { 121, "Oregon", "Starvation Creek State Park", "State" },
                    { 120, "Oregon", "Memaloose State Park", "State" },
                    { 119, "Oregon", "Mayer State Park", "State" },
                    { 105, "Oregon", "Cape Arago State Park", "State" },
                    { 106, "Oregon", "Shore Acres State Park", "State" },
                    { 107, "Oregon", "William M. Tugman State Park", "State" },
                    { 108, "Oregon", "Sunset Bay State Park", "State" },
                    { 109, "Oregon", "Illinois River Forks State Park", "State" },
                    { 110, "Oregon", "Molalla River State Park", "State" },
                    { 70, "Oregon", "Succor Creek State Natural Area", "State" },
                    { 111, "Oregon", "Beaver Creek State Natural Area", "State" },
                    { 113, "Oregon", "Carl G. Washburne Memorial State Park", "State" },
                    { 114, "Oregon", "Jessie M. Honeyman Memorial State Park", "State" },
                    { 115, "Oregon", "Willamette Mission State Park", "State" },
                    { 116, "Oregon", "Milo McIver State Park", "State" },
                    { 117, "Oregon", "Ainsworth State Park", "State" },
                    { 118, "Oregon", "Guy W. Talbot State Park", "State" },
                    { 112, "Oregon", "Umpqua Lighthouse State Park", "State" },
                    { 136, "Oregon", "State Capitol State Park", "State" },
                    { 69, "Oregon", "Clyde Holliday State Recreation Site", "State" },
                    { 67, "Oregon", "Unity Forest State Scenic Corridor", "State" },
                    { 31, "Hawaii", "Hawaii Volcanoes National Park", "National" },
                    { 30, "Hawaii", "Haleakala National Park", "National" },
                    { 29, "Texas", "Guadalupe Mountains National Park", "National" },
                    { 28, "North Carolina and Tennessee", "Great Smoky Mountains National Park", "National" },
                    { 27, "Colorado", "Great Sand Dunes National Park", "National" },
                    { 26, "Nevada", "Great Basin National Park", "National" },
                    { 25, "Wyoming", "Grand Teton National Park", "National" },
                    { 24, "Arizona", "Grand Canyon National Park", "National" },
                    { 23, "Alaska", "Glacier Bay National Park", "National" },
                    { 22, "Montana", "Glacier National Park", "National" },
                    { 21, "Missouri", "Gateway Arch National Park", "National" },
                    { 20, "Alaska", "Gates of the Arctic National Park", "National" },
                    { 19, "Florida", "Everglades National Park", "National" },
                    { 18, "Florida", "Dry Tortugas National Park", "National" },
                    { 32, "Arkansas", "Hot Springs National Park", "National" },
                    { 17, "Alaska", "Denali National Park", "National" },
                    { 15, "Ohio", "Cuyahoga Valley National Park", "National" },
                    { 14, "Oregon", "Crater Lake National Park", "National" },
                    { 13, "South Carolina", "Congaree National Park", "National" },
                    { 12, "California", "Channel Islands National Park", "National" },
                    { 11, "New Mexico", "Carlsbad Caverns National Park", "National" },
                    { 10, "Utah", "Capitol Reef National Park", "National" },
                    { 9, "Utah", "Canyonlands National Park", "National" },
                    { 8, "Utah", "Bryce Canyon National Park", "National" },
                    { 7, "Colorado", "Black Canyon of the Gunnison National Park", "National" },
                    { 6, "Florida", "Biscayne National Park", "National" },
                    { 5, "Texas", "Big Bend National Park", "National" },
                    { 4, "South Dakota", "Badlands National Park ", "National" },
                    { 3, "Utah", "Arches National Park	", "National" },
                    { 2, "American Samoa Territory", "American Samoa National Park	", "National" },
                    { 16, "California and Nevada", "Death Valley National Park", "National" },
                    { 33, "Indiana", "Indiana Dunes National Park", "National" },
                    { 34, "Michigan", "Isle Royale National Park", "National" },
                    { 35, "California", "Joshua Tree National Park", "National" },
                    { 66, "Oregon", "Kam Wah Chung State Heritage Site", "State" },
                    { 65, "Oregon", "Farewell Bend State Recreation Area", "State" },
                    { 64, "Oregon", "Ontario State Recreation Site", "State" },
                    { 63, "Oregon", "Frenchglen Hotel State Heritage Site", "State" },
                    { 62, "Oregon", "Goose Lake State Recreation Area", "State" },
                    { 61, "Utah", "Zion National Park", "National" },
                    { 60, "California", "Yosemite National Park", "National" },
                    { 59, "Wyoming", "Yellowstone National Park", "National" },
                    { 58, "Alaska", "Wrangell-St. Elias National Park", "National" },
                    { 57, "South Dakota", "Wind Cave National Park", "National" },
                    { 56, "Minnesota", "Voyageurs National Park", "National" },
                    { 55, "U.S. Virgin Islands", "Virgin Islands National Park", "National" },
                    { 54, "North Dakota", "Theodore Roosevelt National Park", "National" },
                    { 53, "Virginia", "Shenandoah National Park", "National" },
                    { 52, "California", "Sequoia National Park", "National" },
                    { 51, "Arizona", "Saguaro National Park", "National" },
                    { 50, "Colorado", "Rocky Mountain National Park", "National" },
                    { 36, "Alaska", "Katmai National Park", "National" },
                    { 37, "Alaska", "Kenai Fjords National Park", "National" },
                    { 38, "California", "Kings Canyon National Park", "National" },
                    { 39, "Alaska", "Kobuk Valley National Park", "National" },
                    { 40, "Alaska", "Lake Clark National Park", "National" },
                    { 41, "California", "Lassen Volcanic Park", "National" },
                    { 68, "Oregon", "Unity Lake State Recreation Site", "State" },
                    { 42, "Kentucky", "Mammoth Cave Park", "National" },
                    { 44, "Washington", "Mount Rainier National Park", "National" },
                    { 45, "Washington", "North Cascades National Park", "National" },
                    { 46, "Washington", "Olympic National Park", "National" },
                    { 47, "Arizona", "Petrified Forest National Park", "National" },
                    { 48, "California", "Pinnacles National Park", "National" },
                    { 49, "California", "Redwood National Park", "National" },
                    { 43, "Colorado", "Mesa Verde National Park", "National" },
                    { 137, "Oregon", "Cottonwood Canyon State Park", "State" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10);

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

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 137);

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Parks");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Parks",
                newName: "StateLocation");
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace ParksAPI.Models
{
    public class ParksAPIContext : DbContext
    {
        public ParksAPIContext(DbContextOptions<ParksAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Park> Parks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        builder.Entity<Park>()
            .HasData(
                new Park { ParkId = 1, ParkName = "Acadia National Park", TypeOfPark = "National", Location = "Maine" },
                new Park { ParkId = 2, ParkName = "American Samoa National Park	", TypeOfPark = "National", Location = "American Samoa Territory" },
                new Park { ParkId = 3, ParkName = "Arches National Park	", TypeOfPark = "National", Location = "Utah" },
                new Park { ParkId = 4, ParkName = "Badlands National Park ", TypeOfPark = "National", Location = "South Dakota" },
                new Park { ParkId = 5, ParkName = "Big Bend National Park", TypeOfPark = "National", Location = "Texas" },
                new Park { ParkId = 6, ParkName = "Biscayne National Park", TypeOfPark = "National", Location = "Florida" },
                new Park { ParkId = 7, ParkName = "Black Canyon of the Gunnison National Park", TypeOfPark = "National", Location = "Colorado" },
                new Park { ParkId = 8, ParkName = "Bryce Canyon National Park", TypeOfPark = "National", Location = "Utah" },
                new Park { ParkId = 9, ParkName = "Canyonlands National Park", TypeOfPark = "National", Location = "Utah" },
                new Park { ParkId = 10, ParkName = "Capitol Reef National Park", TypeOfPark = "National", Location = "Utah" },
                new Park { ParkId = 11, ParkName = "Carlsbad Caverns National Park", TypeOfPark = "National", Location = "New Mexico" },
                new Park { ParkId = 12, ParkName = "Channel Islands National Park", TypeOfPark = "National", Location = "California" },
                new Park { ParkId = 13, ParkName = "Congaree National Park", TypeOfPark = "National", Location = "South Carolina" },
                new Park { ParkId = 14, ParkName = "Crater Lake National Park", TypeOfPark = "National", Location = "Oregon" },
                new Park { ParkId = 15, ParkName = "Cuyahoga Valley National Park", TypeOfPark = "National", Location = "Ohio" },
                new Park { ParkId = 16, ParkName = "Death Valley National Park", TypeOfPark = "National", Location = "California and Nevada" },
                new Park { ParkId = 17, ParkName = "Denali National Park", TypeOfPark = "National", Location = "Alaska" },
                new Park { ParkId = 18, ParkName = "Dry Tortugas National Park", TypeOfPark = "National", Location = "Florida" },
                new Park { ParkId = 19, ParkName = "Everglades National Park", TypeOfPark = "National", Location = "Florida" },
                new Park { ParkId = 20, ParkName = "Gates of the Arctic National Park", TypeOfPark = "National", Location = "Alaska" },
                new Park { ParkId = 21, ParkName = "Gateway Arch National Park", TypeOfPark = "National", Location = "Missouri" },
                new Park { ParkId = 22, ParkName = "Glacier National Park", TypeOfPark = "National", Location = "Montana" },
                new Park { ParkId = 23, ParkName = "Glacier Bay National Park", TypeOfPark = "National", Location = "Alaska" },
                new Park { ParkId = 24, ParkName = "Grand Canyon National Park", TypeOfPark = "National", Location = "Arizona" },
                new Park { ParkId = 25, ParkName = "Grand Teton National Park", TypeOfPark = "National", Location = "Wyoming" },
                new Park { ParkId = 26, ParkName = "Great Basin National Park", TypeOfPark = "National", Location = "Nevada" },
                new Park { ParkId = 27, ParkName = "Great Sand Dunes National Park", TypeOfPark = "National", Location = "Colorado" },
                new Park { ParkId = 28, ParkName = "Great Smoky Mountains National Park", TypeOfPark = "National", Location = "North Carolina and Tennessee" },
                new Park { ParkId = 29, ParkName = "Guadalupe Mountains National Park", TypeOfPark = "National", Location = "Texas" },
                new Park { ParkId = 30, ParkName = "Haleakala National Park", TypeOfPark = "National", Location = "Hawaii" },
                new Park { ParkId = 31, ParkName = "Hawaii Volcanoes National Park", TypeOfPark = "National", Location = "Hawaii" },
                new Park { ParkId = 32, ParkName = "Hot Springs National Park", TypeOfPark = "National", Location = "Arkansas" },
                new Park { ParkId = 33, ParkName = "Indiana Dunes National Park", TypeOfPark = "National", Location = "Indiana" },
                new Park { ParkId = 34, ParkName = "Isle Royale National Park", TypeOfPark = "National", Location = "Michigan" },
                new Park { ParkId = 35, ParkName = "Joshua Tree National Park", TypeOfPark = "National", Location = "California" },
                new Park { ParkId = 36, ParkName = "Katmai National Park", TypeOfPark = "National", Location = "Alaska" },
                new Park { ParkId = 37, ParkName = "Kenai Fjords National Park", TypeOfPark = "National", Location = "Alaska" },
                new Park { ParkId = 38, ParkName = "Kings Canyon National Park", TypeOfPark = "National", Location = "California" },
                new Park { ParkId = 39, ParkName = "Kobuk Valley National Park", TypeOfPark = "National", Location = "Alaska" },
                new Park { ParkId = 40, ParkName = "Lake Clark National Park", TypeOfPark = "National", Location = "Alaska" },
                new Park { ParkId = 41, ParkName = "Lassen Volcanic Park", TypeOfPark = "National", Location = "California" },
                new Park { ParkId = 42, ParkName = "Mammoth Cave Park", TypeOfPark = "National", Location = "Kentucky" },
                new Park { ParkId = 43, ParkName = "Mesa Verde National Park", TypeOfPark = "National", Location = "Colorado" },
                new Park { ParkId = 44, ParkName = "Mount Rainier National Park", TypeOfPark = "National", Location = "Washington" },
                new Park { ParkId = 45, ParkName = "North Cascades National Park", TypeOfPark = "National", Location = "Washington" },
                new Park { ParkId = 46, ParkName = "Olympic National Park", TypeOfPark = "National", Location = "Washington" },
                new Park { ParkId = 47, ParkName = "Petrified Forest National Park", TypeOfPark = "National", Location = "Arizona" },
                new Park { ParkId = 48, ParkName = "Pinnacles National Park", TypeOfPark = "National", Location = "California" },
                new Park { ParkId = 49, ParkName = "Redwood National Park", TypeOfPark = "National", Location = "California" },
                new Park { ParkId = 50, ParkName = "Rocky Mountain National Park", TypeOfPark = "National", Location = "Colorado" },
                new Park { ParkId = 51, ParkName = "Saguaro National Park", TypeOfPark = "National", Location = "Arizona" },
                new Park { ParkId = 52, ParkName = "Sequoia National Park", TypeOfPark = "National", Location = "California" },
                new Park { ParkId = 53, ParkName = "Shenandoah National Park", TypeOfPark = "National", Location = "Virginia" },
                new Park { ParkId = 54, ParkName = "Theodore Roosevelt National Park", TypeOfPark = "National", Location = "North Dakota" },
                new Park { ParkId = 55, ParkName = "Virgin Islands National Park", TypeOfPark = "National", Location = "U.S. Virgin Islands" },
                new Park { ParkId = 56, ParkName = "Voyageurs National Park", TypeOfPark = "National", Location = "Minnesota" },
                new Park { ParkId = 57, ParkName = "Wind Cave National Park", TypeOfPark = "National", Location = "South Dakota" },
                new Park { ParkId = 58, ParkName = "Wrangell-St. Elias National Park", TypeOfPark = "National", Location = "Alaska" },
                new Park { ParkId = 59, ParkName = "Yellowstone National Park", TypeOfPark = "National", Location = "Wyoming" },
                new Park { ParkId = 60, ParkName = "Yosemite National Park", TypeOfPark = "National", Location = "California" },
                new Park { ParkId = 61, ParkName = "Zion National Park", TypeOfPark = "National", Location = "Utah" },
                new Park { ParkId = 62, ParkName = "Goose Lake State Recreation Area", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 63, ParkName = "Frenchglen Hotel State Heritage Site", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 64, ParkName = "Ontario State Recreation Site", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 65, ParkName = "Farewell Bend State Recreation Area", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 66, ParkName = "Kam Wah Chung State Heritage Site", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 67, ParkName = "Unity Forest State Scenic Corridor", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 68, ParkName = "Unity Lake State Recreation Site", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 69, ParkName = "Clyde Holliday State Recreation Site", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 70, ParkName = "Succor Creek State Natural Area", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 71, ParkName = "Lake Owyhee State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 72, ParkName = "Catherine Creek State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 73, ParkName = "Hat Rock State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 74, ParkName = "Hilgard Junction State Recreation Area", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 75, ParkName = "Red Bridge State Wayside", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 76, ParkName = "Ukiah & Dale Forest State Scenic Corridor", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 77, ParkName = "Emigrant Springs State Heritage Area", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 78, ParkName = "Wallowa Lake Highway Forest State Scenic Corridor", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 79, ParkName = "Wallowa River Rest Area", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 80, ParkName = "Minam State Recreation Area", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 81, ParkName = "Wallowa Lake State Recreation Area", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 82, ParkName = "Iwetemlaykin State Heritage Site", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 83, ParkName = "Casey State Recreation Site,Recreation Site", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 84, ParkName = "Prospect State Scenic Viewpoint", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 85, ParkName = "Joseph H. Stewart State Recreation Area", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 86, ParkName = "The Cove Palisades State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 87, ParkName = "Jasper Point Campground", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 88, ParkName = "Prineville Reservoir State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 89, ParkName = "Heritage Landing (Deschutes)", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 90, ParkName = "White River Falls State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 91, ParkName = "Deschutes River State Recreation Area", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 92, ParkName = "Cline Falls State Scenic Viewpoint", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 93, ParkName = "Fort Rock State Natural Area", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 94, ParkName = "La Pine State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 95, ParkName = "Pilot Butte State Scenic Viewpoint", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 96, ParkName = "Tumalo State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 97, ParkName = "Smith Rock State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 98, ParkName = "Booth State Scenic Corridor", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 99, ParkName = "Humbug Mountain State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 100, ParkName = "Port Orford Heads State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 101, ParkName = "Cape Blanco State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 102, ParkName = "Bullards Beach State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 103, ParkName = "Alfred A. Loeb State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 104, ParkName = "Elijah Bristow State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 105, ParkName = "Cape Arago State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 106, ParkName = "Shore Acres State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 107, ParkName = "William M. Tugman State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 108, ParkName = "Sunset Bay State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 109, ParkName = "Illinois River Forks State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 110, ParkName = "Molalla River State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 111, ParkName = "Beaver Creek State Natural Area", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 112, ParkName = "Umpqua Lighthouse State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 113, ParkName = "Carl G. Washburne Memorial State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 114, ParkName = "Jessie M. Honeyman Memorial State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 115, ParkName = "Willamette Mission State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 116, ParkName = "Milo McIver State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 117, ParkName = "Ainsworth State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 118, ParkName = "Guy W. Talbot State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 119, ParkName = "Mayer State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 120, ParkName = "Memaloose State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 121, ParkName = "Starvation Creek State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 122, ParkName = "Viento State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 123, ParkName = "Rooster Rock State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 124, ParkName = "Fort Stevens State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 125, ParkName = "Bob Straub State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 126, ParkName = "Ecola State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 127, ParkName = "Oswald West State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 128, ParkName = "Nehalem Bay State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 129, ParkName = "Ona Beach State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 130, ParkName = "South Beach State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 131, ParkName = "Cascadia State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 132, ParkName = "Silver Falls State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 133, ParkName = "Beverly Beach State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 134, ParkName = "Collier Memorial State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 135, ParkName = "L. L. 'Stub' Stewart State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 136, ParkName = "State Capitol State Park", TypeOfPark = "State", Location = "Oregon" },
                new Park { ParkId = 137, ParkName = "Cottonwood Canyon State Park", TypeOfPark = "State", Location = "Oregon" }                
            );
        }
    }
}
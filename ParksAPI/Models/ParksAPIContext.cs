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
        builder.Entity<Animal>()
            .HasData(
                new Park { ParkId = 1, Name = "Acadia National Park", StateLocation = "Maine" },
                new Park { ParkId = 1, Name = "American Samoa National Park	", StateLocation = "American Samoa Territory" },
                new Park { ParkId = 1, Name = "Arches National Park	", StateLocation = "Utah" },
                new Park { ParkId = 1, Name = "Badlands National Park ", StateLocation = "South Dakota" },
                new Park { ParkId = 1, Name = "Big Bend National Park", StateLocation = "Texas" },
                new Park { ParkId = 1, Name = "Biscayne National Park", StateLocation = "Florida" },
                new Park { ParkId = 1, Name = "Black Canyon of the Gunnison National Park", StateLocation = "Colorado" },
                new Park { ParkId = 1, Name = "Bryce Canyon National Park", StateLocation = "Utah" },
                new Park { ParkId = 1, Name = "Canyonlands National Park", StateLocation = "Utah" },
                new Park { ParkId = 1, Name = "Capitol Reef National Park", StateLocation = "Utah" },
                new Park { ParkId = 1, Name = "Carlsbad Caverns National Park", StateLocation = "New Mexico" },
                new Park { ParkId = 1, Name = "Channel Islands National Park", StateLocation = "California" },
                new Park { ParkId = 1, Name = "Congaree National Park", StateLocation = "South Carolina" },
                new Park { ParkId = 1, Name = "Crater Lake National Park", StateLocation = "Oregon" },
                new Park { ParkId = 1, Name = "Cuyahoga Valley National Park", StateLocation = "Ohio" },
                new Park { ParkId = 1, Name = "Death Valley National Park", StateLocation = "California and Nevada" },
                new Park { ParkId = 1, Name = "Denali National Park", StateLocation = "Alaska" },
                new Park { ParkId = 1, Name = "Dry Tortugas National Park", StateLocation = "Florida" },
                new Park { ParkId = 1, Name = "Everglades National Park", StateLocation = "Florida" },
                new Park { ParkId = 1, Name = "Gates of the Arctic National Park", StateLocation = "Alaska" },
                new Park { ParkId = 1, Name = "Gateway Arch National Park", StateLocation = "Missouri" },
                new Park { ParkId = 1, Name = "Glacier National Park", StateLocation = "Montana" },
                new Park { ParkId = 1, Name = "Glacier Bay National Park", StateLocation = "Alaska" },
                new Park { ParkId = 1, Name = "Grand Canyon National Park", StateLocation = "Arizona" },
                new Park { ParkId = 1, Name = "Grand Teton National Park", StateLocation = "Wyoming" },
                new Park { ParkId = 1, Name = "Great Basin National Park", StateLocation = "Nevada" },
                new Park { ParkId = 1, Name = "Great Sand Dunes National Park", StateLocation = "Colorado" },
                new Park { ParkId = 1, Name = "Great Smoky Mountains National Park", StateLocation = "North Carolina and Tennessee" },
                new Park { ParkId = 1, Name = "Guadalupe Mountains National Park", StateLocation = "Texas" },
                new Park { ParkId = 1, Name = "Haleakala National Park", StateLocation = "Hawaii" },
                new Park { ParkId = 1, Name = "Hawaii Volcanoes National Park", StateLocation = "Hawaii" },
                new Park { ParkId = 1, Name = "Hot Springs National Park", StateLocation = "Arkansas" },
                new Park { ParkId = 1, Name = "Indiana Dunes National Park", StateLocation = "Indiana" },
                new Park { ParkId = 1, Name = "Isle Royale National Park", StateLocation = "Michigan" },
                new Park { ParkId = 1, Name = "Joshua Tree National Park", StateLocation = "California" },
                new Park { ParkId = 1, Name = "Katmai National Park", StateLocation = "Alaska" },
                new Park { ParkId = 1, Name = "Kenai Fjords National Park", StateLocation = "Alaska" },
                new Park { ParkId = 1, Name = "Kings Canyon National Park", StateLocation = "California" },
                new Park { ParkId = 1, Name = "Kobuk Valley National Park", StateLocation = "Alaska" },
                new Park { ParkId = 1, Name = "Lake Clark National Park", StateLocation = "Alaska" },
                new Park { ParkId = 1, Name = "Lassen Volcanic Park", StateLocation = "California" },
                new Park { ParkId = 1, Name = "Mammoth Cave Park", StateLocation = "Kentucky" },
                new Park { ParkId = 1, Name = "Mesa Verde National Park", StateLocation = "Colorado" },
                new Park { ParkId = 1, Name = "Mount Rainier National Park", StateLocation = "Washington" },
                new Park { ParkId = 1, Name = "North Cascades National Park", StateLocation = "Washington" },
                new Park { ParkId = 1, Name = "Olympic National Park", StateLocation = "Washington" },
                new Park { ParkId = 1, Name = "Petrified Forest National Park", StateLocation = "Arizona" },
                new Park { ParkId = 1, Name = "Pinnacles National Park", StateLocation = "California" },
                new Park { ParkId = 1, Name = "Redwood National Park", StateLocation = "California" },
                new Park { ParkId = 1, Name = "Rocky Mountain National Park", StateLocation = "Colorado" },
                new Park { ParkId = 1, Name = "Saguaro National Park", StateLocation = "Arizona" },
                new Park { ParkId = 1, Name = "Sequoia National Park", StateLocation = "California" },
                new Park { ParkId = 1, Name = "Shenandoah National Park", StateLocation = "Virginia" },
                new Park { ParkId = 1, Name = "Theodore Roosevelt National Park", StateLocation = "North Dakota" },
                new Park { ParkId = 1, Name = "Virgin Islands National Park", StateLocation = "U.S. Virgin Islands" },
                new Park { ParkId = 1, Name = "Voyageurs National Park", StateLocation = "Minnesota" },
                new Park { ParkId = 1, Name = "Wind Cave National Park", StateLocation = "South Dakota" },
                new Park { ParkId = 1, Name = "Wrangell-St. Elias National Park", StateLocation = "Alaska" },
                new Park { ParkId = 1, Name = "Yellowstone National Park", StateLocation = "Wyoming" },
                new Park { ParkId = 1, Name = "Yosemite National Park", StateLocation = "California" },
                new Park { ParkId = 1, Name = "Zion National Park", StateLocation = "Utah" },
            );
        }
    }
}
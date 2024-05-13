using Microsoft.EntityFrameworkCore;

namespace OnlineHotelBooking
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Hotel> Hotels => Set<Hotel>();
        public DbSet<Room> Rooms => Set<Room>();
        public DbSet<User> Users => Set<User>();
        public DbSet<Client> Clients => Set<Client>();
        public DbSet<HotelReservationTable> HotelsReservationTable => Set<HotelReservationTable>();
        public DbSet<RoomCategoryReservationParameters> RoomCategoryReservationParameters => Set<RoomCategoryReservationParameters>();
        public DbSet<Balance> Balance => Set<Balance>();
        public DbSet<Photo> Photos => Set<Photo>();

        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=OnlineHotelBooking.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User("Администратор", "12345678", UserType.Администратор, "+7 (999) 999-99-99") { Id = 1 });
        }
    }
}
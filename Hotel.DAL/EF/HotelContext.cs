using Hotel.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hotel.DAL.EF
{
    public class HotelContext : DbContext
    {
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<PriceCategory> PriceCategories { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public HotelContext(DbContextOptions<HotelContext> options)
           : base(options)
        {
            Database.EnsureCreated();
        }
       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=relationsdb;Trusted_Connection=True;");
        }*/
       
    }
}

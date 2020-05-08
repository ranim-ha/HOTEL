using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Model.MainModel;
using Model.Security;
using System;

namespace DBTools
{
    public class Context :
        IdentityDbContext<TGUser, TGRole, Guid, TGUserClaim, TGUserRole, TGUserLogin, TGRoleClaim, TGUserToken>
    {
        public DbSet<Bill> Bills { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomBooking> roomBookings { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<RoomTag> RoomTags { get; set; }
        public DbSet<WishList> WishList { get; set; }



        public Context()
        {
        }
       // public Context(DbContextOptions<Context> options) : base(options)
       // {
       // }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=TourGuideDB;Integrated Security=True");
        }
    }
}
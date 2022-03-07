using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : IdentityDbContext<AppUser>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Activity> Activities { get; set; }
        public DbSet<BM_SecUser> BM_SecUser { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BM_SecUser>().HasKey(x => x.BM_UserID);

            //modelBuilder.Entity<AppUser>().HasOne(x => x.BMSecUser).WithOne(x=>x.AppUser).HasForeignKey<BM_SecUser>(b => b.BM_UserID);

        }
    }
}
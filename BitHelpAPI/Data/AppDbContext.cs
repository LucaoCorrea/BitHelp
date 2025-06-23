using Microsoft.EntityFrameworkCore;

namespace BitHelpAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Models.UserModel> Users { get; set; }
        public DbSet<Models.TicketModel> Tickets { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Models.UserModel>()
                .HasKey(u => u.Id);
            modelBuilder.Entity<Models.UserModel>()
                .Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(100);
            modelBuilder.Entity<Models.UserModel>()
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}

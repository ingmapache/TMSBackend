using Entities;
using Microsoft.EntityFrameworkCore;

namespace DBContext;

public class DatabaseContext : DbContext
{
   public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options){ }
   public DbSet<Category> Categories { get; set; }
   public DbSet<User> Users { get; set; }
   public DbSet<UTask> UTasks { get; set; }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
      //Definition for Categories
      modelBuilder.Entity<Category>(entity =>
      {
         entity.ToTable("Categories");

         entity.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(100);

         //Relation to Tasks
         entity.HasMany(e => e.UTasks).WithOne(e => e.Category).HasForeignKey(e => e.Id);
      });

      //Definition for Tasks
      modelBuilder.Entity<UTask>(entity =>
      {
         entity.ToTable("Tasks");
         
         entity.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(100);
         entity.Property(e => e.Description)
            .HasMaxLength(400);
         
         //Relation to Categories
         entity.HasOne(e => e.Category).WithMany(e => e.UTasks).HasForeignKey(e => e.CategoryId);
         
         //Relation to User
         entity.HasOne(e => e.User).WithMany(e => e.UTasks).HasForeignKey(e => e.UserId);
      });

      //Definition for Users
      modelBuilder.Entity<User>(entity =>
      {
         entity.ToTable("Users");

         entity.Property(e => e.AccountNickname)
            .IsRequired()
            .HasMaxLength(20);
         entity.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(30);
         entity.Property(e => e.Surname)
            .IsRequired()
            .HasMaxLength(30);
         entity.Property(e => e.Email)
            .IsRequired()
            .HasMaxLength(100);
         entity.Property(e => e.Password)
            .IsRequired()
            .HasMaxLength(50);

         //Relation to UTasks
         entity.HasMany(e => e.UTasks).WithOne(e => e.User).HasForeignKey(e => e.UserId);
      });
   }
}
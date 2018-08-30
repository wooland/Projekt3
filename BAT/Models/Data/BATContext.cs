using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BAT.Models.Data
{
    public partial class BATContext : DbContext
    {
        public BATContext()
        {
        }

        public BATContext(DbContextOptions<BATContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BatChat> BatChat { get; set; }
        public virtual DbSet<BatMessage> BatMessage { get; set; }
        public virtual DbSet<BatUsers> BatUsers { get; set; }
        public virtual DbSet<UserInChat> UserInChat { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=BAT;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BatChat>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.Header).IsUnicode(false);
            });

            modelBuilder.Entity<BatMessage>(entity =>
            {
                entity.HasKey(e => e.Mid);

                entity.Property(e => e.Mid).HasColumnName("MID");

                entity.Property(e => e.ChatId).HasColumnName("ChatID");

                entity.Property(e => e.Entered).HasColumnType("datetime");

                entity.Property(e => e.MessageText).IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Chat)
                    .WithMany(p => p.BatMessage)
                    .HasForeignKey(d => d.ChatId)
                    .HasConstraintName("FK__BatMessag__ChatI__286302EC");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BatMessage)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__BatMessag__UserI__276EDEB3");
            });

            modelBuilder.Entity<BatUsers>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.Property(e => e.Uid).HasColumnName("UID");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);
            });

            modelBuilder.Entity<UserInChat>(entity =>
            {
                entity.HasKey(e => e.Uicid);

                entity.Property(e => e.Uicid).HasColumnName("UICID");

                entity.Property(e => e.ChatId).HasColumnName("ChatID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Chat)
                    .WithMany(p => p.UserInChat)
                    .HasForeignKey(d => d.ChatId)
                    .HasConstraintName("FK__UserInCha__ChatI__2C3393D0");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserInChat)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserInCha__UserI__2B3F6F97");
            });
        }
    }
}

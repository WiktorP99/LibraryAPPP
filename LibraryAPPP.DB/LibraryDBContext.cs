using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace LibraryAPPP.DB.DTO
{
    public partial class LibraryDBContext : DbContext
    {
        public LibraryDBContext()
        {
        }

        public LibraryDBContext(DbContextOptions<LibraryDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<RentDetail> RentDetails { get; set; }
        public virtual DbSet<RentHeader> RentHeaders { get; set; }
        public virtual DbSet<RentStatus> RentStatuses { get; set; }
        public virtual DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }
        public virtual DbSet<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public virtual DbSet<SalesOrderStatus> SalesOrderStatuses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();


                var connectionString = configuration.GetConnectionString("LibraryDB");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(entity =>
            {
                entity.Property(e => e.AuthorFirstName).HasMaxLength(50);

                entity.Property(e => e.AuthorLastName).HasMaxLength(50);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.Price).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.PublicationDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Books_Authors");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ClientFirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ClientLastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.Province)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<RentDetail>(entity =>
            {
                entity.ToTable("RentDetail");

                entity.Property(e => e.PenaltyFee).HasColumnType("decimal(9, 2)");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.RentDetails)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RentDetail_Books");

                entity.HasOne(d => d.RentHeader)
                    .WithMany(p => p.RentDetails)
                    .HasForeignKey(d => d.RentHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RentDetail_RentHeader");
            });

            modelBuilder.Entity<RentHeader>(entity =>
            {
                entity.ToTable("RentHeader");

                entity.Property(e => e.RentDate).HasColumnType("datetime");

                entity.Property(e => e.ReturnDate).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.RentHeaders)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RentHeader_Customer");

                entity.HasOne(d => d.RentStatus)
                    .WithMany(p => p.RentHeaders)
                    .HasForeignKey(d => d.RentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RentHeader_RentStatus");
            });

            modelBuilder.Entity<RentStatus>(entity =>
            {
                entity.ToTable("RentStatus");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<SalesOrderDetail>(entity =>
            {
                entity.ToTable("SalesOrderDetail");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.SalesOrderDetails)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesOrderDetail_Books");

                entity.HasOne(d => d.SalesOrderHeader)
                    .WithMany(p => p.SalesOrderDetails)
                    .HasForeignKey(d => d.SalesOrderHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesOrderDetail_Header");
            });

            modelBuilder.Entity<SalesOrderHeader>(entity =>
            {
                entity.ToTable("SalesOrderHeader");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.SalesOrderHeaders)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesOrderHeader_Books");

                entity.HasOne(d => d.SalesOrderStatus)
                    .WithMany(p => p.SalesOrderHeaders)
                    .HasForeignKey(d => d.SalesOrderStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesOrderHeader_Status");
            });

            modelBuilder.Entity<SalesOrderStatus>(entity =>
            {
                entity.HasKey(e => e.SalesOrderStatus1)
                    .HasName("PK__SalesOrd__A8197D4C2501B998");

                entity.ToTable("SalesOrderStatus");

                entity.Property(e => e.SalesOrderStatus1).HasColumnName("SalesOrderStatus");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

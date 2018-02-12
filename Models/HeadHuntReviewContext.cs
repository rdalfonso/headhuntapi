using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace headhuntapi.Models
{
    public partial class HeadHuntReviewContext : DbContext
    {
        public virtual DbSet<Candidates> Candidates { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Recruiters> Recruiters { get; set; }
        public virtual DbSet<Reviews> Reviews { get; set; }

        public HeadHuntReviewContext(DbContextOptions<HeadHuntReviewContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=db,1433;Initial Catalog=HeadHuntReview;User Id=SA;Password=L@rc0mb3");
           
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidates>(entity =>
            {
                entity.Property(e => e.Industry)
                    .HasColumnName("industry")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasColumnName("zipcode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Stars).HasColumnName("stars");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Industry)
                    .HasColumnName("industry")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Stars).HasColumnName("stars");
            });

            modelBuilder.Entity<Recruiters>(entity =>
            {
                entity.Property(e => e.Company)
                    .HasColumnName("company")
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("companyId");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(50);

                entity.Property(e => e.ZipCode)
                    .HasColumnName("zipcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Level)
                   .HasColumnName("level")
                   .HasMaxLength(10);

                entity.Property(e => e.Stars).HasColumnName("stars");
            });

            modelBuilder.Entity<Reviews>(entity =>
            {
                entity.Property(e => e.CandidateId).HasColumnName("candidateId");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Blurb)
                    .HasColumnName("blurb")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecruiterId).HasColumnName("recruiterId");

                entity.Property(e => e.Stars)
                    .HasColumnName("stars")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}

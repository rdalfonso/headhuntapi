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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=localhost,1401;Initial Catalog=HeadHuntReview;Integrated Security=False;User Id=SA;Password=L@rc0mb3");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidates>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Candidates_Id_uindex")
                    .IsUnique();

                entity.Property(e => e.Email)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FbUid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Industry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Company_Id_uindex")
                    .IsUnique();

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Industry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Recruiters>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Recruiters_Id_uindex")
                    .IsUnique();

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Level)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LinkedIn)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Recruiters)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK__Recruiter__Compa__4D94879B");
            });

            modelBuilder.Entity<Reviews>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("Reviews_Id_uindex")
                    .IsUnique();

                entity.Property(e => e.Body).HasColumnType("text");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.CandidateId)
                    .HasConstraintName("FK__Reviews__Candida__534D60F1");

                entity.HasOne(d => d.Recruiter)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.RecruiterId)
                    .HasConstraintName("FK__Reviews__Recruit__52593CB8");
            });
        }
    }
}

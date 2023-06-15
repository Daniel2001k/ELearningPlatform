using Duende.IdentityServer.EntityFramework.Options;
using ELearningPlatform.Server.Data.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ELearningPlatform.Server.Data;

public partial class CoursePlatformContext : DbContext
{
    public CoursePlatformContext()
    {

    }
    public CoursePlatformContext(DbContextOptions<CoursePlatformContext> options) : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; } = null!;
    public virtual DbSet<CourseStudent> CourseStudents { get; set; } = null!;
    public virtual DbSet<CurseLevel> CurseLevels { get; set; } = null!;
    public virtual DbSet<Language> Languages { get; set; } = null!;
    public virtual DbSet<Student> Students { get; set; } = null!;
    public virtual DbSet<Models.Task> Tasks { get; set; } = null!;
    public virtual DbSet<TaskType> TaskTypes { get; set; } = null!;
    public virtual DbSet<Tutor> Tutors { get; set; } = null!;
    public virtual DbSet<User> Users { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Course>(entity =>
        {
            entity.ToTable("Course");

            entity.HasKey(e => e.Id);

            entity.HasOne(d => d.Language)
                .WithMany(p => p.Courses)
                .HasForeignKey(d => d.LanguageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Course_fk1");

            entity.HasOne(d => d.Level)
                .WithMany(p => p.Courses)
                .HasForeignKey(d => d.LevelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Course_fk2");

            entity.HasOne(d => d.Tutor)
                .WithMany(p => p.Courses)
                .HasForeignKey(d => d.TutorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Course_fk0");
        });

        modelBuilder.Entity<CourseStudent>(entity =>
        {
            entity.ToTable("CourseStudent");

            entity.HasKey(e => e.Id);

            entity.HasOne(d => d.Course)
                .WithMany(p => p.CourseStudents)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("CourseStudent_fk0");
        });

        modelBuilder.Entity<CurseLevel>(entity =>
        {
            entity.ToTable("CurseLevel");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Name)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.ToTable("Language");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Name)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.ToTable("Student");

            entity.HasKey(e => e.Id);

            entity.HasOne(d => d.User)
                .WithMany(p => p.Students)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Student_fk0");
        });

        modelBuilder.Entity<Models.Task>(entity =>
        {
            entity.ToTable("Task");

            entity.HasKey(e => e.Id);

            entity.HasOne(d => d.TaskType)
                .WithMany(p => p.Tasks)
                .HasForeignKey(d => d.TaskTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Task_fk0");
        });

        modelBuilder.Entity<TaskType>(entity =>
        {
            entity.ToTable("TaskType");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Name)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Tutor>(entity =>
        {
            entity.ToTable("Tutor");

            entity.HasKey(e => e.Id);

            entity.HasOne(d => d.User)
                .WithMany(p => p.Tutors)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Tutor_fk0");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.BirthDate).HasColumnType("date");

            entity.Property(e => e.Name)
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Pesel)
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Surname)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

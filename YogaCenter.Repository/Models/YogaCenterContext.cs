using System;
using System.Collections.Generic;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace YogaCenter.Repository.Models
{
    public partial class YogaCenterContext : DbContext
    {
        public YogaCenterContext()
        {
        }

        public YogaCenterContext(DbContextOptions<YogaCenterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<Lesson> Lessons { get; set; } = null!;
        public virtual DbSet<Programs> Programs { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Timeslot> Timeslots { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }

        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            string? connStr = config["DbConnections:DefaultDB"];
            return connStr ?? throw new JsonException($"Connection string not found at {Directory.GetCurrentDirectory()}.");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("course");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.EndRegisterDate)
                    .HasColumnType("date")
                    .HasColumnName("end_register_date");

                entity.Property(e => e.Inactive).HasColumnName("inactive");

                entity.Property(e => e.InstructorId).HasColumnName("instructor_id");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.StartRegisterDate)
                    .HasColumnType("date")
                    .HasColumnName("start_register_date");

                entity.HasOne(d => d.Instructor)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.InstructorId);

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.ProgramId);
            });

            modelBuilder.Entity<Lesson>(entity =>
            {
                entity.ToTable("lesson");

                entity.HasIndex(e => new { e.CourseId, e.LessonNumber }, "IX_lesson_course_id_lesson_number")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .HasColumnName("description");

                entity.Property(e => e.Inactive).HasColumnName("inactive");

                entity.Property(e => e.LessonNumber).HasColumnName("lesson_number");

                entity.Property(e => e.Room)
                    .HasMaxLength(10)
                    .HasColumnName("room");

                entity.Property(e => e.Timeslot).HasColumnName("timeslot");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.CourseId);

                entity.HasOne(d => d.TimeslotNavigation)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.Timeslot);
            });

            modelBuilder.Entity<Programs>(entity =>
            {
                entity.ToTable("program");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(4000)
                    .HasColumnName("description");

                entity.Property(e => e.Fee).HasColumnName("fee");

                entity.Property(e => e.Inactive).HasColumnName("inactive");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("role");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(15)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Timeslot>(entity =>
            {
                entity.ToTable("timeslot");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .HasColumnName("name");

                entity.Property(e => e.StartTime).HasColumnName("start_time");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("dob");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Experience)
                    .HasMaxLength(255)
                    .HasColumnName("experience");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(255)
                    .HasColumnName("fullname");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.Inactive).HasColumnName("inactive");

                entity.Property(e => e.JoinDate)
                    .HasColumnType("datetime")
                    .HasColumnName("join_date");

                entity.Property(e => e.LastLogin)
                    .HasColumnType("datetime")
                    .HasColumnName("last_login");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .HasColumnName("phone");

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Specializations)
                    .HasMaxLength(255)
                    .HasColumnName("specializations");

                entity.Property(e => e.StudyGoals)
                    .HasMaxLength(255)
                    .HasColumnName("study_goals");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasMany(d => d.CoursesNavigation)
                    .WithMany(p => p.Learners)
                    .UsingEntity<Dictionary<string, object>>(
                        "Courseregister",
                        l => l.HasOne<Course>().WithMany().HasForeignKey("CourseId").OnDelete(DeleteBehavior.ClientSetNull),
                        r => r.HasOne<User>().WithMany().HasForeignKey("LearnerId").OnDelete(DeleteBehavior.ClientSetNull),
                        j =>
                        {
                            j.HasKey("LearnerId", "CourseId");

                            j.ToTable("courseregister");

                            j.IndexerProperty<long>("LearnerId").HasColumnName("learner_id");

                            j.IndexerProperty<int>("CourseId").HasColumnName("course_id");
                        });

                entity.HasMany(d => d.Lessons)
                    .WithMany(p => p.Learners)
                    .UsingEntity<Dictionary<string, object>>(
                        "Timetable",
                        l => l.HasOne<Lesson>().WithMany().HasForeignKey("LessonId").OnDelete(DeleteBehavior.ClientSetNull),
                        r => r.HasOne<User>().WithMany().HasForeignKey("LearnerId").OnDelete(DeleteBehavior.ClientSetNull),
                        j =>
                        {
                            j.HasKey("LearnerId", "LessonId");

                            j.ToTable("timetable");

                            j.IndexerProperty<long>("LearnerId").HasColumnName("learner_id");

                            j.IndexerProperty<int>("LessonId").HasColumnName("lesson_id");
                        });

                entity.HasMany(d => d.Programs)
                    .WithMany(p => p.Instructors)
                    .UsingEntity<Dictionary<string, object>>(
                        "ProgramInstructor",
                        l => l.HasOne<Programs>().WithMany().HasForeignKey("ProgramId").OnDelete(DeleteBehavior.ClientSetNull),
                        r => r.HasOne<User>().WithMany().HasForeignKey("InstructorId").OnDelete(DeleteBehavior.ClientSetNull),
                        j =>
                        {
                            j.HasKey("InstructorId", "ProgramId");

                            j.ToTable("program_instructor");

                            j.IndexerProperty<long>("InstructorId").HasColumnName("instructor_id");

                            j.IndexerProperty<int>("ProgramId").HasColumnName("program_id");
                        });
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using System;
using System.Collections.Generic;
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
        public virtual DbSet<Program> Programs { get; set; } = null!;
        public virtual DbSet<Review> Reviews { get; set; } = null!;
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
            return config["DbConnections:DefaultDB"]
                ?? throw new InvalidOperationException("The default connection string was not found");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("course");

                entity.HasIndex(e => new { e.ProgramId, e.CourseNumber }, "IX_course_program_id_course_number")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CourseNumber)
                    .IsRequired()
                    .HasColumnName("course_number");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.Inactive).HasColumnName("inactive");

                entity.Property(e => e.InstructorId).HasColumnName("instructor_id");

                entity.Property(e => e.ProgramId)
                    .IsRequired()
                    .HasColumnName("program_id");

                entity.Property(e => e.RegistrationCloseDate)
                    .HasColumnType("date")
                    .HasColumnName("registration_close_date");

                entity.Property(e => e.RegistrationOpenDate)
                    .HasColumnType("date")
                    .HasColumnName("registration_open_date");

                entity.Property(e => e.Schedule)
                    .HasMaxLength(200)
                    .HasColumnName("schedule");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.HasOne(d => d.Instructor)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.InstructorId)
                    .OnDelete(DeleteBehavior.SetNull);

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasMany(d => d.Learners)
                    .WithMany(p => p.CoursesNavigation)
                    .UsingEntity<Dictionary<string, object>>(
                        "Courseregister",
                        l => l.HasOne<User>().WithMany().HasForeignKey("LearnerId"),
                        r => r.HasOne<Course>().WithMany().HasForeignKey("CourseId"),
                        j =>
                        {
                            j.HasKey("CourseId", "LearnerId");

                            j.ToTable("courseregister");

                            j.IndexerProperty<int>("CourseId").HasColumnName("course_id");

                            j.IndexerProperty<long>("LearnerId").HasColumnName("learner_id");
                        });
            });

            modelBuilder.Entity<Lesson>(entity =>
            {
                entity.ToTable("lesson");

                entity.HasIndex(e => new { e.ProgramId, e.CourseNumber, e.LessonNumber }, "IX_lesson_course_id_course_number_lesson_number")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CourseNumber).HasColumnName("course_number");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .HasColumnName("description");

                entity.Property(e => e.Inactive).HasColumnName("inactive");

                entity.Property(e => e.LessonNumber).HasColumnName("lesson_number");

                entity.Property(e => e.Location)
                    .HasMaxLength(20)
                    .HasColumnName("location");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.Property(e => e.Timeslot).HasColumnName("timeslot");

                entity.HasOne(d => d.TimeslotNavigation)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.Timeslot)
                    .OnDelete(DeleteBehavior.SetNull);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Lessons)
                    .HasPrincipalKey(p => new { p.ProgramId, p.CourseNumber })
                    .HasForeignKey(d => new { d.ProgramId, d.CourseNumber })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_lesson_course_course_id");

                entity.HasMany(d => d.Learners)
                    .WithMany(p => p.Lessons)
                    .UsingEntity<Dictionary<string, object>>(
                        "Attendance",
                        l => l.HasOne<User>().WithMany().HasForeignKey("LearnerId"),
                        r => r.HasOne<Lesson>().WithMany().HasForeignKey("LessonId"),
                        j =>
                        {
                            j.HasKey("LessonId", "LearnerId");

                            j.ToTable("attendance");

                            j.IndexerProperty<int>("LessonId").HasColumnName("lesson_id");

                            j.IndexerProperty<long>("LearnerId").HasColumnName("learner_id");
                        });
            });

            modelBuilder.Entity<Program>(entity =>
            {
                entity.ToTable("program");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(4000)
                    .HasColumnName("description");

                entity.Property(e => e.Fee)
                    .HasColumnType("money")
                    .HasColumnName("fee");

                entity.Property(e => e.Img)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("img");

                entity.Property(e => e.Inactive).HasColumnName("inactive");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.HasMany(d => d.Instructors)
                    .WithMany(p => p.Programs)
                    .UsingEntity<Dictionary<string, object>>(
                        "ProgramInstructor",
                        l => l.HasOne<User>().WithMany().HasForeignKey("InstructorId"),
                        r => r.HasOne<Program>().WithMany().HasForeignKey("ProgramId"),
                        j =>
                        {
                            j.HasKey("ProgramId", "InstructorId");

                            j.ToTable("program_instructor");

                            j.IndexerProperty<int>("ProgramId").HasColumnName("program_id");

                            j.IndexerProperty<long>("InstructorId").HasColumnName("instructor_id");
                        });
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.ToTable("review");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Content)
                    .HasMaxLength(1000)
                    .HasColumnName("content");

                entity.Property(e => e.LearnerId).HasColumnName("learner_id");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

                entity.HasOne(d => d.Learner)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.LearnerId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.Cascade);
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
                    .HasMaxLength(200)
                    .HasColumnName("email");

                entity.Property(e => e.Experience)
                    .HasMaxLength(200)
                    .HasColumnName("experience");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(200)
                    .HasColumnName("fullname");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.Img)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("img");

                entity.Property(e => e.Inactive).HasColumnName("inactive");

                entity.Property(e => e.JoinDate)
                    .HasColumnType("datetime")
                    .HasColumnName("join_date");

                entity.Property(e => e.LastLogin)
                    .HasColumnType("datetime")
                    .HasColumnName("last_login");

                entity.Property(e => e.Password)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .HasColumnName("phone");

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Specializations)
                    .HasMaxLength(200)
                    .HasColumnName("specializations");

                entity.Property(e => e.StudyGoals)
                    .HasMaxLength(200)
                    .HasColumnName("study_goals");

                entity.Property(e => e.Username)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

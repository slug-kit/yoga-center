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

        public virtual DbSet<Attendance> Attendances { get; set; } = null!;
        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<CourseAssignmentRequest> CourseAssignmentRequests { get; set; } = null!;
        public virtual DbSet<CourseRegister> CourseRegisters { get; set; } = null!;
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
                ?? throw new InvalidOperationException("The default connection string was not found.");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.HasKey(e => new { e.LessonId, e.LearnerId });

                entity.ToTable("attendance");

                entity.Property(e => e.LessonId).HasColumnName("lesson_id");

                entity.Property(e => e.LearnerId).HasColumnName("learner_id");

                entity.Property(e => e.Attended).HasColumnName("attended");

                entity.HasOne(d => d.Learner)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.LearnerId);

                entity.HasOne(d => d.Lesson)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.LessonId);
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("course");

                entity.HasIndex(e => new { e.ProgramId, e.CourseNumber }, "IX_course_program_id_course_number")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CourseNumber).HasColumnName("course_number");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.HasNewRequest).HasColumnName("has_new_request");

                entity.Property(e => e.Inactive).HasColumnName("inactive");

                entity.Property(e => e.InstructorId).HasColumnName("instructor_id");

                entity.Property(e => e.ProgramId).HasColumnName("program_id");

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
                    .WithMany(p => p.CoursesAssigned)
                    .HasForeignKey(d => d.InstructorId)
                    .OnDelete(DeleteBehavior.SetNull);

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.ProgramId);
            });

            modelBuilder.Entity<CourseAssignmentRequest>(entity =>
            {
                entity.HasKey(e => new { e.CourseId, e.InstructorId })
                    .HasName("PK_courseassignmentrequest");

                entity.ToTable("course_assignment_request");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.InstructorId).HasColumnName("instructor_id");

                entity.Property(e => e.New)
                    .IsRequired()
                    .HasColumnName("new")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseAssignmentRequests)
                    .HasForeignKey(d => d.CourseId);

                entity.HasOne(d => d.Instructor)
                    .WithMany(p => p.CourseAssignmentRequests)
                    .HasForeignKey(d => d.InstructorId);
            });

            modelBuilder.Entity<CourseRegister>(entity =>
            {
                entity.HasKey(e => new { e.CourseId, e.LearnerId })
                    .HasName("PK_courseregister");

                entity.ToTable("course_register");

                entity.Property(e => e.CourseId).HasColumnName("course_id");

                entity.Property(e => e.LearnerId).HasColumnName("learner_id");

                entity.Property(e => e.EnrolDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("enrol_datetime");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseRegisters)
                    .HasForeignKey(d => d.CourseId);

                entity.HasOne(d => d.Learner)
                    .WithMany(p => p.CourseRegisters)
                    .HasForeignKey(d => d.LearnerId);
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
                    .HasConstraintName("FK_lesson_course_course_id");
            });

            modelBuilder.Entity<Program>(entity =>
            {
                entity.ToTable("program");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code");

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

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("name");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.HasMany(d => d.Instructors)
                    .WithMany(p => p.Programs)
                    .UsingEntity<Dictionary<string, object>>(
                        "ProgramAssignment",
                        l => l.HasOne<User>().WithMany().HasForeignKey("InstructorId"),
                        r => r.HasOne<Program>().WithMany().HasForeignKey("ProgramId"),
                        j =>
                        {
                            j.HasKey("ProgramId", "InstructorId").HasName("PK_programassignment");

                            j.ToTable("program_assignment");

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
                    .HasForeignKey(d => d.LearnerId);

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.ProgramId);
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
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.StartTime).HasColumnName("start_time");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.HasIndex(e => e.Email, "IX_user_email")
                    .IsUnique();

                entity.HasIndex(e => e.Username, "IX_user_username")
                    .IsUnique();

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

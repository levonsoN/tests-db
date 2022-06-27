using Microsoft.EntityFrameworkCore;

namespace SimpleTesting.Model
{
    public partial class TestsContext : DbContext
    {
        public TestsContext()
        {
        }

        public TestsContext(DbContextOptions<TestsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Answer> Answers { get; set; } = null!;
        public virtual DbSet<Author> Authors { get; set; } = null!;
        public virtual DbSet<Discipline> Disciplines { get; set; } = null!;
        public virtual DbSet<Question> Questions { get; set; } = null!;
        public virtual DbSet<Test> Tests { get; set; } = null!;
        public virtual DbSet<TestResult> TestResults { get; set; } = null!;
        public virtual DbSet<TestResultAnswer> TestResultAnswers { get; set; } = null!;
        public virtual DbSet<Ticket> Tickets { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("DataSource=C:\\tests.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>(entity =>
            {
                entity.ToTable("Answer");

                entity.Property(e => e.IsCorrect).HasColumnType("BOOLEAN");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.QuestionId);
            });

            modelBuilder.Entity<Author>(entity =>
            {
                entity.ToTable("Author");

                entity.Property(e => e.Name).HasColumnType("VARCHAR (100)");

                entity.Property(e => e.Password).HasColumnType("VARCHAR (32)");

                entity.Property(e => e.Patronimyc).HasColumnType("VARCHAR (100)");

                entity.Property(e => e.Surname).HasColumnType("VARCHAR (100)");
            });

            modelBuilder.Entity<Discipline>(entity =>
            {
                entity.ToTable("Discipline");

                entity.Property(e => e.Name).HasColumnType("VARCHAR (100)");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.ToTable("Question");

                entity.Property(e => e.IsMultipleAnswers).HasColumnType("BOOLEAN");

                entity.Property(e => e.Points).HasColumnType("DOUBLE");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.TicketId);
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.ToTable("Test");

                entity.Property(e => e.CreationDate).HasColumnType("DATETIME");

                entity.Property(e => e.DisciplineId).HasColumnName("DisciplineID");

                entity.Property(e => e.LastModifiedDate).HasColumnType("DATETIME");

                entity.Property(e => e.Name).HasColumnType("VARCHAR (100)");

                entity.Property(e => e.TotalPoints).HasColumnType("DOUBLE");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Tests)
                    .HasForeignKey(d => d.AuthorId);

                entity.HasOne(d => d.Discipline)
                    .WithMany(p => p.Tests)
                    .HasForeignKey(d => d.DisciplineId);
            });

            modelBuilder.Entity<TestResult>(entity =>
            {
                entity.ToTable("TestResult");

                entity.Property(e => e.ExecutionDate).HasColumnType("DATETIME");

                entity.Property(e => e.StudentGroup).HasColumnType("VARCHAR (100)");

                entity.Property(e => e.StudentName).HasColumnType("VARCHAR (100)");

                entity.Property(e => e.StudentPatronimyc).HasColumnType("VARCHAR (100)");

                entity.Property(e => e.StudentSurname).HasColumnType("VARCHAR (100)");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.TestResults)
                    .HasForeignKey(d => d.TicketId);
            });

            modelBuilder.Entity<TestResultAnswer>(entity =>
            {
                entity.HasKey(e => e.TestResultAnwerId);

                entity.ToTable("TestResultAnswer");

                entity.HasOne(d => d.Answer)
                    .WithMany(p => p.TestResultAnswers)
                    .HasForeignKey(d => d.AnswerId);

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.TestResultAnswers)
                    .HasForeignKey(d => d.QuestionId);

                entity.HasOne(d => d.TestResult)
                    .WithMany(p => p.TestResultAnswers)
                    .HasForeignKey(d => d.TestResultId);
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.ToTable("Ticket");

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.TestId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

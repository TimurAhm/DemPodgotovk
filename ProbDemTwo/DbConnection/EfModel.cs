using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ProbDemTwo.DbConnection.EntityES;

namespace ProbDemTwo.DbConnection
{
    public partial class EfModel : DbContext
    {
        private static EfModel Instance;
        public static EfModel Init()
        {
            if (Instance == null)
                Instance = new EfModel();
            return Instance;
        }

        public EfModel()
        {
        }

        public EfModel(DbContextOptions<EfModel> options)
            : base(options)
        {
        }

        public virtual DbSet<Pacient> Pacients { get; set; } = null!;
        public virtual DbSet<Poseschenie> Poseschenies { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Vrachi> Vrachis { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=cfif31.ru;port=3306;database=ISPr22-43_AhmadulinTI_ProbDemTwo;user id=ISPr22-43_AhmadulinTI;password=ISPr22-43_AhmadulinTI;character set=utf8", ServerVersion.Parse("8.0.32-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Pacient>(entity =>
            {
                entity.HasKey(e => new { e.PacientId, e.PacientFio })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("Pacient");

                entity.HasIndex(e => e.PacientFio, "Keyy_idx");

                entity.Property(e => e.PacientId).ValueGeneratedOnAdd();

                entity.Property(e => e.PacientFio)
                    .HasMaxLength(450)
                    .HasColumnName("PacientFIO");

                entity.Property(e => e.PacientFam).HasMaxLength(45);

                entity.Property(e => e.PacientMaiil).HasMaxLength(100);

                entity.Property(e => e.PacientName).HasMaxLength(45);

                entity.Property(e => e.PacientOtch).HasMaxLength(45);
            });

            modelBuilder.Entity<Poseschenie>(entity =>
            {
                entity.HasKey(e => new { e.PoseschenieId, e.PosescheniePacient })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("Poseschenie");

                entity.HasIndex(e => e.PosescheniePacient, "Keyyy_idx");

                entity.Property(e => e.PoseschenieId).ValueGeneratedOnAdd();

                entity.Property(e => e.PosescheniePacient).HasMaxLength(250);

                entity.Property(e => e.PoseschenieKritetiyPos).HasMaxLength(45);

                entity.Property(e => e.PoseschenieTimePos).HasColumnType("time");

                entity.Property(e => e.PoseschenieTipPos).HasMaxLength(45);

                entity.Property(e => e.PoseschenieVrachFam).HasMaxLength(45);

                entity.Property(e => e.PoseschenieVrachName).HasMaxLength(45);

                entity.Property(e => e.PoseschenieVrachOtch).HasMaxLength(45);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.UserDoljnost).HasMaxLength(45);

                entity.Property(e => e.UserFam).HasMaxLength(45);

                entity.Property(e => e.UserLogin).HasMaxLength(45);

                entity.Property(e => e.UserName).HasMaxLength(45);

                entity.Property(e => e.UserOtch).HasMaxLength(45);

                entity.Property(e => e.UserPassword).HasMaxLength(45);
            });

            modelBuilder.Entity<Vrachi>(entity =>
            {
                entity.ToTable("Vrachi");

                entity.Property(e => e.VrachiDoljnost).HasMaxLength(40);

                entity.Property(e => e.VrachiFam).HasMaxLength(30);

                entity.Property(e => e.VrachiName).HasMaxLength(20);

                entity.Property(e => e.VrachiOtch).HasMaxLength(45);

                entity.Property(e => e.VrachiSmena).HasMaxLength(15);

                entity.Property(e => e.VrachiStatus).HasMaxLength(30);

                entity.Property(e => e.VrachiTipPos).HasMaxLength(40);

                entity.Property(e => e.VrachiVremya).HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Infrastructure.Models
{
    public partial class SqlDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public SqlDbContext()
        {
        }

        public SqlDbContext(DbContextOptions<SqlDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Activite> Activites { get; set; }
        public virtual DbSet<AttentesPersonnelle> AttentesPersonnelles { get; set; }
        public virtual DbSet<CeintureLombaire> CeintureLombaires { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Morphologie> Morphologies { get; set; }
        public virtual DbSet<Produit> Produits { get; set; }
        public virtual DbSet<ProduitActivite> ProduitActivites { get; set; }
        public virtual DbSet<ProduitAttentesPersonnelle> ProduitAttentesPersonnelles { get; set; }
        public virtual DbSet<ProduitMorphologie> ProduitMorphologies { get; set; }
        public virtual DbSet<ProduitProjet> ProduitProjets { get; set; }
        public virtual DbSet<ProduitSymptomatologie> ProduitSymptomatologies { get; set; }
        public virtual DbSet<Projet> Projets { get; set; }
        public virtual DbSet<Symptomatologie> Symptomatologies { get; set; }
        public virtual DbSet<VersionInfo> VersionInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=OrthomasterHHC2021;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "French_CI_AS");

            modelBuilder.Entity<Activite>(entity =>
            {
                entity.ToTable("Activite");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AttentesPersonnelle>(entity =>
            {
                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CeintureLombaire>(entity =>
            {
                entity.ToTable("CeintureLombaire");

                entity.Property(e => e.Couleur).HasMaxLength(255);

                entity.Property(e => e.HauteurDorsale).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.HauteurVentrale).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Taille).HasMaxLength(255);

                entity.HasOne(d => d.IdProduitNavigation)
                    .WithMany(p => p.CeintureLombaires)
                    .HasForeignKey(d => d.IdProduit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CeintureLombaire_IdProduit_Produit_Id");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.ToTable("Log");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Morphologie>(entity =>
            {
                entity.ToTable("Morphologie");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Produit>(entity =>
            {
                entity.ToTable("Produit");

                entity.Property(e => e.Fabricant)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ProduitActivite>(entity =>
            {
                entity.HasKey(e => new { e.IdActivite, e.IdProduit })
                    .HasName("PK_Produit-Activite_IdActivite_IdProduit");

                entity.ToTable("Produit-Activite");

                entity.HasOne(d => d.IdActiviteNavigation)
                    .WithMany(p => p.ProduitActivites)
                    .HasForeignKey(d => d.IdActivite)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Activite-Produit_ActiviteId_Activite_Id");

                entity.HasOne(d => d.IdProduitNavigation)
                    .WithMany(p => p.ProduitActivites)
                    .HasForeignKey(d => d.IdProduit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Activite-Produit_ProduitId_Produit_Id");
            });

            modelBuilder.Entity<ProduitAttentesPersonnelle>(entity =>
            {
                entity.HasKey(e => new { e.IdAttentesPersonnelles, e.IdProduit })
                    .HasName("PK_Produit-AttentesPersonnelles_IdAttentesPersonnelles_IdProduit");

                entity.ToTable("Produit-AttentesPersonnelles");

                entity.HasOne(d => d.IdAttentesPersonnellesNavigation)
                    .WithMany(p => p.ProduitAttentesPersonnelles)
                    .HasForeignKey(d => d.IdAttentesPersonnelles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_AttentesPersonnelles-Produit_AttentesPersonnellesId_AttentesPersonnelles_Id");

                entity.HasOne(d => d.IdProduitNavigation)
                    .WithMany(p => p.ProduitAttentesPersonnelles)
                    .HasForeignKey(d => d.IdProduit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_AttentesPersonnelles-Produit_ProduitId_Produit_Id");
            });

            modelBuilder.Entity<ProduitMorphologie>(entity =>
            {
                entity.HasKey(e => new { e.IdMorphologie, e.IdProduit })
                    .HasName("PK_Produit-Morphologie_IdMorphologie_IdProduit");

                entity.ToTable("Produit-Morphologie");

                entity.HasOne(d => d.IdMorphologieNavigation)
                    .WithMany(p => p.ProduitMorphologies)
                    .HasForeignKey(d => d.IdMorphologie)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Morphologie-Produit_MorphologieId_Morphologie_Id");

                entity.HasOne(d => d.IdProduitNavigation)
                    .WithMany(p => p.ProduitMorphologies)
                    .HasForeignKey(d => d.IdProduit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Morphologie-Produit_ProduitId_Produit_Id");
            });

            modelBuilder.Entity<ProduitProjet>(entity =>
            {
                entity.HasKey(e => new { e.IdProjet, e.IdProduit })
                    .HasName("PK_Produit-Projet_IdProjet_IdProduit");

                entity.ToTable("Produit-Projet");

                entity.HasOne(d => d.IdProduitNavigation)
                    .WithMany(p => p.ProduitProjets)
                    .HasForeignKey(d => d.IdProduit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Projet-Produit_ProduitId_Produit_Id");

                entity.HasOne(d => d.IdProjetNavigation)
                    .WithMany(p => p.ProduitProjets)
                    .HasForeignKey(d => d.IdProjet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Projet-Produit_ProjetId_Projet_Id");
            });

            modelBuilder.Entity<ProduitSymptomatologie>(entity =>
            {
                entity.HasKey(e => new { e.IdSymptomatologie, e.IdProduit })
                    .HasName("PK_Produit-Symptomatologie_IdSymptomatologie_IdProduit");

                entity.ToTable("Produit-Symptomatologie");

                entity.HasOne(d => d.IdProduitNavigation)
                    .WithMany(p => p.ProduitSymptomatologies)
                    .HasForeignKey(d => d.IdProduit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Symptomatologie-Produit_ProduitId_Produit_Id");

                entity.HasOne(d => d.IdSymptomatologieNavigation)
                    .WithMany(p => p.ProduitSymptomatologies)
                    .HasForeignKey(d => d.IdSymptomatologie)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Symptomatologie-Produit_SymptomatologieId_Symptomatologie_Id");
            });

            modelBuilder.Entity<Projet>(entity =>
            {
                entity.ToTable("Projet");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Symptomatologie>(entity =>
            {
                entity.ToTable("Symptomatologie");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<VersionInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VersionInfo");

                entity.HasIndex(e => e.Version, "UC_Version")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.AppliedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1024);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

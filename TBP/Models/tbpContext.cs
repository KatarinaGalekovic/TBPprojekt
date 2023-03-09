using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TBP.Models
{
    public partial class tbpContext : DbContext
    {
        public tbpContext()
        {
        }

        public tbpContext(DbContextOptions<tbpContext> options)
            : base(options)
        {
        }

        public virtual DbSet<biljeska> biljeska { get; set; }
        public virtual DbSet<dogadanja> dogadanja { get; set; }
        public virtual DbSet<doktor> doktor { get; set; }
        public virtual DbSet<doktor_pacijent> doktor_pacijent { get; set; }
        public virtual DbSet<faza> faza { get; set; }
        public virtual DbSet<ime_djeteta> ime_djeteta { get; set; }
        public virtual DbSet<komentar> komentar { get; set; }
        public virtual DbSet<korisnik> korisnik { get; set; }
        public virtual DbSet<mjerenje> mjerenje { get; set; }
        public virtual DbSet<obavljena_obveza> obavljena_obveza { get; set; }
        public virtual DbSet<obveza> obveza { get; set; }
        public virtual DbSet<pacijent> pacijent { get; set; }
        public virtual DbSet<pregled> pregled { get; set; }
        public virtual DbSet<svidanje_imena> svidanje_imena { get; set; }
        public virtual DbSet<tema> tema { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=trudnoca;Username=postgres;Password=bazepodataka;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<biljeska>(entity =>
            {
                entity.Property(e => e.opis)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.vrijeme_objave).HasDefaultValueSql("now()");

                entity.HasOne(d => d.id_doktoraNavigation)
                    .WithMany(p => p.biljeska)
                    .HasForeignKey(d => d.id_doktora)
                    .HasConstraintName("biljeska_id_doktora_fkey");

                entity.HasOne(d => d.id_pacijentaNavigation)
                    .WithMany(p => p.biljeska)
                    .HasForeignKey(d => d.id_pacijenta)
                    .HasConstraintName("biljeska_id_pacijenta_fkey");
            });

            modelBuilder.Entity<dogadanja>(entity =>
            {
                entity.HasKey(e => e.tjedan)
                    .HasName("dogadanja_pkey");

                entity.Property(e => e.tjedan).ValueGeneratedNever();

                entity.Property(e => e.tekst_dijete)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.tekst_majka)
                    .IsRequired()
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<doktor>(entity =>
            {
                entity.Property(e => e.id).ValueGeneratedNever();

                entity.Property(e => e.adresa_ordinacije).HasColumnType("character varying");

                entity.HasOne(d => d.idNavigation)
                    .WithOne(p => p.doktor)
                    .HasForeignKey<doktor>(d => d.id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doktor_id_fkey");
            });

            modelBuilder.Entity<doktor_pacijent>(entity =>
            {
                entity.HasKey(e => new { e.id_doktora, e.id_pacijenta, e.vrijedece_vrijeme })
                    .HasName("doktor_pacijent_pkey");

                entity.Property(e => e.vrijedece_vrijeme).HasDefaultValueSql("tsrange((now())::timestamp without time zone, 'infinity'::timestamp without time zone)");

                entity.HasOne(d => d.id_doktoraNavigation)
                    .WithMany(p => p.doktor_pacijent)
                    .HasForeignKey(d => d.id_doktora)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doktor_pacijent_id_doktora_fkey");

                entity.HasOne(d => d.id_pacijentaNavigation)
                    .WithMany(p => p.doktor_pacijent)
                    .HasForeignKey(d => d.id_pacijenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doktor_pacijent_id_pacijenta_fkey");
            });

            modelBuilder.Entity<faza>(entity =>
            {
                entity.Property(e => e.naziv)
                    .IsRequired()
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<ime_djeteta>(entity =>
            {
                entity.Property(e => e.ime)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.HasOne(d => d.id_pacijentaNavigation)
                    .WithMany(p => p.ime_djeteta)
                    .HasForeignKey(d => d.id_pacijenta)
                    .HasConstraintName("ime_djeteta_id_pacijenta_fkey");
            });

            modelBuilder.Entity<komentar>(entity =>
            {
                entity.Property(e => e.tekst).HasColumnType("character varying");

                entity.Property(e => e.vrijeme_objave).HasDefaultValueSql("now()");

                entity.HasOne(d => d.id_korisnikaNavigation)
                    .WithMany(p => p.komentar)
                    .HasForeignKey(d => d.id_korisnika)
                    .HasConstraintName("komentar_id_korisnika_fkey");

                entity.HasOne(d => d.id_temeNavigation)
                    .WithMany(p => p.komentar)
                    .HasForeignKey(d => d.id_teme)
                    .HasConstraintName("komentar_id_teme_fkey");
            });

            modelBuilder.Entity<korisnik>(entity =>
            {
                entity.HasIndex(e => e.email)
                    .HasName("korisnik_email_key")
                    .IsUnique();

                entity.HasIndex(e => e.korisnicko_ime)
                    .HasName("korisnik_korisnicko_ime_key")
                    .IsUnique();

                entity.Property(e => e.email).HasColumnType("character varying");

                entity.Property(e => e.ime)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.korisnicko_ime)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.lozinka)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.prezime)
                    .IsRequired()
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<mjerenje>(entity =>
            {
                entity.HasKey(e => new { e.id_pacijenta, e.vrijedece_vrijeme })
                    .HasName("mjerenje_pkey");

                entity.Property(e => e.vrijedece_vrijeme).HasDefaultValueSql("tsrange((now())::timestamp without time zone, 'infinity'::timestamp without time zone)");

                entity.Property(e => e.tezina).HasColumnType("numeric");

                entity.HasOne(d => d.id_pacijentaNavigation)
                    .WithMany(p => p.mjerenje)
                    .HasForeignKey(d => d.id_pacijenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mjerenje_id_pacijenta_fkey");
            });

            modelBuilder.Entity<obavljena_obveza>(entity =>
            {
                entity.HasKey(e => new { e.id_pacijenta, e.id_obveze })
                    .HasName("obavljena_obveza_pkey");

                entity.HasOne(d => d.id_obvezeNavigation)
                    .WithMany(p => p.obavljena_obveza)
                    .HasForeignKey(d => d.id_obveze)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("obavljena_obveza_id_obveze_fkey");

                entity.HasOne(d => d.id_pacijentaNavigation)
                    .WithMany(p => p.obavljena_obveza)
                    .HasForeignKey(d => d.id_pacijenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("obavljena_obveza_id_pacijenta_fkey");
            });

            modelBuilder.Entity<obveza>(entity =>
            {
                entity.Property(e => e.opis)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.HasOne(d => d.id_fazeNavigation)
                    .WithMany(p => p.obveza)
                    .HasForeignKey(d => d.id_faze)
                    .HasConstraintName("obveza_id_faze_fkey");

                entity.HasOne(d => d.id_pacijentaNavigation)
                    .WithMany(p => p.obveza)
                    .HasForeignKey(d => d.id_pacijenta)
                    .HasConstraintName("obveza_id_pacijenta_fkey");
            });

            modelBuilder.Entity<pacijent>(entity =>
            {
                entity.Property(e => e.id).ValueGeneratedNever();

                entity.Property(e => e.datum_rodenja).HasColumnType("date");

                entity.Property(e => e.datum_zadnje_menstruacije).HasColumnType("date");

                entity.Property(e => e.predvideni_datum_poroda).HasColumnType("date");

                entity.HasOne(d => d.idNavigation)
                    .WithOne(p => p.pacijent)
                    .HasForeignKey<pacijent>(d => d.id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pacijent_id_fkey");
            });

            modelBuilder.Entity<pregled>(entity =>
            {
                entity.Property(e => e.biljeska_doktora).HasColumnType("character varying");

                entity.HasOne(d => d.id_doktoraNavigation)
                    .WithMany(p => p.pregled)
                    .HasForeignKey(d => d.id_doktora)
                    .HasConstraintName("pregled_id_doktora_fkey");

                entity.HasOne(d => d.id_pacijentaNavigation)
                    .WithMany(p => p.pregled)
                    .HasForeignKey(d => d.id_pacijenta)
                    .HasConstraintName("pregled_id_pacijenta_fkey");
            });

            modelBuilder.Entity<svidanje_imena>(entity =>
            {
                entity.HasKey(e => new { e.id_pacijenta, e.id_imena })
                    .HasName("svidanje_imena_pkey");

                entity.HasOne(d => d.id_imenaNavigation)
                    .WithMany(p => p.svidanje_imena)
                    .HasForeignKey(d => d.id_imena)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("svidanje_imena_id_imena_fkey");

                entity.HasOne(d => d.id_pacijentaNavigation)
                    .WithMany(p => p.svidanje_imena)
                    .HasForeignKey(d => d.id_pacijenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("svidanje_imena_id_pacijenta_fkey");
            });

            modelBuilder.Entity<tema>(entity =>
            {
                entity.Property(e => e.naslov)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.sadrzaj)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.vrijeme_objave).HasDefaultValueSql("now()");

                entity.HasOne(d => d.id_korisnikaNavigation)
                    .WithMany(p => p.tema)
                    .HasForeignKey(d => d.id_korisnika)
                    .HasConstraintName("tema_id_korisnika_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

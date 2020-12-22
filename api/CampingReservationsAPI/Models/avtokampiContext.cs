using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CampingReservationsAPI.Models
{
    public partial class avtokampiContext : DbContext
    {
        public avtokampiContext()
        {
        }

        public avtokampiContext(DbContextOptions<avtokampiContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Rezervacije> Rezervacije { get; set; }
        public virtual DbSet<StatusRezervacije> StatusRezervacije { get; set; }
        public virtual DbSet<VrstaKampiranja> VrstaKampiranja { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Rezervacije>(entity =>
            {
                entity.HasKey(e => e.RezervacijaId)
                    .HasName("rezervacije_pkey");

                entity.ToTable("rezervacije");

                entity.HasIndex(e => e.StatusRezervacije)
                    .HasName("fk_rezervacije_status_rezervacije_idx");

                entity.HasIndex(e => e.VrstaKampiranja)
                    .HasName("fk_rezervacije_vrsta_kampiranja_idx");

                entity.Property(e => e.RezervacijaId)
                    .HasColumnName("rezervacija_id")
                    .HasDefaultValueSql("nextval('rezervacije_seq'::regclass)");

                entity.Property(e => e.Avtokamp).HasColumnName("avtokamp");

                entity.Property(e => e.KampirnoMesto).HasColumnName("kampirno_mesto");

                entity.Property(e => e.StatusRezervacije).HasColumnName("status_rezervacije");

                entity.Property(e => e.TrajanjeDo)
                    .HasColumnName("trajanje_do")
                    .HasColumnType("timestamp(0) without time zone");

                entity.Property(e => e.TrajanjeOd)
                    .HasColumnName("trajanje_od")
                    .HasColumnType("timestamp(0) without time zone");

                entity.Property(e => e.Uporabnik).HasColumnName("uporabnik");

                entity.Property(e => e.VrstaKampiranja).HasColumnName("vrsta_kampiranja");

                entity.HasOne(d => d.StatusRezervacijeNavigation)
                    .WithMany(p => p.Rezervacije)
                    .HasForeignKey(d => d.StatusRezervacije)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rezervacije_status_rezervacije1");

                entity.HasOne(d => d.VrstaKampiranjaNavigation)
                    .WithMany(p => p.Rezervacije)
                    .HasForeignKey(d => d.VrstaKampiranja)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rezervacije_vrsta_kampiranja1");
            });

            modelBuilder.Entity<StatusRezervacije>(entity =>
            {
                entity.ToTable("status_rezervacije");

                entity.Property(e => e.StatusRezervacijeId)
                    .HasColumnName("status_rezervacije_id");

                entity.Property(e => e.Naziv)
                    .HasColumnName("naziv")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<VrstaKampiranja>(entity =>
            {
                entity.ToTable("vrsta_kampiranja");

                entity.Property(e => e.VrstaKampiranjaId)
                    .HasColumnName("vrsta_kampiranja_id");

                entity.Property(e => e.Naziv)
                    .HasColumnName("naziv")
                    .HasMaxLength(45);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using Microsoft.EntityFrameworkCore;
using Universita.DAL.Entityes;

namespace Universita.DAL
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Iscritti>()
                .HasKey(sc => new { sc.StudenteMatricola, sc.CorsoId });

            modelBuilder.Entity<Iscritti>()
                .HasOne(sc => sc.Studente)
                .WithMany(s => s.Iscrizioni)
                .HasForeignKey(sc => sc.StudenteMatricola);

            modelBuilder.Entity<Iscritti>()
                .HasOne(sc => sc.Corso)
                .WithMany(c => c.Iscrizioni)
                .HasForeignKey(sc => sc.CorsoId);

            // Configurazione per Aula
            modelBuilder.Entity<Lezione>()
                .HasOne(l => l.Aula)
                .WithMany()
                .HasForeignKey(l => l.AulaId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configurazione per Docente
            modelBuilder.Entity<Lezione>()
                .HasOne(l => l.Docente)
                .WithMany()
                .HasForeignKey(l => l.DocenteId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configurazione per Corso
            modelBuilder.Entity<Lezione>()
                .HasOne(l => l.Corso)
                .WithMany()
                .HasForeignKey(l => l.CorsoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
        public DbSet<Studente> Studenti { get; set; }
        public DbSet<Corso> Corsi { get; set; }
        public DbSet<Iscritti> Iscrizioni { get; set; }
        public DbSet<Lezione> Lezioni { get; set; }
        public DbSet<Aula> Aule {  get; set; }
        public DbSet<Docente> Docenti { get; set; }
    }
}

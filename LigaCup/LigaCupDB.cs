using Microsoft.EntityFrameworkCore;

namespace LigaCup {
    public class LigaCupDB : DbContext {

        public LigaCupDB() { }
        public DbSet<Igralec> Igralec { get; set; }
        public DbSet<Ekipa> Ekipa { get; set; }
        public DbSet<Lestvica> Lestvica { get; set; }
        public DbSet<Razpored> Razpored { get; set; }
        public DbSet<Tekma> Tekma { get; set; }
        public DbSet<Trening> Trening { get; set; }
        public DbSet<Uporabnik> Uporabnik { get; set; }
        public DbSet<Zapisnik> Zapisnik { get; set; }

        public LigaCupDB(DbContextOptions<LigaCupDB> options) : base(options) {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            options.UseSqlite("Data Source=app.db");
        }


    }
}

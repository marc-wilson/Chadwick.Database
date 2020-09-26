using Chadwick.Database.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Chadwick.Database
{
    public class ChadwickDbContext : IdentityDbContext<ChadwickUser>
    {
        public DbSet<AllStarFull> AllStarFull { get; set; }
        public DbSet<Appearance> Appearances { get; set; }
        public DbSet<AwardsManager> AwardsManagers { get; set; }
        public DbSet<AwardsPlayer> AwardsPlayers { get; set; }
        public DbSet<AwardsShareManager> AwardsShareManagers { get; set; }
        public DbSet<AwardsSharePlayer> AwardsSharePlayers { get; set; }
        public DbSet<Batting> Batting { get; set; }
        public DbSet<BattingPost> BattingPost { get; set; }
        public DbSet<CollegePlaying> CollegePlaying { get; set; }
        public DbSet<Fielding> Fielding { get; set; }
        public DbSet<FieldingOF> FieldingOF { get; set; }
        public DbSet<FieldingOFSplit> FieldingOFSplit { get; set; }
        public DbSet<FieldingPost> FieldingPost { get; set; }
        public DbSet<HallOfFame> HallOfFame { get; set; }
        public DbSet<HomeGames> HomeGames { get; set; }
        public DbSet<Managers> Managers { get; set; }
        public DbSet<ManagersHalf> ManagersHalf { get; set; }
        public DbSet<Parks> Parks { get; set; }
        public DbSet<People> People { get; set; }
        public DbSet<Pitching> Pitching { get; set; }
        public DbSet<PitchingPost> PitchingPost { get; set; }
        public DbSet<Salaries> Salaries { get; set; }
        public DbSet<Schools> Schools { get; set; }
        public DbSet<SeriesPost> SeriesPost { get; set; }
        public DbSet<Teams> Teams { get; set; }
        public DbSet<TeamsFranchises> TeamsFranchises { get; set; }
        public DbSet<TeamsHalf> TeamsHalf { get; set; }
        public DbSet<CommitProcessorJob> CommitProcessorJobs { get; set; }
        public DbSet<CsvProcessorJob> CsvProcessorJobs { get; set; }
        public DbSet<SearchIndexProcessorJobs> SearchIndexProcessorJobs { get; set; }
        public DbSet<ChadwickTables> ChadwickTables { get; set; }
        public DbSet<ChadwickFields> ChadwickFields { get; set; }

        public ChadwickDbContext(DbContextOptions options) : base(options) { }

        public ChadwickDbContext() : base(new DbContextOptionsBuilder()
            .UseSqlServer(
                new ConfigurationBuilder()
                    .AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.example.json"))
                    .Build()["ConnectionStrings:DefaultConnection"]).Options)
        {
        }
    }
}
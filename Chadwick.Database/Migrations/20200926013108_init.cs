using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Chadwick.Database.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AllStarFull",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<string>(nullable: true),
                    YearId = table.Column<int>(nullable: true),
                    GameNumber = table.Column<int>(nullable: true),
                    GameId = table.Column<string>(nullable: true),
                    TeamId = table.Column<string>(nullable: true),
                    LeagueId = table.Column<string>(nullable: true),
                    GamesPlayed = table.Column<int>(nullable: true),
                    StartingPosition = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllStarFull", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Appearances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YearId = table.Column<int>(nullable: false),
                    TeamId = table.Column<string>(nullable: true),
                    LeagueId = table.Column<string>(nullable: true),
                    PlayerId = table.Column<string>(nullable: true),
                    TotalGamesPlayed = table.Column<int>(nullable: true),
                    GamesStarted = table.Column<int>(nullable: true),
                    GamesBatted = table.Column<int>(nullable: true),
                    GamesDefense = table.Column<int>(nullable: true),
                    GamesAsPitcher = table.Column<int>(nullable: true),
                    GamesAsCatcher = table.Column<int>(nullable: true),
                    GamesAsFirstBaseman = table.Column<int>(nullable: true),
                    GamesAsSecondBaseman = table.Column<int>(nullable: true),
                    GamesAsThirdBaseman = table.Column<int>(nullable: true),
                    GamesAsShortStop = table.Column<int>(nullable: true),
                    GamesAsLeftFielder = table.Column<int>(nullable: true),
                    GamesAsCenterFielder = table.Column<int>(nullable: true),
                    GamesAsRightFielder = table.Column<int>(nullable: true),
                    GamesAsOutfielder = table.Column<int>(nullable: true),
                    GamesAsDesignatedHitter = table.Column<int>(nullable: true),
                    GamesAsPinchHitter = table.Column<int>(nullable: true),
                    GamesAsPinchRunner = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appearances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AwardsManagers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<string>(nullable: true),
                    AwardName = table.Column<string>(nullable: true),
                    YearId = table.Column<int>(nullable: false),
                    LeagueId = table.Column<string>(nullable: true),
                    Tie = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AwardsManagers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AwardsPlayers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<string>(nullable: true),
                    AwardName = table.Column<string>(nullable: true),
                    YearId = table.Column<int>(nullable: false),
                    LeagueId = table.Column<string>(nullable: true),
                    Tie = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AwardsPlayers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AwardsShareManagers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AwardName = table.Column<string>(nullable: true),
                    YearId = table.Column<int>(nullable: false),
                    LeagueId = table.Column<string>(nullable: true),
                    PlayerId = table.Column<string>(nullable: true),
                    PointsWon = table.Column<int>(nullable: true),
                    PointsMax = table.Column<int>(nullable: true),
                    VotesFirst = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AwardsShareManagers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AwardsSharePlayers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AwardName = table.Column<string>(nullable: true),
                    YearId = table.Column<int>(nullable: false),
                    LeagueId = table.Column<string>(nullable: true),
                    PlayerId = table.Column<string>(nullable: true),
                    PointsWon = table.Column<decimal>(nullable: true),
                    PointsMax = table.Column<int>(nullable: true),
                    VotesFirst = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AwardsSharePlayers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Batting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<string>(nullable: true),
                    YearId = table.Column<int>(nullable: false),
                    Stint = table.Column<int>(nullable: true),
                    TeamId = table.Column<string>(nullable: true),
                    LeagueId = table.Column<string>(nullable: true),
                    Games = table.Column<int>(nullable: true),
                    AtBats = table.Column<int>(nullable: true),
                    Runs = table.Column<int>(nullable: true),
                    Hits = table.Column<int>(nullable: true),
                    Doubles = table.Column<int>(nullable: true),
                    Triples = table.Column<int>(nullable: true),
                    HomeRuns = table.Column<int>(nullable: true),
                    RunsBattedIn = table.Column<int>(nullable: true),
                    StolenBases = table.Column<int>(nullable: true),
                    CaughtStealing = table.Column<int>(nullable: true),
                    BaseOnBalls = table.Column<int>(nullable: true),
                    Strikeouts = table.Column<int>(nullable: true),
                    IntentionalWalks = table.Column<int>(nullable: true),
                    HitByPitch = table.Column<int>(nullable: true),
                    SacrificeHits = table.Column<int>(nullable: true),
                    SacrificeFlies = table.Column<int>(nullable: true),
                    GroundedIntoDoublePlays = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BattingPost",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YearId = table.Column<int>(nullable: false),
                    LevelOfPlayoffs = table.Column<string>(nullable: true),
                    PlayerId = table.Column<string>(nullable: true),
                    TeamId = table.Column<string>(nullable: true),
                    LeagueId = table.Column<string>(nullable: true),
                    Games = table.Column<int>(nullable: true),
                    AtBats = table.Column<int>(nullable: true),
                    Runs = table.Column<int>(nullable: true),
                    Hits = table.Column<int>(nullable: true),
                    Doubles = table.Column<int>(nullable: true),
                    Triples = table.Column<int>(nullable: true),
                    HomeRuns = table.Column<int>(nullable: true),
                    RunsBattedIn = table.Column<int>(nullable: true),
                    StolenBases = table.Column<int>(nullable: true),
                    CaughtStealing = table.Column<int>(nullable: true),
                    BaseOnBalls = table.Column<int>(nullable: true),
                    Strikeouts = table.Column<int>(nullable: true),
                    IntentionalWalks = table.Column<int>(nullable: true),
                    HitByPitch = table.Column<int>(nullable: true),
                    Sacrifices = table.Column<int>(nullable: true),
                    SacrificeFlies = table.Column<int>(nullable: true),
                    GroundedIntoDoublePlays = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattingPost", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChadwickTables",
                columns: table => new
                {
                    TableId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Alias = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChadwickTables", x => x.TableId);
                });

            migrationBuilder.CreateTable(
                name: "CollegePlaying",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<string>(nullable: true),
                    SchoolId = table.Column<string>(nullable: true),
                    YearId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollegePlaying", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommitProcessorJobs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommitHash = table.Column<string>(nullable: true),
                    Started = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    FilesToProcessCount = table.Column<int>(nullable: false),
                    Finished = table.Column<DateTime>(nullable: false),
                    CompletedCount = table.Column<int>(nullable: false),
                    FailCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommitProcessorJobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fielding",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<string>(nullable: true),
                    YearId = table.Column<int>(nullable: false),
                    Stint = table.Column<int>(nullable: true),
                    TeamId = table.Column<string>(nullable: true),
                    LeagueId = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Games = table.Column<int>(nullable: true),
                    GameStarts = table.Column<int>(nullable: true),
                    TimePlayedInFieldExpressedAsOuts = table.Column<int>(nullable: true),
                    Putouts = table.Column<int>(nullable: true),
                    Assists = table.Column<int>(nullable: true),
                    Errors = table.Column<int>(nullable: true),
                    DoublePlays = table.Column<int>(nullable: true),
                    PassedBalls = table.Column<int>(nullable: true),
                    WildPitches = table.Column<int>(nullable: true),
                    StolenBases = table.Column<int>(nullable: true),
                    CaughtStealing = table.Column<int>(nullable: true),
                    ZoneRating = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fielding", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FieldingOF",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<string>(nullable: true),
                    YearId = table.Column<int>(nullable: false),
                    Stint = table.Column<int>(nullable: true),
                    GamesPlayedInLeftField = table.Column<int>(nullable: true),
                    GamesPlayedInCenterField = table.Column<int>(nullable: true),
                    GamesPlayedInRightField = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FieldingOF", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FieldingOFSplit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<string>(nullable: true),
                    YearId = table.Column<int>(nullable: false),
                    Stint = table.Column<int>(nullable: true),
                    TeamId = table.Column<string>(nullable: true),
                    LeagueId = table.Column<string>(nullable: true),
                    Games = table.Column<int>(nullable: true),
                    GameStarts = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FieldingOFSplit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FieldingPost",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<string>(nullable: true),
                    YearId = table.Column<int>(nullable: false),
                    TeamId = table.Column<string>(nullable: true),
                    LeagueId = table.Column<string>(nullable: true),
                    LevelOfPlayoffs = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Games = table.Column<int>(nullable: true),
                    GameStarts = table.Column<int>(nullable: true),
                    TimePlayedInFieldExpressedAsOuts = table.Column<int>(nullable: true),
                    Putouts = table.Column<int>(nullable: true),
                    Assists = table.Column<int>(nullable: true),
                    Errors = table.Column<int>(nullable: true),
                    DoublePlays = table.Column<int>(nullable: true),
                    TriplePlays = table.Column<int>(nullable: true),
                    PassedBalls = table.Column<int>(nullable: true),
                    StolenBases = table.Column<int>(nullable: true),
                    CaughtStealing = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FieldingPost", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HallOfFame",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<string>(nullable: true),
                    YearId = table.Column<int>(nullable: false),
                    VotedByMethod = table.Column<string>(nullable: true),
                    TotalBallotsCast = table.Column<int>(nullable: true),
                    VotesNeeded = table.Column<int>(nullable: true),
                    TotalVotesReceived = table.Column<int>(nullable: true),
                    Inducted = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    NeededNote = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HallOfFame", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeGames",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YearKey = table.Column<int>(nullable: false),
                    LeagueKey = table.Column<string>(nullable: true),
                    TeamKey = table.Column<string>(nullable: true),
                    ParkKey = table.Column<string>(nullable: true),
                    SpanFirst = table.Column<DateTime>(nullable: false),
                    SpanLast = table.Column<DateTime>(nullable: false),
                    Games = table.Column<int>(nullable: true),
                    Openings = table.Column<int>(nullable: true),
                    Attendance = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeGames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<string>(nullable: true),
                    YearId = table.Column<int>(nullable: false),
                    TeamId = table.Column<string>(nullable: true),
                    LeagueId = table.Column<string>(nullable: true),
                    ManagerialOrder = table.Column<int>(nullable: true),
                    Games = table.Column<int>(nullable: true),
                    Wins = table.Column<int>(nullable: true),
                    Losses = table.Column<int>(nullable: true),
                    Rank = table.Column<int>(nullable: true),
                    PlayerManager = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManagersHalf",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<string>(nullable: true),
                    YearId = table.Column<int>(nullable: false),
                    TeamId = table.Column<string>(nullable: true),
                    LeagueId = table.Column<string>(nullable: true),
                    ManagerialOrder = table.Column<int>(nullable: true),
                    Half = table.Column<int>(nullable: true),
                    Games = table.Column<int>(nullable: true),
                    Wins = table.Column<int>(nullable: true),
                    Losses = table.Column<int>(nullable: true),
                    Rank = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagersHalf", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParkKey = table.Column<string>(nullable: true),
                    ParkName = table.Column<string>(nullable: true),
                    ParkAlias = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<string>(nullable: true),
                    BirthYear = table.Column<int>(nullable: true),
                    BirthMonth = table.Column<int>(nullable: true),
                    BirthDay = table.Column<int>(nullable: true),
                    BirthCountry = table.Column<string>(nullable: true),
                    BirthState = table.Column<string>(nullable: true),
                    BirthCity = table.Column<string>(nullable: true),
                    DeathYear = table.Column<int>(nullable: true),
                    DeathMonth = table.Column<int>(nullable: true),
                    DeathDay = table.Column<int>(nullable: true),
                    DeathCountry = table.Column<string>(nullable: true),
                    DeathState = table.Column<string>(nullable: true),
                    DeathCity = table.Column<string>(nullable: true),
                    NameFirst = table.Column<string>(nullable: true),
                    NameLast = table.Column<string>(nullable: true),
                    NameGiven = table.Column<string>(nullable: true),
                    Weight = table.Column<int>(nullable: true),
                    Height = table.Column<int>(nullable: true),
                    Bats = table.Column<string>(nullable: true),
                    Throws = table.Column<string>(nullable: true),
                    Debut = table.Column<DateTime>(nullable: true),
                    FinalGame = table.Column<DateTime>(nullable: true),
                    RetrosheetId = table.Column<string>(nullable: true),
                    BaseballReferenceId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pitching",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<string>(nullable: true),
                    YearId = table.Column<int>(nullable: false),
                    Stint = table.Column<int>(nullable: false),
                    TeamId = table.Column<string>(nullable: true),
                    LeagueId = table.Column<string>(nullable: true),
                    Wins = table.Column<int>(nullable: true),
                    Losses = table.Column<int>(nullable: true),
                    Games = table.Column<int>(nullable: true),
                    GameStarts = table.Column<int>(nullable: true),
                    CompleteGames = table.Column<int>(nullable: true),
                    Shutouts = table.Column<int>(nullable: true),
                    Saves = table.Column<int>(nullable: true),
                    OutsPitched = table.Column<int>(nullable: true),
                    Hits = table.Column<int>(nullable: true),
                    EarnedRuns = table.Column<int>(nullable: true),
                    HomeRuns = table.Column<int>(nullable: true),
                    Walks = table.Column<int>(nullable: true),
                    Strikeouts = table.Column<int>(nullable: true),
                    OpponentBattingAverage = table.Column<decimal>(nullable: true),
                    EarnedRunAverage = table.Column<decimal>(nullable: true),
                    IntentionalWalks = table.Column<int>(nullable: true),
                    WildPitches = table.Column<int>(nullable: true),
                    BattersHitByPitch = table.Column<int>(nullable: true),
                    Balks = table.Column<int>(nullable: true),
                    BattersFaced = table.Column<int>(nullable: true),
                    GamesFinished = table.Column<int>(nullable: true),
                    RunsAllowed = table.Column<int>(nullable: true),
                    SacrificeHitsAllowed = table.Column<int>(nullable: true),
                    SacrificeFliesAllowed = table.Column<int>(nullable: true),
                    GroundedIntoDoublePlays = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pitching", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PitchingPost",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<string>(nullable: true),
                    YearId = table.Column<int>(nullable: false),
                    LevelOfPlayoffs = table.Column<string>(nullable: true),
                    TeamId = table.Column<string>(nullable: true),
                    LeagueId = table.Column<string>(nullable: true),
                    Wins = table.Column<int>(nullable: true),
                    Losses = table.Column<int>(nullable: true),
                    Games = table.Column<int>(nullable: true),
                    GameStarts = table.Column<int>(nullable: true),
                    CompleteGames = table.Column<int>(nullable: true),
                    Shutouts = table.Column<int>(nullable: true),
                    Saves = table.Column<int>(nullable: true),
                    OutsPitched = table.Column<int>(nullable: true),
                    Hits = table.Column<int>(nullable: true),
                    EarnedRuns = table.Column<int>(nullable: true),
                    HomeRuns = table.Column<int>(nullable: true),
                    Walks = table.Column<int>(nullable: true),
                    Strikeouts = table.Column<int>(nullable: true),
                    OpponentBattingAverage = table.Column<decimal>(nullable: true),
                    EarnedRunsAverage = table.Column<string>(nullable: true),
                    IntentionalWalks = table.Column<int>(nullable: true),
                    WildPitches = table.Column<int>(nullable: true),
                    BattersHitByPitch = table.Column<int>(nullable: true),
                    Balks = table.Column<int>(nullable: true),
                    BattersFaced = table.Column<int>(nullable: true),
                    GamesFinished = table.Column<int>(nullable: true),
                    RunsAllowed = table.Column<int>(nullable: true),
                    SacrificeHitsAllowed = table.Column<int>(nullable: true),
                    SacrificeFliesAllowed = table.Column<int>(nullable: true),
                    GroundedIntoDoublePlays = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PitchingPost", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Salaries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YearId = table.Column<int>(nullable: false),
                    TeamId = table.Column<string>(nullable: true),
                    LeagueId = table.Column<string>(nullable: true),
                    PlayerId = table.Column<string>(nullable: true),
                    Salary = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salaries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SearchIndexProcessorJobs",
                columns: table => new
                {
                    IndexId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndexName = table.Column<string>(nullable: true),
                    Started = table.Column<DateTime>(nullable: false),
                    Finished = table.Column<DateTime>(nullable: false),
                    DocumentsProcessed = table.Column<long>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    StorageSize = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchIndexProcessorJobs", x => x.IndexId);
                });

            migrationBuilder.CreateTable(
                name: "SeriesPost",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YearId = table.Column<int>(nullable: false),
                    LevelOfPlayoffs = table.Column<string>(nullable: true),
                    WinningTeamId = table.Column<string>(nullable: true),
                    WinningLeagueId = table.Column<string>(nullable: true),
                    LoserTeamId = table.Column<string>(nullable: true),
                    LoserLeagueId = table.Column<string>(nullable: true),
                    Wins = table.Column<int>(nullable: true),
                    Losses = table.Column<int>(nullable: true),
                    Ties = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriesPost", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeagueId = table.Column<string>(nullable: true),
                    TeamId = table.Column<string>(nullable: true),
                    FranchiseId = table.Column<string>(nullable: true),
                    DivisionId = table.Column<string>(nullable: true),
                    Rank = table.Column<int>(nullable: true),
                    Games = table.Column<int>(nullable: true),
                    HomeGames = table.Column<int>(nullable: true),
                    Wins = table.Column<int>(nullable: true),
                    Losses = table.Column<int>(nullable: true),
                    DivisionWin = table.Column<string>(nullable: true),
                    WildCardWinner = table.Column<string>(nullable: true),
                    LeagueWin = table.Column<string>(nullable: true),
                    WorldSeriesWin = table.Column<string>(nullable: true),
                    Runs = table.Column<int>(nullable: true),
                    AtBats = table.Column<int>(nullable: true),
                    Hits = table.Column<int>(nullable: true),
                    Doubles = table.Column<int>(nullable: true),
                    Triples = table.Column<int>(nullable: true),
                    HomeRuns = table.Column<int>(nullable: true),
                    Walks = table.Column<int>(nullable: true),
                    Strikeouts = table.Column<int>(nullable: true),
                    StolenBases = table.Column<int>(nullable: true),
                    CaughtStealing = table.Column<int>(nullable: true),
                    HitByPitch = table.Column<int>(nullable: true),
                    SacrificeFlies = table.Column<int>(nullable: true),
                    RunsAllowed = table.Column<int>(nullable: true),
                    EarnedRunsAllowed = table.Column<int>(nullable: true),
                    EarnedRunsAverage = table.Column<string>(nullable: true),
                    CompleteGames = table.Column<int>(nullable: true),
                    Shutouts = table.Column<int>(nullable: true),
                    Saves = table.Column<int>(nullable: true),
                    OutsPitched = table.Column<int>(nullable: true),
                    HitsAllowed = table.Column<int>(nullable: true),
                    HomeRunsAllowed = table.Column<int>(nullable: true),
                    WalksAllowed = table.Column<int>(nullable: true),
                    StrikeoutsByPitchers = table.Column<int>(nullable: true),
                    Errors = table.Column<int>(nullable: true),
                    DoublePlays = table.Column<int>(nullable: true),
                    FieldingPercentage = table.Column<decimal>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Ballpark = table.Column<string>(nullable: true),
                    Attendance = table.Column<int>(nullable: true),
                    ThreeYearParkFactorForBatters = table.Column<int>(nullable: true),
                    ThreeYearParkFactorForPitchers = table.Column<int>(nullable: true),
                    BaseballReferenceTeamId = table.Column<string>(nullable: true),
                    LahmanTeamId = table.Column<string>(nullable: true),
                    RetrosheetTeamId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamsFranchises",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FranchiseId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Active = table.Column<string>(nullable: true),
                    NationalAssociationFranchiseId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamsFranchises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamsHalf",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YearId = table.Column<int>(nullable: false),
                    LeagueId = table.Column<string>(nullable: true),
                    TeamId = table.Column<string>(nullable: true),
                    Half = table.Column<int>(nullable: true),
                    DivisionId = table.Column<string>(nullable: true),
                    DivisionWin = table.Column<string>(nullable: true),
                    Rank = table.Column<int>(nullable: true),
                    Games = table.Column<int>(nullable: true),
                    Wins = table.Column<int>(nullable: true),
                    Losses = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamsHalf", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChadwickFields",
                columns: table => new
                {
                    FieldId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CamelCaseName = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    FriendlyName = table.Column<string>(nullable: true),
                    ChadwickName = table.Column<string>(nullable: true),
                    AbbreviatedName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TableId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChadwickFields", x => x.FieldId);
                    table.ForeignKey(
                        name: "FK_ChadwickFields_ChadwickTables_TableId",
                        column: x => x.TableId,
                        principalTable: "ChadwickTables",
                        principalColumn: "TableId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CsvProcessorJobs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommitJobId = table.Column<int>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    Finished = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Started = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CsvProcessorJobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CsvProcessorJobs_CommitProcessorJobs_CommitJobId",
                        column: x => x.CommitJobId,
                        principalTable: "CommitProcessorJobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ChadwickFields_TableId",
                table: "ChadwickFields",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_CsvProcessorJobs_CommitJobId",
                table: "CsvProcessorJobs",
                column: "CommitJobId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllStarFull");

            migrationBuilder.DropTable(
                name: "Appearances");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AwardsManagers");

            migrationBuilder.DropTable(
                name: "AwardsPlayers");

            migrationBuilder.DropTable(
                name: "AwardsShareManagers");

            migrationBuilder.DropTable(
                name: "AwardsSharePlayers");

            migrationBuilder.DropTable(
                name: "Batting");

            migrationBuilder.DropTable(
                name: "BattingPost");

            migrationBuilder.DropTable(
                name: "ChadwickFields");

            migrationBuilder.DropTable(
                name: "CollegePlaying");

            migrationBuilder.DropTable(
                name: "CsvProcessorJobs");

            migrationBuilder.DropTable(
                name: "Fielding");

            migrationBuilder.DropTable(
                name: "FieldingOF");

            migrationBuilder.DropTable(
                name: "FieldingOFSplit");

            migrationBuilder.DropTable(
                name: "FieldingPost");

            migrationBuilder.DropTable(
                name: "HallOfFame");

            migrationBuilder.DropTable(
                name: "HomeGames");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropTable(
                name: "ManagersHalf");

            migrationBuilder.DropTable(
                name: "Parks");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Pitching");

            migrationBuilder.DropTable(
                name: "PitchingPost");

            migrationBuilder.DropTable(
                name: "Salaries");

            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropTable(
                name: "SearchIndexProcessorJobs");

            migrationBuilder.DropTable(
                name: "SeriesPost");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "TeamsFranchises");

            migrationBuilder.DropTable(
                name: "TeamsHalf");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ChadwickTables");

            migrationBuilder.DropTable(
                name: "CommitProcessorJobs");
        }
    }
}

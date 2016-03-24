namespace AccaBetApi.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AccaBetApi.Models.AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(AccaBetApi.Models.AppContext context)
        {
            List<Country> countries = new List<Country>() {
                new Country {CountryName = "England" },
                new Country {CountryName = "Spain" },
                new Country {CountryName = "Germany" },
                new Country {CountryName = "Italy" },
                new Country {CountryName = "France" },
            };

            countries.ForEach(c => context.Countries.Add(c));
            context.SaveChanges();

            List<League> leagues = new List<League>() {
                new League { ID = 398, LeagueName = "Premier League", LeagueIcon = "~/Content/images/premier_league.png", CountryID = countries.FirstOrDefault(c=> c.CountryName == "England").ID  },
                new League { ID = 399, LeagueName = "La Liga", LeagueIcon = "~/Content/images/la_liga.png", CountryID = countries.FirstOrDefault(c=> c.CountryName == "Spain").ID  },
                new League { ID = 394, LeagueName = "Bundesliga", LeagueIcon = "~/Content/images/bundesliga.gif", CountryID = countries.FirstOrDefault(c=> c.CountryName == "Germany").ID  },
                new League { ID = 401, LeagueName = "Serie A", LeagueIcon = "~/Content/images/serie_a.png", CountryID = countries.FirstOrDefault(c=> c.CountryName == "Italy").ID  },
                new League { ID = 396, LeagueName = "Ligue 1", LeagueIcon = "~/Content/images/ligue1.jpg", CountryID = countries.FirstOrDefault(c=> c.CountryName == "France").ID  },
            };

            leagues.ForEach(l => context.Leagues.Add(l));
            context.SaveChanges();

            List<Team> teams = new List<Team>() {
                new Team { ID = 338, TeamName = "Leicester", LeagueID = 398 },
                new Team { ID = 73, TeamName = "Tottenham", LeagueID = 398 },
                new Team { ID = 57, TeamName = "Arsenal", LeagueID = 398 },
                new Team { ID = 65, TeamName = "Manchester City", LeagueID = 398 },
                new Team { ID = 563, TeamName = "WestHam", LeagueID = 398 },
                new Team { ID = 66, TeamName = "Manchester United", LeagueID = 398 },
                new Team { ID = 340, TeamName = "Southampton", LeagueID = 398 },
                new Team { ID = 70, TeamName = "Stoke City", LeagueID = 398 },
                new Team { ID = 64, TeamName = "Liverpool", LeagueID = 398 },
                new Team { ID = 61, TeamName = "Chelsea", LeagueID = 398 },
                new Team { ID = 74, TeamName = "WestBrom", LeagueID = 398 },
                new Team { ID = 62, TeamName = "Everton", LeagueID = 398 },
                new Team { ID = 1044, TeamName = "Bournemouth", LeagueID = 398 },
                new Team { ID = 346, TeamName = "Watford", LeagueID = 398 },
                new Team { ID = 72, TeamName = "Swansea", LeagueID = 398 },
                new Team { ID = 354, TeamName = "CrystalPalace", LeagueID = 398 },
                new Team { ID = 68, TeamName = "Norwich", LeagueID = 398 },
                new Team { ID = 71, TeamName = "Sunderland", LeagueID = 398 },
                new Team { ID = 67, TeamName = "NewcastleUtd", LeagueID = 398 },
                new Team { ID = 58, TeamName = "AstonVilla", LeagueID = 398 }
            };

            teams.ForEach(t => context.Teams.Add(t));
            context.SaveChanges();
        }
    }
}


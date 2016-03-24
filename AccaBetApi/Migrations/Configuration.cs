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
                new League { ID = 1204, LeagueName = "Premier League", LeagueIcon = "~/Content/images/premier_league.png", CountryID = countries.FirstOrDefault(c=> c.CountryName == "England").ID  },
                new League { ID = 1205, LeagueName = "Championship", LeagueIcon = "~/Content/images/eng_champ.png", CountryID = countries.FirstOrDefault(c=> c.CountryName == "England").ID  },
                new League { ID = 1399, LeagueName = "La Liga", LeagueIcon = "~/Content/images/la_liga.png", CountryID = countries.FirstOrDefault(c=> c.CountryName == "Spain").ID  },
                new League { ID = 1229, LeagueName = "Bundesliga", LeagueIcon = "~/Content/images/bundesliga.gif", CountryID = countries.FirstOrDefault(c=> c.CountryName == "Germany").ID  },
                new League { ID = 1269, LeagueName = "Serie A", LeagueIcon = "~/Content/images/serie_a.png", CountryID = countries.FirstOrDefault(c=> c.CountryName == "Italy").ID  },
                new League { ID = 1221, LeagueName = "Ligue 1", LeagueIcon = "~/Content/images/ligue1.jpg", CountryID = countries.FirstOrDefault(c=> c.CountryName == "France").ID  },
            };

            leagues.ForEach(l => context.Leagues.Add(l));
            context.SaveChanges();

            List<Team> teams = new List<Team>() {
                new Team { ID = 9240, TeamName = "Leicester", LeagueID = 1204 },
                new Team { ID = 9406, TeamName = "Tottenham", LeagueID = 1204 },
                new Team { ID = 9002, TeamName = "Arsenal", LeagueID = 1204 },
                new Team { ID = 9259, TeamName = "Manchester City", LeagueID = 1204 },
                new Team { ID = 9427, TeamName = "WestHam", LeagueID = 1204 },
                new Team { ID = 9260, TeamName = "Manchester United", LeagueID = 1204 },
                new Team { ID = 9363, TeamName = "Southampton", LeagueID = 1204 },
                new Team { ID = 9378, TeamName = "Stoke City", LeagueID = 1204 },
                new Team { ID = 9249, TeamName = "Liverpool", LeagueID = 1204 },
                new Team { ID = 9092, TeamName = "Chelsea", LeagueID = 1204 },
                new Team { ID = 9426, TeamName = "WestBrom", LeagueID = 1204 },
                new Team { ID = 9158, TeamName = "Everton", LeagueID = 1204 },
                new Team { ID = 9053, TeamName = "Bournemouth", LeagueID = 1204 },
                new Team { ID = 9423, TeamName = "Watford", LeagueID = 1204 },
                new Team { ID = 9387, TeamName = "Swansea", LeagueID = 1204 },
                new Team { ID = 9127, TeamName = "CrystalPalace", LeagueID = 1204 },
                new Team { ID = 9296, TeamName = "Norwich", LeagueID = 1204 },
                new Team { ID = 9384, TeamName = "Sunderland", LeagueID = 1204 },
                new Team { ID = 9287, TeamName = "NewcastleUtd", LeagueID = 1204 },
                new Team { ID = 9008, TeamName = "AstonVilla", LeagueID = 1204 }
            };

            teams.ForEach(t => context.Teams.Add(t));
            context.SaveChanges();
        }
    }
}


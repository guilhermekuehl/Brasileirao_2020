using System.Collections.Generic;
using Domain;
using Xunit;

namespace Tests
{
    public class CBFTest
    {
        [Fact]
       public void Should_return_true_when_eight_teams_are_registered()
       {
            var cbf = new CBF();
            var palmeiras = new Team("Palmeiras", 0);
            var flamengo = new Team("Flamengo", 0);
            var fluminense = new Team("Fluminense", 0);
            var corinthians = new Team("Corinthians", 0);
            var chapecoense = new Team("Chapecoense", 0);
            var atleticoMG = new Team("Atlético - MG", 0);
            var vasco = new Team("Vasco", 0);
            var saoPaulo = new Team("São Paulo", 0);

            var teams = new List<Team>{palmeiras, flamengo, fluminense, corinthians, chapecoense, atleticoMG, vasco, saoPaulo};

            var registered = cbf.RegisterOfTeams(teams, "CBF");

            Assert.True(registered);
            Assert.Equal(8, teams.Count);
       }

       [Fact]
       public void Should_return_false_when_minus_of_eight_teams_are_registered()
       {
            var cbf = new CBF();
            var palmeiras = new Team("Palmeiras", 0);
            var flamengo = new Team("Flamengo", 0);
            var fluminense = new Team("Fluminense", 0);
            var corinthians = new Team("Corinthians", 0);
            var chapecoense = new Team("Chapecoense", 0);
            var atleticoMG = new Team("Atlético - MG", 0);

            var teams = new List<Team>{palmeiras, flamengo, fluminense, corinthians, chapecoense, atleticoMG};

            var registered = cbf.RegisterOfTeams(teams, "CBF");

            Assert.True(registered);
            Assert.NotEqual(8, teams.Count);
       }

       [Fact]
       public void Should_register_team_when_password_is_correct()
       {
            var cbf = new CBF();
            var palmeiras = new Team("Palmeiras", 0);
          
            var teams = new List<Team>{palmeiras};

            var registered = cbf.RegisterOfTeams(teams, "CBF");

            Assert.True(registered);
       }

       [Fact]
       public void Should_not_register_a_team_when_password_is_incorrect()
       {
            var cbf = new CBF();
            var palmeiras = new Team("Palmeiras", 0);
            var teams = new List<Team>{palmeiras};

            var registered = cbf.RegisterOfTeams(teams, "incorrect");

            Assert.Empty(cbf.Teams);
            Assert.False(registered);
       }
     }
}
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
            var palmeiras = new Team("Palmeiras");
            var flamengo = new Team("Flamengo");
            var fluminense = new Team("Fluminense");
            var corinthians = new Team("Corinthians");
            var chapecoense = new Team("Chapecoense");
            var atleticoMG = new Team("Atlético - MG");
            var vasco = new Team("Vasco");
            var saoPaulo = new Team("São Paulo");

            var teams = new List<Team>{palmeiras, flamengo, fluminense, corinthians, chapecoense, atleticoMG, vasco, saoPaulo};

            var registered = cbf.RegisterOfTeams(teams, "CBF");

            Assert.True(registered);
            Assert.Equal(8, teams.Count);
       }

       [Fact]
       public void Should_return_false_when_minus_of_eight_teams_are_registered()
       {
            var cbf = new CBF();
            var palmeiras = new Team("Palmeiras");
            var flamengo = new Team("Flamengo");
            var fluminense = new Team("Fluminense");
            var corinthians = new Team("Corinthians");
            var chapecoense = new Team("Chapecoense");
            var atleticoMG = new Team("Atlético - MG");

            var teams = new List<Team>{palmeiras, flamengo, fluminense, corinthians, chapecoense, atleticoMG};

            var registered = cbf.RegisterOfTeams(teams, "CBF");

            Assert.True(registered);
            Assert.NotEqual(8, teams.Count);
       }

       [Fact]
       public void Should_register_team_when_password_is_correct()
       {
            var cbf = new CBF();
            var palmeiras = new Team("Palmeiras");
            
            var teams = new List<Team>{palmeiras};

            var registered = cbf.RegisterOfTeams(teams, "CBF");

            Assert.True(registered);
       }

       [Fact]
       public void Should_not_register_a_team_when_password_is_incorrect()
       {
            var cbf = new CBF();
            var palmeiras = new Team("Palmeiras");
            var teams = new List<Team>{palmeiras};

            var registered = cbf.RegisterOfTeams(teams, "incorrect");

            Assert.Empty(cbf.Teams);
            Assert.False(registered);
       }

     [Fact]
     public void Should_return_true_when_have_more_of_16_players()
     {
          var cbf = new CBF();
          var gallardo = new Player("Thiago Gallardo");
          var valdivia = new Player("Valdívia Amorim");
          var luan = new Player("Luan Santos");
          var dudu = new Player("Eduardo Ramos");
          var neymar = new Player("Neymar Jr.");
          var gabigol = new Player("Gabriel Lanzoni");
          var marcos = new Player("Marcos Augustini");
          var adrian = new Player("Adrian Silva");
          var pablo = new Player("Pablo Lima");
          var lucas = new Player("Lucas Stille");
          var thiago = new Player("Thiago Moraes");
          var carlos = new Player("Carlos Henrique");
          var julio = new Player("Julio Garcia");
          var martins = new Player("Martins Antony");
          var caio = new Player("Caio dos Santos");
          var manoel = new Player("Manoel Lima");
          var gabriel = new Player("Gabriel Olveira");
          var antonio = new Player("Antonio Nunes ");
          var yuri = new Player("Yuri Martins");
          var alisson = new Player("Alisson Ribeiro");
          var marlon = new Player("Marlon Floriani");
          var amaral = new Player("Amaral Batista");
          
          var _players = new List<Player>(){gallardo, valdivia, luan, dudu, neymar, gabigol, marcos, adrian, pablo, lucas, thiago, carlos, julio, 
          martins, caio, manoel, gabriel, antonio, yuri, alisson, marlon, amaral };

          var players = cbf.AddPlayers(_players);

          Assert.True(players);
          Assert.NotEmpty(cbf._players);
     }

     [Fact]
     public void Should_not_create_when_return_false()
     {
          var cbf = new CBF();
          var gallardo = new Player("Thiago Gallardo");
          var valdivia = new Player("Valdívia Amorim");
          var luan = new Player("Luan Santos");
          var dudu = new Player("Eduardo Ramos");
          var neymar = new Player("Neymar Jr.");
          var gabigol = new Player("Gabriel Lanzoni");
          var marcos = new Player("Marcos Augustini");
          var adrian = new Player("Adrian Silva");
          var pablo = new Player("Pablo Lima");
          var lucas = new Player("Lucas Stille");
          var thiago = new Player("Thiago Moraes");
          var carlos = new Player("Carlos Henrique");
          var julio = new Player("Julio Garcia");
          var martins = new Player("Martins Antony");
          var caio = new Player("Caio dos Santos");
          var manoel = new Player("Manoel Lima");
          var gabriel = new Player("Gabriel Olveira");
          var antonio = new Player("Antonio Nunes ");
          var yuri = new Player("Yuri Martins");
          var alisson = new Player("Alisson Ribeiro");
          var marlon = new Player("Marlon Floriani");
          var amaral = new Player("Amaral Batista");

          var _players = new List<Player>(){gallardo, valdivia, luan, dudu, neymar, gabigol, marcos, adrian, pablo, lucas, thiago, carlos, julio, 
          martins, caio, manoel, gabriel, antonio, yuri, alisson, marlon, amaral };
          
          var players = cbf.AddPlayers(_players);

          Assert.True(players);
          Assert.Empty(cbf._players);
     }

    }
}
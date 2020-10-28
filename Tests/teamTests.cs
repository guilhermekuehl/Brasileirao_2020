using System;
using System.Collections.Generic;
using Domain;
using Xunit;

namespace Tests
{
    public class teamTests
    {
          [Fact]
          public void Should_return_true_when_have_more_of_16_players()
          {
               var atletico = new Team("Atlético");

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

               
               var _players = new List<Player>(){gallardo, valdivia, luan, dudu, neymar, gabigol, marcos, adrian, pablo, lucas, thiago, carlos,
               julio, martins, caio, manoel, gabriel, antonio, yuri, alisson, marlon, amaral};



               var players = atletico.AddPlayers(_players);

               Assert.True(players);
               Assert.NotEmpty(atletico.Players);
          }

          [Fact]
          public void Should_return_false_when_have_minus_of_16_players()
          {
               var flamengo = new Team("Flamengo");

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
               var amaral = new Player("Amaral Batista");

               var _players = new List<Player>(){gallardo, valdivia, luan, dudu, neymar, gabigol, marcos, adrian, pablo, lucas, amaral };
               
               var players = flamengo.AddPlayers(_players);

               Assert.False(players);
               Assert.Empty(flamengo.Players);
          } 

          
          [Fact]
          public void Should_return_true_when_remove_more_of_15_players_and_minus_of_33_players()
          {
               var flamengo = new Team("Flamengo");

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

               var _players = new List<Player>(){gallardo, valdivia, luan, dudu, neymar, gabigol, marcos, adrian, pablo, lucas, thiago, carlos,
               julio, martins, caio, manoel, gabriel, antonio, yuri, alisson, marlon};
               
               var players = flamengo.RemovePlayers(_players);

               Assert.True(players);
               Assert.Empty(flamengo.Players);
          }
          
          [Fact]
          public void Should_return_false_when_remove_minus_of_15_players()
          {
               var flamengo = new Team("Flamengo");

               var gallardo = new Player("Thiago Gallardo");
               var valdivia = new Player("Valdívia Amorim");
               var luan = new Player("Luan Santos");
               var dudu = new Player("Eduardo Ramos");
               var neymar = new Player("Neymar Jr.");
               var gabigol = new Player("Gabriel Lanzoni");
               var marcos = new Player("Marcos Augustini");
               var adrian = new Player("Adrian Silva");

               var _players = new List<Player>(){gallardo, valdivia, luan, dudu, neymar, gabigol, marcos, adrian};
               
               var players = flamengo.RemovePlayers(_players);

               Assert.False(players);
               Assert.Empty(flamengo.Players);
          }
    }
}
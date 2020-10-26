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

               var gallardo = new Player(Guid.NewGuid(), "Thiago Gallardo", 0);
               var valdivia = new Player(Guid.NewGuid(), "Valdívia Amorim", 0);
               var luan = new Player(Guid.NewGuid(), "Luan Santos", 0);
               var dudu = new Player(Guid.NewGuid(), "Eduardo Ramos", 0);
               var neymar = new Player(Guid.NewGuid(), "Neymar Jr.", 0);
               var gabigol = new Player(Guid.NewGuid(), "Gabriel Lanzoni", 2);
               var marcos = new Player(Guid.NewGuid(), "Marcos Augustini", 0);
               var adrian = new Player(Guid.NewGuid(), "Adrian Silva", 0);
               var pablo = new Player(Guid.NewGuid(), "Pablo Lima", 1);
               var lucas = new Player(Guid.NewGuid(), "Lucas Stille", 1);
               var thiago = new Player(Guid.NewGuid(), "Thiago Moraes", 0);
               var carlos = new Player(Guid.NewGuid(), "Carlos Henrique", 0);
               var julio = new Player(Guid.NewGuid(),"Julio Garcia", 0);
               var martins = new Player(Guid.NewGuid(),"Martins Antony", 0);
               var caio = new Player(Guid.NewGuid(), "Caio dos Santos", 0);
               var manoel = new Player(Guid.NewGuid(), "Manoel Lima", 0);
               var gabriel = new Player(Guid.NewGuid(), "Gabriel Olveira", 0);
               var antonio = new Player(Guid.NewGuid(), "Antonio Nunes ", 0);
               var yuri = new Player(Guid.NewGuid(), "Yuri Martins", 0);
               var alisson = new Player(Guid.NewGuid(),"Alisson Ribeiro", 1);
               var marlon = new Player(Guid.NewGuid(), "Marlon Floriani", 0);
               var amaral = new Player(Guid.NewGuid(), "Amaral Batista", 0);

               
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

               var gallardo = new Player(Guid.NewGuid(), "Thiago Gallardo", 1);
               var valdivia = new Player(Guid.NewGuid(), "Valdívia Amorim", 1);
               var luan = new Player(Guid.NewGuid(), "Luan Santos", 0);
               var dudu = new Player(Guid.NewGuid(), "Eduardo Ramos", 0);
               var neymar = new Player(Guid.NewGuid(), "Neymar Jr.", 0);
               var gabigol = new Player(Guid.NewGuid(), "Gabriel Lanzoni", 0);
               var marcos = new Player(Guid.NewGuid(), "Marcos Augustini", 0);
               var adrian = new Player(Guid.NewGuid(), "Adrian Silva", 0);
               var pablo = new Player(Guid.NewGuid(), "Pablo Lima", 0);
               var lucas = new Player(Guid.NewGuid(), "Lucas Stille", 0);
               var amaral = new Player(Guid.NewGuid(), "Amaral Batista", 1);

               var _players = new List<Player>(){gallardo, valdivia, luan, dudu, neymar, gabigol, marcos, adrian, pablo, lucas, amaral };
               
               var players = flamengo.AddPlayers(_players);

               Assert.False(players);
               Assert.Empty(flamengo.Players);
          } 

          
          [Fact]
          public void Should_return_true_when_remove_more_of_15_players_and_minus_of_33_players()
          {
               var flamengo = new Team("Flamengo");

               var gallardo = new Player(Guid.NewGuid(), "Thiago Gallardo", 0);
               var valdivia = new Player(Guid.NewGuid(), "Valdívia Amorim", 0);
               var luan = new Player(Guid.NewGuid(), "Luan Santos", 0);
               var dudu = new Player(Guid.NewGuid(), "Eduardo Ramos", 0);
               var neymar = new Player(Guid.NewGuid(), "Neymar Jr.", 0);
               var gabigol = new Player(Guid.NewGuid(), "Gabriel Lanzoni", 0);
               var marcos = new Player(Guid.NewGuid(), "Marcos Augustini", 0);
               var adrian = new Player(Guid.NewGuid(), "Adrian Silva", 0);
               var pablo = new Player(Guid.NewGuid(), "Pablo Lima", 1);
               var lucas = new Player(Guid.NewGuid(), "Lucas Stille", 1);
               var thiago = new Player(Guid.NewGuid(), "Thiago Moraes", 0);
               var carlos = new Player(Guid.NewGuid(), "Carlos Henrique", 0);
               var julio = new Player(Guid.NewGuid(),"Julio Garcia", 0);
               var martins = new Player(Guid.NewGuid(),"Martins Antony", 0);
               var caio = new Player(Guid.NewGuid(), "Caio dos Santos", 1);
               var manoel = new Player(Guid.NewGuid(), "Manoel Lima", 0);
               var gabriel = new Player(Guid.NewGuid(), "Gabriel Olveira", 0);
               var antonio = new Player(Guid.NewGuid(), "Antonio Nunes ", 0);
               var yuri = new Player(Guid.NewGuid(), "Yuri Martins", 0);
               var alisson = new Player(Guid.NewGuid(),"Alisson Ribeiro", 1);
               var marlon = new Player(Guid.NewGuid(), "Marlon Floriani", 0);

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

               var gallardo = new Player(Guid.NewGuid(), "Thiago Gallardo", 0);
               var valdivia = new Player(Guid.NewGuid(), "Valdívia Amorim", 2);
               var luan = new Player(Guid.NewGuid(), "Luan Santos", 1);
               var dudu = new Player(Guid.NewGuid(), "Eduardo Ramos", 0);
               var neymar = new Player(Guid.NewGuid(), "Neymar Jr.", 0);
               var gabigol = new Player(Guid.NewGuid(), "Gabriel Lanzoni", 0);
               var marcos = new Player(Guid.NewGuid(), "Marcos Augustini", 0);
               var adrian = new Player(Guid.NewGuid(), "Adrian Silva", 0);

               var _players = new List<Player>(){gallardo, valdivia, luan, dudu, neymar, gabigol, marcos, adrian};
               
               var players = flamengo.RemovePlayers(_players);

               Assert.False(players);
               Assert.Empty(flamengo.Players);
          }
    }
}
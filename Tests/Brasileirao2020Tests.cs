using System.Collections.Generic;
using Domain;
using Xunit;

namespace Tests
{
    public class Brasileirao2020Tests
    {
       //DADO que a aplicação está pronta, QUANDO o usuário informar a senha correta (CBF) 
       //DEVE ser realizado o cadastro dos times. 
      [Fact]
      public void Should_return_6_when_have_2_teams_in_conflit()
      {
         var brasileirao = new Brasileirao2020();
         var teams = new List<Team>{};
         var randomized = brasileirao.RandomGeneratorTeams();

         Assert.Equal(2, randomized.Count);
      }


      }
}
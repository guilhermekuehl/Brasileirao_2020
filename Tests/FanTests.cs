using Xunit;
using Domain;

namespace Tests
{
    public class FanTests
    {
        [Fact]
        public void should_return_a_table_of_a_top_scorer()
        {
            var fan = new Fan();
            var topScorerTable = fan.ShowTableTopScorer();
        }
    }
}
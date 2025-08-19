using NUnit.Framework;

namespace DependencyInjection.Tests
{
    public class RpsTests
    {
        [Test]
        public void RockBeatsScissors()
        {
            Console.WriteLine($"Assert type: {typeof(Assert).FullName}");
            var gm = new GameManagerDi(new ForcedPlayer(Choice.Rock), new ForcedPlayer(Choice.Scissors));
            Assert.AreEqual(RoundResult.Player1Win, gm.PlayRound());
        }
    }
}


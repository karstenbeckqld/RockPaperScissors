// ReSharper disable ConvertToPrimaryConstructor
namespace DependencyInjection;

public class GameManagerDi
{
    private readonly IPlayer _player1;
    private readonly IPlayer _player2;

    public GameManagerDi(IPlayer player1, IPlayer player2)
    {
        _player1 = player1;
        _player2 = player2;
    }

    public RoundResult PlayRound()
    {
        var p1 = _player1.GetChoice();
        var p2 = _player2.GetChoice();
        
        Console.WriteLine($"Player 1 picked {p1.ToString()} and player 2 picked {p2.ToString()}");
        
        if (p1 == p2)
        {
            return RoundResult.Draw;
        }

        if (p1 == Choice.Rock && p2 == Choice.Scissors || 
            p1 == Choice.Paper && p2 == Choice.Rock ||
            p1 == Choice.Scissors && p2 == Choice.Paper)
        {
            return RoundResult.Player1Win;
        }
        
        return RoundResult.Player2Win;
    }
}
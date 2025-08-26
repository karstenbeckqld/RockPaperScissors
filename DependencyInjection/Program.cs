// See https://aka.ms/new-console-template for more information

using DependencyInjection;

GameManagerDi gm = new GameManagerDi(new HumanPlayer(), new ComputerPlayer());

do
{
    RoundResult result = gm.PlayRound();

    if (result == RoundResult.Player1Win)
    {
        Console.WriteLine("Player 1 wins!");
    }

    else if (result == RoundResult.Player2Win)
    {
        Console.WriteLine("Player 2 wins!");
    }
    else
    {
        Console.WriteLine("It's a draw!");
    }
    
    Console.WriteLine("Do you want to play again? (Y/N): ");
    
} while (Console.ReadLine()?.ToUpper() == "Y");
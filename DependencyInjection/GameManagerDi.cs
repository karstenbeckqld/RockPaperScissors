namespace DependencyInjection;

public class GameManagerOriginal
{
    Random _rng = new Random();

    public RoundResult PlayRound()
    {
        // Player 1 (Human)
        Choice p1;

        do
        {
            Console.WriteLine("Enter choice: (R)ock, (P)aper or (S)cissors: ");
            var input =  Console.ReadLine().ToUpper();

            if (input == "R")
            {
                p1 = Choice.Rock;
                break;
            }
            
            if (input == "P")
            {
                p1 = Choice.Paper;
                break;
            }
            
            if (input == "S")
            {
                p1 = Choice.Scissors;
                break;
            }
            
            Console.WriteLine("Invalid choice.");
            
        } while (true);

        // Player 2 (Computer)
        Choice p2 = (Choice) _rng.Next(0, 3);
        Console.WriteLine($"Player 2 picked {p2.ToString()}");

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
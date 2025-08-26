namespace DependencyInjection;

public class HumanPlayer : IPlayer
{
    public Choice GetChoice()
    {
       
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

        return p1;
    }
}
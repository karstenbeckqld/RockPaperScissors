namespace DependencyInjection.Tests;

public class ForcedPlayer(Choice choice) : IPlayer
{
    public Choice GetChoice()
    {
       return choice;
    }
}
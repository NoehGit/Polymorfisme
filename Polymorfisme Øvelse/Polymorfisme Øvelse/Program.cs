// See https://aka.ms/new-console-template for more information
using System.Security.Principal;



class Spiller
{
    int xpToLevel = 200;
    int currentXp = 100;


    // Denne funktion er ikke vigtig, den er kun til for at vise hvordan børn af denne class kan kalde den og den virker.
    public void toLevel()
    {
        int missingXp = xpToLevel - currentXp;

        Console.WriteLine("Manglende XP til næste level: " + missingXp);

    }
}

class Player1 : Spiller
{
    public void playerHere()
    {
        Console.WriteLine("Player 1 er til stede !");
    }
}

class Player2 : Spiller
{
    public void playerHere()
    P
        Console.WriteLine("Player 2 er også til stede !");
    }
}
class Program
{
    static void Main()
    {
        Player1 player1 = new Player1();
        Player2 player2 = new Player2();

        // Efter at have skabt to objekter af de to børne classes, kaldes deres polyformiske funktioner:
        player1.playerHere();
        player2.playerHere();

        // Her kaldes parent class' funktion 'toLevel()' for at bevise at Player1 er et barn af Spiller classen:
        Console.WriteLine("");
        player1.toLevel();
    }
}


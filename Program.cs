using System;

int playerScore = 0;
Random random = new Random();

int computerScore = 0;

Console.WriteLine("Welcome to Rock, Paper, Scissors!");

while (playerScore != 3 && computerScore != 3)
{

    Console.WriteLine($"Player Score: {playerScore}  Computer Score: {computerScore}");

    Console.WriteLine("Enter your choice r for rock, p for paper, s for scissors");

    string playerChoice = Console.ReadLine();
    
    int computerChoice = random.Next(0, 3);

    if (computerChoice == 0)
    {
        Console.WriteLine("Computer chose rock");

        // Convierte la elección del jugador a minúsculas
        string normalizedChoice = playerChoice.ToLower();

        switch (normalizedChoice)
        {
            case "r":
                Console.WriteLine("It's a tie");
                break;
            case "p":
                Console.WriteLine("Player wins");
                playerScore++;
                break;
            case "s":
                Console.WriteLine("Computer wins");
                computerScore++;
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
    else if (computerChoice == 1)
    {
        Console.WriteLine("Computer chose paper");

        // Convierte la elección del jugador a minúsculas
        string normalizedChoice = playerChoice.ToLower();

        switch (normalizedChoice)
        {
            case "r":
                Console.WriteLine("Computer wins");
                computerScore++;
                break;
            case "p":
                Console.WriteLine("It's a tie");
                break;
            case "s":
                Console.WriteLine("Player wins");
                playerScore++;
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
    else
    {
        Console.WriteLine("Computer chose scissors");

        // Convierte la elección del jugador a minúsculas
        string normalizedChoice = playerChoice.ToLower();

        switch (normalizedChoice)
        {
            case "r":
                Console.WriteLine("Player wins");
                playerScore++;
                break;
            case "p":
                Console.WriteLine("Computer wins");
                computerScore++;
                break;
            case "s":
                Console.WriteLine("It's a tie");
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }

    if (playerScore == 3)
    {
        Console.WriteLine("Player wins the game");
    }
    else if (computerScore == 3)
    {
        Console.WriteLine("Computer wins the game");
    }

}

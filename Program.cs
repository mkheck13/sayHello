
Console.Clear();

bool playAgain = true;

while (playAgain)
{
    string? name;

    static bool trueName(string? input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return false;
        }
        foreach (char b in input)
        {
            if (!char.IsLetter(b) && b != ' ')
            {
                return false;
            }
        }
        return true;
    }
    while (true)
    {
        Console.WriteLine("Please enter your name using only the alphabet.");
        name = Console.ReadLine();

        if (trueName(name))
        {
            Console.WriteLine($"Hello {name}, it's nice to meet you!");
            break;
        }
        else
        {
            Console.WriteLine("Please only use letters from the alphabet.");
            break;
        }
    }

    Console.WriteLine("Would you like to play again?");
    Console.WriteLine("Type 'yes' to play again or 'no' to exit");

    bool yesNo = true;

    while (yesNo == true)
    {
        string userPlay = Console.ReadLine()!.Trim().ToLower();
        if (userPlay == "yes" || userPlay == "y")
        {
            Console.WriteLine("Let's go again!");
            yesNo = false;
        }
        else if (userPlay == "no" || userPlay == "n")
        {
            Console.WriteLine("See you next time.");
            yesNo = false;
            playAgain = false;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("That was not a yes or no. Try again.");
        }
    }
}


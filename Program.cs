
Console.Clear();

bool playAgain = true;

while(playAgain){
    string? name;

static bool trueName(string? input){
    if(string.IsNullOrEmpty(input)){
        return false;
    }
    foreach(char b in input){
        if(!char.IsLetter(b) && b != ' '){
            return false;
        }
    }
    return true;
    }
    while(true){
        Console.WriteLine("Please enter your name using only the alphabet.");
        name = Console.ReadLine();

        if(trueName(name)){
            Console.WriteLine($"Hello {name}, it's nice to meet you!");
            break;
        }else{
            Console.WriteLine("Please only use letters from the alphabet.");
            break;
        }
    }
    Console.WriteLine("Do you want to try again?");
    Console.WriteLine("Type yes to try again or hit any key to exit");
    string? userAnswer = Console.ReadLine();
    userAnswer = userAnswer.ToLower();
    if(userAnswer == "yes"){
        Console.WriteLine("Let's try this again!");
    }else{
        playAgain = false;
        Console.WriteLine("See you next time.");
    }


}


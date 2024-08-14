using System;

Random random = new();

int answer = random.Next(100);

int guess = -1;

Console.WriteLine("Guess a number between 0 and 100");


while(answer != guess) {

    try 
    {
        guess = Convert.ToInt32(Console.ReadLine());
    } 
    catch (Exception e) 
    {
        Console.WriteLine("Not the correct input type! Please enter a number next time");
        break;
    }

    if (answer == guess) {
        Console.WriteLine("You win!");
        break;
    }
    else if(answer > guess) {
        Console.WriteLine("a little higher");
    }
    else {
        Console.WriteLine("a little lower");
    }

}

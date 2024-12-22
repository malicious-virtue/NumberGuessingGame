using System;
Console.WriteLine("Welcome to the Number Guessing Game!");
Console.WriteLine("Please enter your name:");
string userName = Console.ReadLine();
Console.WriteLine($"{userName}, I'm thinking of a number between 1 and 50. Try to guess it!");
int numberToGuess = new Random().Next(1, 51);
int numberOfTries = 5;
while (numberOfTries > 0)
{
    Console.WriteLine($"You have {numberOfTries} tries left. Enter your guess:");
    bool validGuess = int.TryParse(Console.ReadLine(), out int userGuess);
    if (userGuess < 1 || userGuess > 50)
    {
        Console.WriteLine("Please enter a number between 1 and 50.");
        continue;
    }
    if (validGuess == false)
    {
        Console.WriteLine("Please enter a valid number.");
        continue;
    }
    if (userGuess == numberToGuess)
    {
        Console.WriteLine($"Congratulations, {userName}! You guessed the correct number: {numberToGuess}");
        return;
    }
    else if (userGuess < numberToGuess)
    {
        Console.WriteLine("Too low! Try again.");
    }
    else
    {
        Console.WriteLine("Too high! Try again.");
    }
    numberOfTries--;
}
Console.WriteLine($"Sorry, {userName}. You ran out of tries. The correct number was: {numberToGuess}");
Console.WriteLine("Game over! Press any key to exit.");
Console.ReadKey();
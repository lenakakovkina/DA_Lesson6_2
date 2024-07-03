int ValueToGuess = 109;
Console.WriteLine("Game! Guess the X value and win! Try to input some value");
int UserGuess = int.Parse(Console.ReadLine());
while (UserGuess != ValueToGuess)
{
    if (UserGuess > ValueToGuess)
    {
        Console.WriteLine("No.Try one more time. The value should be less.");
        UserGuess = int.Parse(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("No.Try one more time. The value should be more.");
        UserGuess = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Congratulations! You've guessed the correct value!");
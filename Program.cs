// get secret number between 1 and 10
int secret = new Random().Next(1, 11);

// remaining guesses
int remainingGuesses = 3;

// game is active
bool isActive = true;

while (isActive)
{
  Console.Write("\nGuess a number between 1 and 10: ");
  bool isValid = int.TryParse(Console.ReadLine(), out int guess);

  if (isValid && guess >= 1 && guess <= 10) 
  {
    remainingGuesses--;

    if (guess == secret) 
    {
      Console.WriteLine("You guessed the number!");
      isActive = false;
    } 
    else if (remainingGuesses == 0)
    {
      Console.WriteLine($"Sorry, you are out of guesses. The number was {secret}.");
      isActive = false;
    }
    else if (guess < secret) 
    {
      Console.WriteLine($"Sorry, you guessed too low. You remaining guesses is {remainingGuesses}.");
    }
    else
    {
      Console.WriteLine($"Sorry, you guessed too high. You remaining guesses is {remainingGuesses}.");
    }
  } 
  else 
  {
    Console.WriteLine("Not a valid input. Try Again.");
    continue;
  }

  if (!isActive) 
  {
    Console.WriteLine("\nPlay Again? (Y/y)");
    string? response = Console.ReadLine();

    if (!string.IsNullOrEmpty(response) && response.ToLower() == "y") 
    {
      secret = new Random().Next(1, 11);
      remainingGuesses = 3;
      isActive = true;
    }
  }
}
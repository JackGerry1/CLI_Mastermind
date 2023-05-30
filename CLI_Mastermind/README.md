# Console Mastermind Game

This is a C# console-based implementation of the Mastermind game. The program generates a secret code consisting of digits and challenges the player to guess the code within a limited number of attempts.

## How to Play

1. Run the program.
2. Enter the desired code length when prompted. The code length represents the number of digits in the secret code.
3. Enter the number of guesses you would like to have.
4. The program will generate a secret code consisting of random digits between 1 and 8.
5. Guess the secret code by entering your guess as a sequence of digits separated by spaces.
6. After each guess, the program will provide feedback in the form of red and white pegs:
   - A red peg indicates that a guessed digit is in the correct position.
   - A white peg indicates that a guessed digit is present in the code but in the wrong position.
7. Keep guessing the code within the available number of attempts.
8. If you guess the code correctly within the given attempts, you win!
9. If you run out of attempts without guessing the code correctly, you lose.
10. You can choose to play again or quit at the end of each game.

## Requirements

- .NET Framework

## How to Run

1. Clone the repository or download the source code files.
2. Open the solution in a C# compatible IDE or editor.
3. Build the solution to compile the code.
4. Run the program.

## Example Usage

Enter the desired code length:
4

Enter the number of guesses you would like to have:
10

The Secret Code Has Been Set with a length of 4, you have 10 attempts to try and crack it!!!

Enter your guess for the secret code on one line separated by spaces:
2 4 6 8

You got 0 red peg(s) and 2 white peg(s)
You have 9 guess(es) remaining

...

Enter your guess for the secret code on one line separated by spaces:
6 8 1 3

Congratulations! You guessed the secret code correctly.

The secret code was: 6 8 1 3
Do you want to play again? (Y/N): n
using System;
using System.Collections.Generic;

namespace GameMenu
{
    public class GameMenu
    {
        private Dictionary<int, IGame> games = new Dictionary<int, IGame>();

        public GameMenu()
        {
            // Register available games
            games.Add(1, new TicTacToe());
            games.Add(2, new Hangman()); // Placeholder for the Hangman game
        }

        public void Run()
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Game Hub!");
                Console.WriteLine("Select a game to play:");

                foreach (var game in games)
                {
                    Console.WriteLine($"{game.Key}. {game.Value.GetType().Name}");
                }

                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice == 0)
                    {
                        exit = true;
                    }
                    else if (games.ContainsKey(choice))
                    {
                        Console.Clear();
                        games[choice].Play();
                        Console.WriteLine("\nPress any key to return to the menu...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice! Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a number.");
                }
            }

            Console.WriteLine("Thank you for playing! Goodbye.");
        }
    }
}

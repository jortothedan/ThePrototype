using System;

namespace ThePrototype
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            int user1Number;
            int user2Number;
            string input;

            do
            {
                Console.Write("User 1, enter a number between 1 and 100: ");
                input = Console.ReadLine();
                user1Number = Convert.ToInt32(input);
            }
            while (user1Number < 0 || user1Number > 100);

            Console.Clear();

            Console.WriteLine("User 2, guess the number.");

            do
            {
                Console.Write("What is your guess? ");
                input = Console.ReadLine();
                user2Number = Convert.ToInt32(input);

                if (user2Number < user1Number)
                {
                    Console.WriteLine($"{user2Number} is too low.");
                }
                else if (user2Number > user1Number)
                {
                    Console.WriteLine($"{user2Number} is too high.");
                }
                else
                {
                    Console.WriteLine("You guessed the number!");
                }
            }
            while (user2Number != user1Number);
        }
    }
}
=======
            Console.WriteLine("Hello World!");
        }
    }
}
>>>>>>> 8b2dfacb5ba70d87eca92f7d91c988e9079d5e70

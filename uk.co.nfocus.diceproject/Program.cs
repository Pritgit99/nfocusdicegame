using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace uk.co.nfocus.diceproject
{
    internal class Program
    {

        static void Main(string[] args)
        {


            int playerfirstroll, playersecondroll, computerfirstroll, computersecondroll; //declares four variables as integers
            Random number1 = new Random(); //generates a random number

            //The line below assigns the results of each roll to the random number
            (playerfirstroll, playersecondroll, computerfirstroll, computersecondroll) = (number1.Next(1, 7), number1.Next(1, 7), number1.Next(1, 7), number1.Next(1, 7));

            Console.WriteLine("Your roll");
            Console.WriteLine("You rolled a " + playerfirstroll + " and a " + playersecondroll); //Diplays the players two dice rolls
            Console.WriteLine("Your total is " + (playerfirstroll + playersecondroll)); //Adds the players rolls together to reach a total
            Console.WriteLine(" ");
            Console.WriteLine("Press any key for computers turn");
            Console.ReadKey(true); //This line reads the key inputted from the user so the system can generate the computers roll.
            Console.WriteLine(" ");
            Console.WriteLine("Computers roll");
            Console.WriteLine("Computer rolled a " + computerfirstroll + " and a " + computersecondroll); //Displays the computers roll
            Console.WriteLine("Computers total is " + (computerfirstroll + computersecondroll)); //Adds the computers two rolls together
            Console.WriteLine(" ");

            if (playerfirstroll + playersecondroll > computerfirstroll + computersecondroll)
            {
                Console.WriteLine("You got higher than the computer. You won!"); //If the total of the players rolls is higher than the computers then display this
            }
            else if (computerfirstroll + computersecondroll > playerfirstroll + playersecondroll)
            {
                Console.WriteLine("You got lower than the computer. You lost!"); //If the computer rolls higher then display this
            }
            else Console.WriteLine("You drew!"); //Takes into account if the rolls add up to the same number

            Console.WriteLine(" ");
            Console.WriteLine("Play again? y or n");
            if (Console.ReadKey(true).Key == ConsoleKey.Y) //Readkey(True) is used to read the key pressed and hide it on the console for a cleaner interface
            {
                Console.WriteLine(" ");
                Main(null); //If the user would like to play again then they press the 'y' key which is read by the system to restart the game
            }

            else if (Console.ReadKey().Key == ConsoleKey.N) //If the player does not want to play again then the console will close
            {
                return;
            }
        }

        
    }
}
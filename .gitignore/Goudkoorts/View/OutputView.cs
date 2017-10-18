using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public class OutputView
    {
        public void ShowGameStart()
        {
            ConsoleKeyInfo input;
            Console.Clear();
            Console.WriteLine("╒═══════════════════════════════════════════════════════════╕");
            Console.WriteLine("| Welcome to Goudkoorts                                     |");
            Console.WriteLine("|                                                           |");
            Console.WriteLine("| You have to fill the ship with unlimited amount of gold!  |");
            Console.WriteLine("| ..But make sure you don't crash the carts!                |");
            Console.WriteLine("|                                                           |");
            Console.WriteLine("╘═══════════════════════════════════════════════════════════╛");
            Console.WriteLine("> press key to continue");
            input = Console.ReadKey();
            Console.Clear();
        }

        public void ShowGameOver(string winner)
        {
            ConsoleKeyInfo input;
            Console.Clear();

            //TODO
            // Punten calc
            Console.WriteLine("You have collected in total: ");
            Console.WriteLine("===== game over =====");
            Console.WriteLine("> press key to continue");
            input = Console.ReadKey();
        }


        private void ShowFields()
        {

        }

        private void ShowCarts()
        {

        }
    }
}
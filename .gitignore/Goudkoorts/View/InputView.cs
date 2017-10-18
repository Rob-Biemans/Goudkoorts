using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public class InputView
    {
        // TODO DEBUGGEN
        // 1-5 OF s = stop
        public int askForSwitchPick()
        {
            int s = 0;
            char c = '?';

            while ((s < 1 || s > 5))
            {
                Console.WriteLine("> pick a switch  (1 - 5), s = stop");
                var input = Console.ReadKey();
                c = input.KeyChar;
                if (s >= '1' && s <= '6')
                {
                    s = Convert.ToInt32(c);
                }

            }
            if (c == 's')
            {
                Environment.Exit(0);
            }

            Console.WriteLine("GEKOZEN: " + s);
            Console.ReadKey();
            return s;
        }
    }
}
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
            Console.WriteLine("> pick a switch  (1 - 5), s = stop");

            var note = Console.ReadLine();
            int s = 0;

            if (note.Length > 1) {
                askForSwitchPick();
            } else if (note == "S" || note == "s") {
                Environment.Exit(0);
            }

            try {
                s = Convert.ToInt32(note);
            } catch (FormatException e) {
                askForSwitchPick();
            }

            return s;
        }
    }
}
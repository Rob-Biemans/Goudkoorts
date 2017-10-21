using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public class Switch : ActionField
    {
        private Field Direction { get; set; }

        //Switch.Direction = up dan mag de bovenste erdoor

        // Constructor
        public Switch()
        {

        }

        public override string Icon()
        {
            return "S";
        }
    }
}
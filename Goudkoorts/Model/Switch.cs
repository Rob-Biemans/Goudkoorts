using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public class Switch : ActionField
    {
        private Field In { get; set; }
        private Field Out { get; set; }

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
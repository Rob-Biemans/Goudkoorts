using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public class Switch : Field
    {

        // Constructor
        public Switch()
        {

        }

        public override string Type()
        {
            return "|";
        }
    }
}
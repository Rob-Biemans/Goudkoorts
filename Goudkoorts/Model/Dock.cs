using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public class Dock : ActionField
    {

        private BaseField _field { get; set; }

        public override string Icon()
        {
            return "D";
        }
    }
}
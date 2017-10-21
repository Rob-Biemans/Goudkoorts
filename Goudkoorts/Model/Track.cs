using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public class Track : ActionField
    {
        private string icon;

        public Track(string value)
        {
            this.icon = value;
        }

        public override string Icon()
        {
            return this.icon;
        }
    }
}
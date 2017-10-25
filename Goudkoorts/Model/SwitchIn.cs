using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public class SwitchIn : Switch
    {

        private string icon;

        public SwitchIn(string value)
        {
            this.icon = value;
        }

        public override string Icon()
        {
            return this.icon;
        }
    }
}
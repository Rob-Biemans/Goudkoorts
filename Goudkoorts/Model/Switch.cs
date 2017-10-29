using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public abstract class Switch : ActionField
    {
        public string icon { get; set; }
        public Directions direction { get; set; }

        public abstract Directions getDirection();

        public abstract void changeDirection();

    }
}
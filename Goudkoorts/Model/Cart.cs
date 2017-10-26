using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public class Cart : MoveAbleObject
    {
        // Declarations
        private Boolean _isFilled { get; set; }

        // Constructor
        public Cart()
        {
            this._isFilled = true;
        }

        public override string Icon()
        {
            return "#";
        }

        private Boolean getIsFilled()
        {
            return this._isFilled;
        }

        private void setEmpty()
        {
            this._isFilled = false;
        }

        public override bool Move()
        {
            return true;
        }
    }
}
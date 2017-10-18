using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public class Cart : Field
    {
        // Declarations
        private Boolean _isFilled { get; set; }

        // Constructor
        public Cart()
        {
            this._isFilled = true;
        }

        public override string Type()
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
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public class Field : BaseField
    {
        protected Cart _cart;

        public override string Icon()
        {
            return "";
        }

        override public void PutCartOnThisField(Cart cart)
        {
            if (cart == null) {
                this._cart = cart;
            } else {
                
            }
        }

        public override void RemoveCartFromThisField(Cart cart)
        {
            if (this._cart == cart) {
                this._cart = null;
            } else {
                //throw new Exception_StoneNotFound();
            }
        }

    }
}
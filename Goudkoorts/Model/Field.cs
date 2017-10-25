using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public class Field : BaseField
    {
        protected Cart _cart;
        private BaseField _spot;

        private MoveAbleObject _MoveAbleObject { get; set; }

        public override string Icon()
        {
            return "F";
        }

        public void moveTo()
        {
            BaseField oldSpot = _spot;
            BaseField newSpot = oldSpot;

            //if (_spot is Laatste Track of Water)
            //{
                // Einde van de baan of water 
                // dus Cart of Ship verdwijnt
                oldSpot.RemoveMoveAbleObjectFromThisField(_cart);
            //}

            newSpot = newSpot.NextField;
           
            // update the fields (put and remove cart)
            newSpot.PutMoveAbleObjectOnThisField(_cart);
            _spot = newSpot;
            oldSpot.RemoveMoveAbleObjectFromThisField(_cart);
        }

        override public void PutMoveAbleObjectOnThisField(Cart cart)
        {
            if (cart == null) {
                this._cart = cart;
            } else {
                // Er is al aan cart
                // Gameover
            }
        }

        public override void RemoveMoveAbleObjectFromThisField(Cart cart)
        {
            if (this._cart == cart) {
                this._cart = null;
            } else {
                // Theres no cart to be removed.
            }
        }

    }
}
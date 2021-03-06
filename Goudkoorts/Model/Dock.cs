﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public class Dock : ActionField
    {

        private MoveAbleObject _ship { get; set; }

        public override string Icon()
        {
            return "D";
        }

        public override void Action(Game _game)
        {
            LinkedList<Field> list = _game.getGameField();
            _ship = list.ElementAt(8).MoveAbleObject;

            if (_ship != null && this.MoveAbleObject != null && ((Ship)_ship).IsAtDock())
            {
                ((Ship)_ship).AddGoldToShip();
            }
        }

    }
}
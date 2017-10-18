using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public class Game
    {

        // Declarations
        private Player _player { get; set; }
        private Boolean _isGameOver { get; set; }
        private Ship _ship { get; set; }

        private Field _field { get; set; }

        // Constructor
        public Game()
        {
            _ship = new Ship();
            _player = new Player();
        }

        //private 

        public Boolean getGameOver()
        {
            return this._isGameOver;
        }

        public void setGameOver()
        {
            this._isGameOver = true;
        }

    }
}
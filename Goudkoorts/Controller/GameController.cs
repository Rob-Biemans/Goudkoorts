using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public class GameController
    {
        // Declarations
        private OutputView _outputview { get; set; }

        private InputView _inputview { get; set; }

        private Game _game { get; set; }

        // Constructor
        public GameController()
        {
            _inputview = new InputView();
            _outputview = new OutputView();
            _game = new Game();
        }

        public void playGoudkoorts()
        {
            _outputview.ShowGameStart();
           
            while (!_game.getGameOver())
            {
                Console.Clear();
                // Print Game
                _outputview.ShowGameStatus(_game);
                // Ask for input (switch)
                // and change switch state
                _inputview.askForSwitchPick();
                
                //Console.WriteLine("NIET OVER");
                //_game.setGameOver();
            }


            Console.WriteLine("GAME OVER!");
            Console.ReadKey();
        }


    }
}
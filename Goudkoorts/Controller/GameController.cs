using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Goudkoorts
{
    public class GameController
    {
        // Declarations
        private Timer _aTimer { get; set; }
        private LinkedList<Field> _gameField { get; set; }

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

            _aTimer = new Timer(5000);
            _aTimer.Elapsed += OnTimedEvent;
            _aTimer.AutoReset = true;
            _aTimer.Enabled = true;
           
            while (!_game.getGameOver())
            {
                Console.Clear();

                _outputview.ShowGameStatus(_game);

                changeSwitch(_inputview.askForSwitchPick());
                
                //Console.WriteLine("NIET OVER");
                //_game.setGameOver();
            }

            Console.WriteLine("GAME OVER!");
            Console.ReadKey();
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            try
            {
                _game.run();
                _outputview.ShowGameStatus(_game);
            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }
        }

        public void changeSwitch(int value)
        {
            int index = 1;
            foreach (var val in _game.getGameField())
            {
                if (val is Switch)
                {                     
                    if (index == value && val.MoveAbleObject == null)
                        ((Switch)val).changeDirection();

                    index++;
                }
            }
        }

    }
}
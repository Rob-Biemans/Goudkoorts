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
        private int interval = 5000;
        private LinkedList<Field> _gameField { get; set; }

        private OutputView _outputview { get; set; }
        private InputView _inputview { get; set; }

        private Game _game { get; set; }
        private bool switchAllowed { get; set; }

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

            _aTimer = new Timer(interval);
            _aTimer.Elapsed += OnTimedEvent;
            _aTimer.AutoReset = true;
            _aTimer.Enabled = true;

            while (!_game.getGameOver())
            {
                Console.Clear();

                _outputview.ShowGameStatus(_game);

                changeSwitch(_inputview.askForSwitchPick());
            }

        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            
            switchAllowed = true;

            if (_game.getGameOver() == true)
            {
                _aTimer.Stop();
                _outputview.ShowGameOver(_game);
            }

            try
            {
                int temp = (interval - _game.getPlayer().getScore());
                if (temp >= 0)
                    _aTimer.Interval = temp;

                _game.run();
                _outputview.ShowGameStatus(_game);
                changeSwitch(_inputview.askForSwitchPick());
                switchAllowed = false;
            }
            catch (Exception a)
            {
                
            }
        }

        public void changeSwitch(int value)
        {
            int index = 1;
            foreach (var val in _game.getGameField())
            {
                if (val is Switch && switchAllowed == true)
                {                     
                    if (index == value && val.MoveAbleObject == null)
                        ((Switch)val).changeDirection();

                    index++;
                }
            }
        }

    }
}
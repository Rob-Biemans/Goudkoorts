using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Timers;

namespace Goudkoorts
{
    public class Game
    {

        // Declarations
        private Player _player { get; set; }
        private Boolean _isGameOver { get; set; }

        private Field _field { get; set; }

        private string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
        private LinkedList<Field> _gameField { get; set; }

        private Timer aTimer;

        // Constructor
        public Game()
        {
            _player = new Player();
            generateField();

            aTimer = new Timer(2000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("ELAPSED");
            //TODO MOVE CART en SHIP
        }

        public Boolean getGameOver()
        {
            return this._isGameOver;
        }

        public void setGameOver()
        {
            this._isGameOver = true;
        }

        private void generateField()
        {
            this._gameField = new LinkedList<Field>();

            _filePath = Directory.GetParent(Directory.GetParent(_filePath).FullName).FullName;
            _filePath += @"\Level\map1.txt";

            string[] lines = System.IO.File.ReadAllLines(_filePath);

            Field prev = null;
            Field next = null;

            foreach (string line in lines)
            {
                foreach (char Char in line)
                {

                    if (prev == null) {
                        prev = new WaterField();
                    }

                    switch (Char)
                    {
                        case '~':
                            next = new WaterField();
                            prev.NextField = next;
                            prev = next;
                            this._gameField.AddLast(prev);
                            break;

                        case '-':
                            next = new Track("-");
                            prev.NextField = next;
                            prev = next;
                            this._gameField.AddLast(prev);
                            break;

                        case '|':
                            next = new Track("|");
                            prev.NextField = next;
                            prev = next;
                            this._gameField.AddLast(prev);
                            break;

                        case '.':
                            next = new EmptyField();
                            prev.NextField = next;
                            prev = next;
                            this._gameField.AddLast(prev);
                            break;

                        case 'D':
                            next = new Dock();
                            prev.NextField = next;
                            prev = next;
                            this._gameField.AddLast(prev);
                            break;

                        case 'Y':
                            next = new Yard();
                            prev.NextField = next;
                            prev = next;
                            this._gameField.AddLast(prev);
                            break;

                        // ╮ 
                        case 'w':
                            next = new Track("╮");
                            prev.NextField = next;
                            prev = next;
                            this._gameField.AddLast(prev);
                            break;

                        // ╭ 
                        case 'x':
                            next = new Track("╭");
                            prev.NextField = next;
                            prev = next;
                            this._gameField.AddLast(prev);
                            break;

                        // ╯ 
                        case 'y':
                            next = new Track("╯");
                            prev.NextField = next;
                            prev = next;
                            this._gameField.AddLast(prev);
                            break;

                        // ╰ 
                        case 'z':
                            next = new Track("╰");
                            prev.NextField = next;
                            prev = next;
                            this._gameField.AddLast(prev);
                            break;

                        // In
                        case 'S':
                            next = new SwitchIn("S");
                            prev.NextField = next;
                            prev = next;
                            this._gameField.AddLast(prev);
                            break;

                        // Out
                        case 's':
                            next = new SwitchOut("s");
                            prev.NextField = next;
                            prev = next;
                            this._gameField.AddLast(prev);
                            break;

                        case 'A':
                            next = new Warehouse();
                            prev.NextField = next;
                            prev = next;
                            this._gameField.AddLast(prev);
                            break;

                        // Ship
                        case '0':
                            next = new WaterField();
                            prev.NextField = next;
                            prev = next;
                            this._gameField.AddLast(prev).Value = new Ship();
                            break;

                        default:
                            Console.WriteLine("CORRUPT MAP FILE :(");
                            Console.ReadKey();
                            break;
                    }

                }
            }

            generateTrackLinks();

        }

        //Hardcoded due limited time
        public void generateTrackLinks()
        {
            BaseField currentField = _gameField.First.Value;
            {

                    //39 warehouse ipv 40 (overal -1)
                    //Console.WriteLine(_gameField.ElementAt(39));

                    _gameField.ElementAt(40).NextTrack = _gameField.ElementAt(41);

                    if (currentField is Field)
                    {
                        currentField = ((Field)currentField).NextField;
                    }

            }
            checkTrackLinks();
        }

        public void checkTrackLinks()
        {
            int i = 0;
            foreach (var val in _gameField)
            {
                

                if (val is Track)
                    Console.WriteLine("Track: " + i + " > " + val.NextTrack);

                if (val is Switch)
                    Console.WriteLine("Switch: " + i + " > " + val.NextTrack);

                if (val is Dock)
                    Console.WriteLine("Dock: " + i + " > " + val.NextTrack);

                if (val is Yard)
                    Console.WriteLine("Yard: " + i + " > " + val.NextTrack);

                i++;

            }
            Console.ReadKey();
        }

        public LinkedList<Field> getGameField()
        {
            return this._gameField;
        }

    }
}
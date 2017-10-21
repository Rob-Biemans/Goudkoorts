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

        protected Field _first; // wijst naar eerste element in de lijst
        protected Field _last;  // wijst naar laatste element in de lijst
        protected int _length; // is gelijk aan het aantal links in de lijst 

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

            //Console.ReadKey();
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            throw new NotImplementedException();
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

            foreach (string line in lines)
            {
                foreach (char Char in line)
                {
                    switch (Char)
                    {
                        case '~':
                            this._gameField.AddLast(new WaterField());
                            break;

                        case '-':
                            this._gameField.AddLast(new Track("-"));
                            break;

                        case '|':
                            this._gameField.AddLast(new Track("|"));
                            break;

                        case '.':
                            this._gameField.AddLast(new EmptyField());
                            break;

                        case 'D':
                            this._gameField.AddLast(new Dock());
                            break;

                        case 'Y':
                            this._gameField.AddLast(new Yard());
                            break;

                        // ╮ 
                        case 'w':
                            this._gameField.AddLast(new Track("╮"));
                            break;

                        // ╭ 
                        case 'x':
                            this._gameField.AddLast(new Track("╭"));
                            break;

                        // ╯ 
                        case 'y':
                            this._gameField.AddLast(new Track("╯"));
                            break;

                        // ╰ 
                        case 'z':
                            this._gameField.AddLast(new Track("╰"));
                            break;

                        case 'S':
                            this._gameField.AddLast(new Switch());
                            break;

                        case 'A':
                            this._gameField.AddLast(new Warehouse());
                            break;

                        case 'E':
                            this._gameField.AddLast(new EndField());
                            break;

                        // Ship
                        case '@':
                            this._gameField.AddLast(new WaterField());
                            break;

                        case '0':
                            this._gameField.AddLast(new WaterField());
                            break;

                        default:
                            Console.WriteLine("CORRUPT MAP FILE :(");
                            Console.ReadKey();
                            break;
                    }

                }
            }

        }

        public LinkedList<Field> getGameField()
        {
            return this._gameField;
        }

    }
}
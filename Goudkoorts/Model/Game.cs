using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public class Game
    {

        // Declarations
        private Player _player { get; set; }
        private Boolean _isGameOver { get; set; }

        private Field _field { get; set; }

        private string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
        private LinkedList<Field> _gameField;

        // Constructor
        public Game()
        {
            _player = new Player();
            generateField();
            Console.ReadKey();
        }

        public Boolean getGameOver()
        {
            return this._isGameOver;
        }

        public void setGameOver()
        {
            this._isGameOver = true;
        }

        public void generateField()
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
                            this._gameField.AddLast(new Track());
                            break;

                        case '|':
                            this._gameField.AddLast(new Track());
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
                            this._gameField.AddLast(new Track());
                            break;

                        // ╭ 
                        case 'x':
                            this._gameField.AddLast(new Track());
                            break;

                        // ╯ 
                        case 'y':
                            this._gameField.AddLast(new Track());
                            break;

                        // ╰ 
                        case 'z':
                            this._gameField.AddLast(new Track());
                            break;

                        case 'S':
                            this._gameField.AddLast(new Switch());
                            break;

                        case 'A':
                            this._gameField.AddLast(new Warehouse());
                            break;

                        // Ship
                        case '@':
                            this._gameField.AddLast(new WaterField());
                            break;

                        case '0':
                            this._gameField.AddLast(new WaterField());
                            break;

                        default:
                            Console.WriteLine("CORRUPT MAP FILE");
                            Console.ReadKey();
                            break;
                    }

                }
            }

            Console.WriteLine(this._gameField.Count());
            Console.ReadKey();

        }


    }
}
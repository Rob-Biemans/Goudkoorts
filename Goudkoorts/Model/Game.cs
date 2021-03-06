﻿using System;
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

        private OutputView _outputview { get; set; }

        private int prevRandom = 0;

        // Constructor
        public Game()
        {
            _player = new Player();
            generateField();
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

            int i = 0;

            foreach (string line in lines)
            {
                foreach (char Char in line)
                {
                    
                    if (prev == null) {
                        prev = new WaterField();
                        prev.Pos = i;
                    }

                    switch (Char)
                    {
                        case '~':
                            next = new WaterField();
                            break;

                        case '-':
                            next = new Track("-");
                            break;

                        case '|':
                            next = new Track("|");
                            break;

                        case '.':
                            next = new EmptyField();
                            break;

                        case 'D':
                            next = new Dock();
                            break;

                        case 'Y':
                            next = new Yard();
                            break;

                        // ╮ 
                        case 'w':
                            next = new Track("╮");
                            break;

                        // ╭ 
                        case 'x':
                            next = new Track("╭");
                            break;

                        // ╯ 
                        case 'y':
                            next = new Track("╯");
                            break;

                        // ╰ 
                        case 'z':
                            next = new Track("╰");
                            break;

                        // In
                        case 'S':
                            next = new SwitchIn("╭");
                            break;

                        // Out
                        case 's':
                            next = new SwitchOut("╮");
                            break;

                        case 'A':
                            next = new Warehouse();
                            break;

                        // Ship
                        case '0':
                            next = new WaterField();
                            next.Pos = i;
                            next.PutMoveAbleObjectOnThisField(new Ship(), this);
                            break;

                        default:
                            Console.WriteLine("CORRUPT MAP FILE :(");
                            Console.ReadKey();
                            break;
                    }

                    next.Pos = i;
                    prev.NextField = next;
                    prev = next;
                    this._gameField.AddLast(prev);

                    i++;
                }
            }

            generateTrackLinks();

        }

        public void generateTrackLinks()
        {

            _gameField.ElementAt(0).Next = _gameField.ElementAt(1);
            _gameField.ElementAt(1).Next = _gameField.ElementAt(2);
            _gameField.ElementAt(2).Next = _gameField.ElementAt(3);
            _gameField.ElementAt(3).Next = _gameField.ElementAt(4);
            _gameField.ElementAt(4).Next = _gameField.ElementAt(5);
            _gameField.ElementAt(5).Next = _gameField.ElementAt(6);
            _gameField.ElementAt(6).Next = _gameField.ElementAt(7);
            _gameField.ElementAt(7).Next = _gameField.ElementAt(8);
            _gameField.ElementAt(8).Next = _gameField.ElementAt(9);
            _gameField.ElementAt(9).Next = _gameField.ElementAt(10);
            _gameField.ElementAt(10).Next = _gameField.ElementAt(11);
            _gameField.ElementAt(11).Next = _gameField.ElementAt(12);

            _gameField.ElementAt(40).Next = _gameField.ElementAt(41);
            _gameField.ElementAt(41).Next = _gameField.ElementAt(42);
            _gameField.ElementAt(42).Next = _gameField.ElementAt(55);
            _gameField.ElementAt(55).Next = _gameField.ElementAt(56);
            _gameField.ElementAt(56).Next = _gameField.ElementAt(57);


            _gameField.ElementAt(57).Next = _gameField.ElementAt(44);

            _gameField.ElementAt(44).Next = _gameField.ElementAt(45);
            _gameField.ElementAt(45).Next = _gameField.ElementAt(46);
            _gameField.ElementAt(46).Next = _gameField.ElementAt(47);
            _gameField.ElementAt(47).Next = _gameField.ElementAt(48);
            _gameField.ElementAt(48).Next = _gameField.ElementAt(61);
            _gameField.ElementAt(61).Next = _gameField.ElementAt(62);
            _gameField.ElementAt(62).Next = _gameField.ElementAt(63);
            _gameField.ElementAt(63).Next = _gameField.ElementAt(50);
            _gameField.ElementAt(50).Next = _gameField.ElementAt(37);
            _gameField.ElementAt(37).Next = _gameField.ElementAt(24);
            _gameField.ElementAt(24).Next = _gameField.ElementAt(23);
            _gameField.ElementAt(23).Next = _gameField.ElementAt(22);
            _gameField.ElementAt(22).Next = _gameField.ElementAt(21);
            _gameField.ElementAt(21).Next = _gameField.ElementAt(20);
            _gameField.ElementAt(20).Next = _gameField.ElementAt(19);
            _gameField.ElementAt(19).Next = _gameField.ElementAt(18);
            _gameField.ElementAt(18).Next = _gameField.ElementAt(17);
            _gameField.ElementAt(17).Next = _gameField.ElementAt(16);
            _gameField.ElementAt(16).Next = _gameField.ElementAt(15);
            _gameField.ElementAt(15).Next = _gameField.ElementAt(14);
            _gameField.ElementAt(14).Next = _gameField.ElementAt(13);

            _gameField.ElementAt(57).Next = _gameField.ElementAt(70);
            _gameField.ElementAt(70).Next = _gameField.ElementAt(71);
            _gameField.ElementAt(71).Next = _gameField.ElementAt(84);
            _gameField.ElementAt(84).Next = _gameField.ElementAt(85);



            _gameField.ElementAt(85).Next = _gameField.ElementAt(86);
            _gameField.ElementAt(86).Next = _gameField.ElementAt(73);
            _gameField.ElementAt(73).Next = _gameField.ElementAt(74);
            _gameField.ElementAt(74).Next = _gameField.ElementAt(61);

            _gameField.ElementAt(86).Next = _gameField.ElementAt(99);
            _gameField.ElementAt(99).Next = _gameField.ElementAt(100);
            _gameField.ElementAt(100).Next = _gameField.ElementAt(101);
            _gameField.ElementAt(101).Next = _gameField.ElementAt(102);
            _gameField.ElementAt(102).Next = _gameField.ElementAt(115);
            _gameField.ElementAt(115).Next = _gameField.ElementAt(114);
            _gameField.ElementAt(114).Next = _gameField.ElementAt(113);
            _gameField.ElementAt(113).Next = _gameField.ElementAt(112);
            _gameField.ElementAt(112).Next = _gameField.ElementAt(111);
            _gameField.ElementAt(111).Next = _gameField.ElementAt(110);
            _gameField.ElementAt(110).Next = _gameField.ElementAt(109);
            _gameField.ElementAt(109).Next = _gameField.ElementAt(108);
            _gameField.ElementAt(108).Next = _gameField.ElementAt(107);
            _gameField.ElementAt(107).Next = _gameField.ElementAt(106);
            _gameField.ElementAt(106).Next = _gameField.ElementAt(105);

            _gameField.ElementAt(66).Next = _gameField.ElementAt(67);
            _gameField.ElementAt(67).Next = _gameField.ElementAt(68);
            _gameField.ElementAt(68).Next = _gameField.ElementAt(55);

            _gameField.ElementAt(92).Next = _gameField.ElementAt(93);
            _gameField.ElementAt(93).Next = _gameField.ElementAt(94);
            _gameField.ElementAt(94).Next = _gameField.ElementAt(95);
            _gameField.ElementAt(95).Next = _gameField.ElementAt(96);
            _gameField.ElementAt(96).Next = _gameField.ElementAt(97);
            _gameField.ElementAt(97).Next = _gameField.ElementAt(84);

        }

        public LinkedList<Field> getGameField()
        {
            return this._gameField;
        }

        public Player getPlayer()
        {
            return this._player;
        }

        public void run()
        {
            Random rnd = new Random();
            List<Field> moveAbleList = new List<Field>();
            List<Field> warehouseList = new List<Field>();
            int shipCount = 0;

            var currentLink = _gameField.Last.Previous;
            {
                while(currentLink != null)
                {
                    var currentField = currentLink.Value;

                    if (((Field)currentField).MoveAbleObject != null)
                    {
                        moveAbleList.Add(currentField.MoveAbleObject);
                        ((Field)currentField).Action(this);

                        if (currentField.MoveAbleObject is Ship)
                            shipCount++;
                    }

                    if (shipCount <= 1)
                        spawnShip(currentField);

                    if (currentField is Warehouse)
                        warehouseList.Add(currentField);
                    
                    if (currentField is Field)
                    {
                        currentLink = currentLink.Previous;
                    }
                    
                }

                foreach (var item in moveAbleList)
                {
                    ((MoveAbleObject)item).move(this);
                }

                System.Threading.Thread.Sleep(1);
                int r = rnd.Next(0, 3);

                if (r != prevRandom)
                    randomCart(warehouseList.ElementAt(r));

                prevRandom = r;

            }
        }

        public void spawnShip(BaseField currentField)
        {
            if (currentField is WaterField && currentField.Pos == 0)
            {
                _field = (WaterField)currentField.NextField;
                _field.PutMoveAbleObjectOnThisField(new Ship(), this);
            }
        }

        public void randomCart(BaseField currentField)
        {
            _field = (Track)currentField.NextField;
            _field.PutMoveAbleObjectOnThisField(new Cart(), this);
        }

    }
}
 
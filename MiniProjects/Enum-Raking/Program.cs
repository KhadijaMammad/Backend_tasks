using System;
using System.Collections.Generic;

namespace SumTenGame
{
    enum Rank
    {
        Bronse,
        Silver,
        Golden,
        Platinum,
        Diamond
    }
    class Board
    {
        private int[,] _grid;
        private int _rows;
        private int _cols;
        private Random _rng;

        public Board(int rows, int cols)
        {
            _rows = rows;
            _cols = cols;
            _rng = new Random();
            _grid = new int[rows, cols];
            FillALlBoard();

        }

        private void FillALlBoard()
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    _grid[i, j] = _rng.Next(1, 10);
                }
            }
        }

        public void DisplayBoard()
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    Console.Write(_grid[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public bool TryRemoveAndAgainSum10(int r1, int c1, int r2, int c2)
        {
            if (!isValid(r1, c1) || !isValid(r2, c2))
                return false;
            if (_grid[r1, c1] + _grid[r2, c2] != 10)
                return false;
            _grid[r1, c1] = _rng.Next(1, 10);
            _grid[r2, c2] = _rng.Next(1, 10);
            return true;
        }

        private bool isValid(int i, int j)
        {
            return i >= 0 && 1 < _rows && j >= 0 && j < _cols;
        }

    }
    class Game
    {
        private Board _board;
        private int _score;
        private int _lives;
        private int _moves;

        public Game(int rowa = 7, int cols = 7, int lives = 3)
        {
            _board = new Board(7, 7);
            _score = 0;
            _lives = lives;
            _moves = 0;
        }

        private Rank GetRank()
        {
            if (_score < 20)
                return Rank.Bronse;
            else if (_score < 50)
                return Rank.Silver;
            else if (_score < 80)
                return Rank.Golden;
            else if (_score < 100)
                return Rank.Platinum;
            else
                return Rank.Diamond;
        }

        public void GameRun()
        {
            Console.WriteLine("Welcome to Adjacent Game");
            Console.WriteLine("The sum of two adjacent numbers must be 10. Press 'q' to quit");
            while (_lives > 0 && _score < 120)
            {
                Console.WriteLine($"Score: {_score}, Lives: {_lives}, Moves: {_moves}, Rank: {GetRank()}");
                _board.DisplayBoard();

                Console.WriteLine("Enter the coordinates of the first cell (row and column): r1 c1 r2 c2 ");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    continue;
                if (input.ToLower() == "q")
                    break;

                    var parts = input.Split(' ');
                if (parts.Length != 4 ||
                    !int.TryParse(parts[0], out int r1) ||
                    !int.TryParse(parts[1], out int c1) ||
                    !int.TryParse(parts[2], out int r2) ||
                    !int.TryParse(parts[3], out int c2))
                {
                    Console.WriteLine("Invalid input. Please enter four integers separated by spaces.");
                    continue;
                }

                if (_board.TryRemoveAndAgainSum10(r1, c1, r2, c2))
                {
                    _score += 10;
                    _moves++;
                    Console.WriteLine("Good move! +10 points.");
                }
                else
                {
                    _score -= 5;
                    _lives--;
                    _moves++;
                    Console.WriteLine("Bad move! -5 score and -1 life.");
                }
            }

            Console.WriteLine($"Game Over! Final Score: {_score}, Moves: {_moves}, Rank: {GetRank()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.GameRun();
        }
    }
}
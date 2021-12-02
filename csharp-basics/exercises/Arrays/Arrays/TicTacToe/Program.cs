using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];
        private static int player = 1;

        private static void Main(string[] args)
        {
            InitBoard();

            while (true)
            {
                DisplayBoard();

                if (CheckForWinner()) {Console.WriteLine("Player {0} has won the game! Press enter to exit.", player); break; }

                if (isDraw()) { Console.WriteLine("The game is a tie! Press enter to exit."); break; }

                GameLogic();
                Console.Clear();
            }

            Console.Read();
        }

        private static void GameLogic()
        {
            if (CheckForWinner()) { return; }

            if (player == 1)
            {
                Console.Write("'X', choose your location (row, column): ");

                if (AcceptTurn('X'))
                {
                    player = 2;
                }
            }
            else
            {
                Console.Write("'O', choose your location (row, column): ");

                if (AcceptTurn('O'))
                {
                    player = 1;
                }
            }
        }

        private static bool isDraw()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (board[row, col] == ' ') { return false; }
                }
            }

            return true;
        }

        private static bool AcceptTurn(char playerChar)
        {
            var input = Console.ReadLine();

            /* Gets 2 coordinates from the input, user can enter:
              
               *) 0 0
               *) (0, 0)
               *) 0    0
               *) 0 asdasd 0
               *) asd0d0
               *) asd 0 0

               and either way it will accept the 0 0 coordinates, by ignoring
               everything that is not an int.

               However if user inserts 3+ integers, it will take just the first two 
               integers as the coordinates, and if only 1 integer, then it will duplicate it
               such as input = 1, coordinates = 1,1, if no integer entered, turn will not be accepted.
             */

            int[] coordinates = new int[2];
            int num, indexOfCoordinate = 0;
            bool hasInt = false;

            if (input.Length == 0) { return false; }

            for (int i = 0; i < 2; i++)
            {
                for (int j = indexOfCoordinate; j < input.Length; j++)
                {
                    if (int.TryParse((input[j].ToString()), out num))
                    {
                        hasInt = true;
                        coordinates[i] = num;
                        // begin next loop from the position where the first int was found
                        indexOfCoordinate = j + 1;
                        break;
                    }
                }
            }

            // do not accept turn if the input doesn't contain any integers
            if (!hasInt) { return false; }

            int row = coordinates[0];
            int col = coordinates[1];

            if (board[row, col] == ' ') { board[row, col] = playerChar; return true; }
            else { Console.WriteLine("Cell {0}:{1} Taken", row, col); return false; }
        }

        private static void InitBoard()
        {
            // fills up the board with blanks
            for (var row = 0; row < 3; row++)
            {
                for (var col = 0; col < 3; col++)
                    board[row, col] = ' ';
            }
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("Player 2 = 'X' \nPlayer 1 = 'O'\n");
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
        }

        private static bool CheckForWinner()
        {
            char playerSymbol = player == 1 ? 'O' : 'X';

            if (
            (board[0, 1].Equals(playerSymbol) && board[1, 1].Equals(playerSymbol) && board[2, 1].Equals(playerSymbol)) ||
            (board[0, 2].Equals(playerSymbol) && board[1, 2].Equals(playerSymbol) && board[2, 2].Equals(playerSymbol)) ||
            (board[0, 0].Equals(playerSymbol) && board[1, 0].Equals(playerSymbol) && board[2, 0].Equals(playerSymbol)) ||
            (board[0, 0].Equals(playerSymbol) && board[0, 1].Equals(playerSymbol) && board[0, 2].Equals(playerSymbol)) ||
            (board[1, 0].Equals(playerSymbol) && board[1, 1].Equals(playerSymbol) && board[1, 2].Equals(playerSymbol)) ||
            (board[2, 0].Equals(playerSymbol) && board[2, 1].Equals(playerSymbol) && board[2, 2].Equals(playerSymbol)) ||
            (board[2, 0].Equals(playerSymbol) && board[1, 1].Equals(playerSymbol) && board[0, 2].Equals(playerSymbol)) ||
            (board[0, 0].Equals(playerSymbol) && board[1, 1].Equals(playerSymbol) && board[2, 2].Equals(playerSymbol))
            ){
                return true;
            }

            return false;
        }
    }
}

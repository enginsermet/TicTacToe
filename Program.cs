using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading;
using System.Media;


namespace TicTacToe
{
    class Program
    {
        static char a = 'A', b = 'B', c = 'C', d = 'D', e = 'E', f = 'F', g = 'G', h = 'H', i = 'I';
        static char pos = ' ';

        static char player1 = '\0';
        static char player2 = '\0';

        static ConsoleKeyInfo cki, posKey;

        static Boolean isFound = false;
        static Boolean isEmpty = false;

        public static char ShowStatus(ConsoleKeyInfo key)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[Ready]");
            return key.KeyChar;
        }

        public static void FirstPlayerWins()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n Player 1 ");
            Console.ResetColor();
            Console.Write("wins!");
            Console.WriteLine(" ");
            Thread.Sleep(5000);
            Console.Clear();
            System.Environment.Exit(1);     
        }

        public static void SecondPlayerWins()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\n Player 2 ");
            Console.ResetColor();
            Console.Write("wins!");
            Console.WriteLine(" ");
            Thread.Sleep(5000);
            System.Environment.Exit(1);
        }

        public static void PositionIsEmpty()
        {
            PlayGame();
            isEmpty = true;
            isFound = true;
        }

        public static void FirstPlayerPositionNotEmpty()
        {
            isEmpty = false;
            SystemSounds.Asterisk.Play();
            Console.WriteLine("\n This position is not empty!");
            Console.WriteLine("\n Player 1's turn");
            Console.Write(" ");
            Console.WriteLine(new string('=', 17));
            Console.Write(" Select a position: ");
            posKey = Console.ReadKey();
            pos = posKey.KeyChar;                                                            
        }

        public static void SecondPlayerPositionNotEmpty()
        {
            isEmpty = false;
            SystemSounds.Asterisk.Play();
            Console.WriteLine("\n This position is not empty!");
            Console.WriteLine("\n Player 2's turn");
            Console.Write(" ");
            Console.WriteLine(new string('=', 17));
            Console.Write(" Select a position: ");
            posKey = Console.ReadKey();
            pos = posKey.KeyChar;
        }

        public static void PlayGame()
        {
            Console.Clear();

            Console.Title = "Tic Tac Toe Game";

            Console.WriteLine();
            Console.WriteLine($"   {a}  |  {b}  |  {c}");
            Console.WriteLine($" _____|_____|_____");
            Console.WriteLine($"      |     |");
            Console.WriteLine($"   {d}  |  {e}  |  {f}");
            Console.WriteLine($" _____|_____|_____");
            Console.WriteLine($"      |     |");
            Console.WriteLine($"   {g}  |  {h}  |  {i}");
            Console.WriteLine($" _____|_____|_____");
            Console.WriteLine($"      |     |");

            if (a == 'X' && b == 'X' && c == 'X')
            {
                FirstPlayerWins();
            }
            else if (d == 'X' && e == 'X' && f == 'X')
            {
                FirstPlayerWins();
            }
            else if (g == 'X' && h == 'X' && i == 'X')
            {
                FirstPlayerWins();              
            }
            else if (a == 'X' && d == 'X' && g == 'X')
            {
                FirstPlayerWins();
            }
            else if (b == 'X' && e == 'X' && h == 'X')
            {
                FirstPlayerWins();
            }
            else if (c == 'X' && f == 'X' && i == 'X')
            {
                FirstPlayerWins();
            }
            else if (a == 'X' && e == 'X' && i == 'X')
            {
                FirstPlayerWins();
            }
            else if (c == 'X' && e == 'X' && g == 'X')
            {
                FirstPlayerWins();
            }

            else if (a == 'O' && b == 'O' && c == 'O')
            {
                SecondPlayerWins();
            }
            else if (d == 'O' && e == 'O' && f == 'O')
            {
                SecondPlayerWins();
            }
            else if (g == 'O' && h == 'O' && i == 'O')
            {
                SecondPlayerWins();
            }
            else if (a == 'O' && d == 'O' && g == 'O')
            {
                SecondPlayerWins();
            }
            else if (b == 'O' && e == 'O' && h == 'O')
            {
                SecondPlayerWins();
            }
            else if (c == 'O' && f == 'O' && i == 'O')
            {
                SecondPlayerWins();
            }
            else if (a == 'O' && e == 'O' && i == 'O')
            {
                SecondPlayerWins();
            }
            else if (c == 'O' && e == 'O' && g == 'O')
            {
                SecondPlayerWins();
            }
            else
            {
                if (a != 'A' && b != 'B' && c != 'C' && d != 'D' && e != 'E' && f != 'F' && g != 'G' && h != 'H' && i != 'I')
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n Draw!");
                    Console.WriteLine(" ");
                    Console.ResetColor();
                    Thread.Sleep(5000);
                    System.Environment.Exit(1);
                }
            }
        }

        public static void StartGame()
        {
            Console.Clear();
            a = 'A'; b = 'B'; c = 'C'; d = 'D'; e = 'E'; f = 'F'; g = 'G'; h = 'H'; i = 'I';

            Console.WriteLine();
            Console.WriteLine($"   {a}  |  {b}  |  {c}");
            Console.WriteLine($" _____|_____|_____");
            Console.WriteLine($"      |     |");
            Console.WriteLine($"   {d}  |  {e}  |  {f}");
            Console.WriteLine($" _____|_____|_____");
            Console.WriteLine($"      |     |");
            Console.WriteLine($"   {g}  |  {h}  |  {i}");
            Console.WriteLine($" _____|_____|_____");
            Console.WriteLine($"      |     |");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n Player 1");
            Console.ResetColor();
            Console.Write(" [Unready] | Please press any key to start: ");

            cki = Console.ReadKey();
            player1 = cki.KeyChar;

            Console.SetCursorPosition(0, 11);

            Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" Player 1 ");
            Console.ResetColor();
            ShowStatus(cki);
            player1 = cki.KeyChar;

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\n Player 2");
            Console.ResetColor();
            Console.Write(" [Unready] | Please press any key to start: ");

            cki = Console.ReadKey();
            Console.SetCursorPosition(0, 13);
            Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" Player 2 ");
            Console.ResetColor();
            ShowStatus(cki);
            Console.ResetColor();
            player2 = cki.KeyChar;
        }

        static void Main(string[] args)
        {
            StartGame();
            
            Console.WriteLine();
            
            for (int turn = 0; turn < 10; turn++)
            {
                isFound = false;
                isEmpty = false;
            
                if (turn % 2 == 0)
                {
                    Console.WriteLine("\n Player 1's turn");
                    Console.Write(" ");
                    Console.WriteLine(new string('=', 17));
                    Console.Write(" Select a position: ");
                    posKey = Console.ReadKey();
                    pos = posKey.KeyChar;
            
                    while (!isFound && !isEmpty)
                    {
                        switch (pos)
                        {
                            case 'a': case 'A':
                                if (a != 'O' && a != 'X')
                                {
                                    a = 'X';
                                    PositionIsEmpty();
                                }
                                else
                                {
                                    FirstPlayerPositionNotEmpty();
                                }
                                break;
            
                            case 'b': case 'B':
                                if (b != 'O' && b != 'X')
                                {
                                    b = 'X';
                                    PositionIsEmpty();
                                }
                                else
                                {
                                    FirstPlayerPositionNotEmpty();
                                }
                                break;
            
                            case 'c': case 'C':
                                if (c != 'O' && c != 'X')
                                {
                                    c = 'X';
                                    PositionIsEmpty();
                                }
                                else
                                {
                                    FirstPlayerPositionNotEmpty();
                                }
                                break;
            
                            case 'd': case 'D':
                                if (d != 'O' && d != 'X')
                                {
                                    d = 'X';
                                    PositionIsEmpty();
                                }
                                else
                                {
                                    FirstPlayerPositionNotEmpty();
                                }
                                break;
            
                            case 'e': case 'E':
                                if (e != 'O' && e != 'X')
                                {
                                    e = 'X';
                                    PositionIsEmpty();
                                }
                                else
                                {
                                    FirstPlayerPositionNotEmpty();
                                }
                                break;
            
                            case 'f': case 'F':
                                if (f != 'O' && f != 'X')
                                {
                                    f = 'X';
                                    PositionIsEmpty();
                                }
                                else
                                {
                                    FirstPlayerPositionNotEmpty();
                                }
                                break;
            
                            case 'g': case 'G':
                                if (g != 'O' && g != 'X')
                                {
                                    g = 'X';
                                    PositionIsEmpty();
                                }
                                else
                                {
                                    FirstPlayerPositionNotEmpty();
                                }
                                break;
            
                            case 'h': case 'H':
                                if (h != 'O' && h != 'X')
                                {
                                    h = 'X';
                                    PositionIsEmpty();
                                }
                                else
                                {
                                    FirstPlayerPositionNotEmpty();
                                }
                                break;
            
                            case 'i': case 'I':
                                if (i != 'O' && i != 'X')
                                {
                                    i = 'X';
                                    PositionIsEmpty();
                                }
                                else
                                {
                                    FirstPlayerPositionNotEmpty();
                                }
            
                                break;
            
                            default:
                                isFound = false;
                                SystemSounds.Asterisk.Play();
                                Console.WriteLine("\n Please select a position between a and i");
                                Console.WriteLine("\n Player 1's turn");
                                Console.Write(" ");
                                Console.WriteLine(new string('=', 17));
                                Console.Write(" Select a position: ");
                                posKey = Console.ReadKey();
                                pos = posKey.KeyChar;
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\n Player 2's turn");
                    Console.Write(" ");
                    Console.WriteLine(new string('=', 17));
                    Console.Write(" Select a position: ");
                    posKey = Console.ReadKey();
                    pos = posKey.KeyChar;
            
                    while (!isFound)
                    {
                        switch (pos)
                        {
                            case 'a': case 'A':
                                if (a != 'X' && a != 'O')
                                {
                                    a = 'O';
                                    PositionIsEmpty();
                                }
                                else
                                {
                                    SecondPlayerPositionNotEmpty();
                                }
                                break;
            
                            case 'b': case 'B':
                                if (b != 'X' && b != 'O')
                                {
                                    b = 'O';
                                    PositionIsEmpty();
                                }
                                else
                                {
                                    SecondPlayerPositionNotEmpty();
                                }
                                break;
            
                            case 'c': case 'C':
                                if (c != 'X' && c != 'O')
                                {
                                    c = 'O';
                                    PositionIsEmpty();
                                }
                                else
                                {
                                    SecondPlayerPositionNotEmpty();
                                }
                                break;
            
                            case 'd': case 'D':
                                if (d != 'X' && d != 'O')
                                {
                                    d = 'O';
                                    PositionIsEmpty();
                                }
                                else
                                {
                                    SecondPlayerPositionNotEmpty();
                                }
                                break;
            
                            case 'e': case 'E':
                                if (e != 'X' && e != 'O')
                                {
                                    e = 'O';
                                    PositionIsEmpty();
                                }
                                else
                                {
                                    SecondPlayerPositionNotEmpty();
                                }
                                break;
            
                            case 'f': case 'F':
                                if (f != 'X' && f != 'O')
                                {
                                    f = 'O';
                                    PositionIsEmpty();
                                }
                                else
                                {
                                    SecondPlayerPositionNotEmpty();
                                }
                                break;
            
                            case 'g': case 'G':
            
                                if (g != 'X' && g != 'O')
                                {
                                    g = 'O';
                                    PositionIsEmpty();
                                }
                                else
                                {
                                    SecondPlayerPositionNotEmpty();
                                }
                                break;
            
                            case 'h': case 'H':
                                if (h != 'X' && h != 'O')
                                {
                                    h = 'O';
                                    PositionIsEmpty();
                                }
                                else
                                {
                                    SecondPlayerPositionNotEmpty();
                                }
                                break;
            
                            case 'i': case 'I':
                                if (i != 'X' && i != 'O')
                                {
                                    i = 'O';
                                    PositionIsEmpty();
                                }
                                else
                                {
                                    SecondPlayerPositionNotEmpty();
                                }
                                break;
            
                            default:
                                isFound = false;
                                SystemSounds.Asterisk.Play();
                                Console.WriteLine("\n Please select a position between a and i");
                                Console.WriteLine("\n Player 2's turn");
                                Console.Write(" ");
                                Console.WriteLine(new string('=', 17));
                                Console.Write(" Select a position: ");
                                posKey = Console.ReadKey();
                                pos = posKey.KeyChar;
                                break;
                        }
                    }
                }
            }
        }
    }
}
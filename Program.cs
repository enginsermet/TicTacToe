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

        public static char Status(ConsoleKeyInfo key)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[Ready]");
            return key.KeyChar;
        }

        public static void Game()
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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n Player 1 ");
                Console.ResetColor();
                Console.Write("wins!");
                Console.WriteLine(" ");
                Thread.Sleep(5000);
                Console.Clear();
                System.Environment.Exit(1);
            }
            else if (d == 'X' && e == 'X' && f == 'X')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n Player 1 ");
                Console.ResetColor();
                Console.Write("wins!");
                Console.WriteLine(" ");
                Thread.Sleep(5000);
                System.Environment.Exit(1);
            }
            else if (g == 'X' && h == 'X' && i == 'X')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n Player 1 ");
                Console.ResetColor();
                Console.Write("wins!");
                Console.WriteLine(" ");
                Thread.Sleep(5000);
                System.Environment.Exit(1);
            }
            else if (a == 'X' && d == 'X' && g == 'X')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n Player 1 ");
                Console.ResetColor();
                Console.Write("wins!");
                Console.WriteLine(" ");
                Thread.Sleep(5000);
                System.Environment.Exit(1);
            }
            else if (b == 'X' && e == 'X' && h == 'X')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n Player 1 ");
                Console.ResetColor();
                Console.Write("wins!");
                Console.WriteLine(" ");
                Thread.Sleep(5000);
                System.Environment.Exit(1);
            }
            else if (c == 'X' && f == 'X' && i == 'X')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n Player 1 ");
                Console.ResetColor();
                Console.Write("wins!");
                Console.WriteLine(" ");
                Thread.Sleep(5000);
                System.Environment.Exit(1);
            }
            else if (a == 'X' && e == 'X' && i == 'X')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n Player 1 ");
                Console.ResetColor();
                Console.Write("wins!");
                Console.WriteLine(" ");
                Thread.Sleep(5000);
                System.Environment.Exit(1);
            }
            else if (c == 'X' && e == 'X' && g == 'X')
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n Player 1 ");
                Console.ResetColor();
                Console.Write("wins!");
                Console.WriteLine(" ");
                Thread.Sleep(5000);
                System.Environment.Exit(1);
            }

            else if (a == 'O' && b == 'O' && c == 'O')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\n Player 2 ");
                Console.ResetColor();
                Console.Write("wins!");
                Console.WriteLine(" ");
                Thread.Sleep(5000);
                System.Environment.Exit(1);
            }
            else if (d == 'O' && e == 'O' && f == 'O')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\n Player 2 ");
                Console.ResetColor();
                Console.Write("wins!");
                Console.WriteLine(" ");
                Thread.Sleep(5000);
                System.Environment.Exit(1);
            }
            else if (g == 'O' && h == 'O' && i == 'O')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\n Player 2 ");
                Console.ResetColor();
                Console.Write("wins!");
                Console.WriteLine(" ");
                Thread.Sleep(5000);
                System.Environment.Exit(1);
            }
            else if (a == 'O' && d == 'O' && g == 'O')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\n Player 2 ");
                Console.ResetColor();
                Console.Write("wins!");
                Console.WriteLine(" ");
                Thread.Sleep(5000);
                System.Environment.Exit(1);
            }
            else if (b == 'O' && e == 'O' && h == 'O')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\n Player 2 ");
                Console.ResetColor();
                Console.Write("wins!");
                Console.WriteLine(" ");
                Thread.Sleep(5000);
                System.Environment.Exit(1);
            }
            else if (c == 'O' && f == 'O' && i == 'O')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\n Player 2 ");
                Console.ResetColor();
                Console.Write("wins!");
                Console.WriteLine(" ");
                Thread.Sleep(5000);
                System.Environment.Exit(1);
            }
            else if (a == 'O' && e == 'O' && i == 'O')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\n Player 2 ");
                Console.ResetColor();
                Console.Write("wins!");
                Console.WriteLine(" ");
                Thread.Sleep(5000);
                System.Environment.Exit(1);
            }
            else if (c == 'O' && e == 'O' && g == 'O')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\n Player 2 ");
                Console.ResetColor();
                Console.Write("wins!");
                Console.WriteLine(" ");
                Thread.Sleep(5000);
                System.Environment.Exit(1);
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

        public static void Start()
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
            Status(cki);
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
            Status(cki);
            Console.ResetColor();
            player2 = cki.KeyChar;
        }

        static void Main(string[] args)
        {
                Start();

                Console.WriteLine();

                Boolean isFound = false;
                Boolean isEmpty = false;


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
                                        Game();
                                        isEmpty = true;
                                        isFound = true;
                                    }
                                    else
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
                                    break;

                                case 'b': case 'B':
                                    if (b != 'O' && b != 'X')
                                    {
                                        b = 'X';
                                        Game();
                                        isEmpty = true;
                                        isFound = true;
                                    }
                                    else
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
                                    break;

                                case 'c': case 'C':
                                    if (c != 'O' && c != 'X')
                                    {
                                        c = 'X';
                                        Game();
                                        isEmpty = true;
                                        isFound = true;
                                    }
                                    else
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
                                    break;

                                case 'd': case 'D':
                                    if (d != 'O' && d != 'X')
                                    {
                                        d = 'X';
                                        Game();
                                        isEmpty = true;
                                        isFound = true;
                                    }
                                    else
                                    {
                                        isEmpty = false;
                                        SystemSounds.Asterisk.Play();
                                        Console.WriteLine("\n This position is not empty!");
                                        Console.WriteLine("\n Player 1's turn");
                                        Console.Write(" "); ;
                                        Console.WriteLine(new string('=', 17));
                                        Console.Write(" Select a position: ");
                                        posKey = Console.ReadKey();
                                        pos = posKey.KeyChar;
                                    }
                                    break;

                                case 'e': case 'E':
                                    if (e != 'O' && e != 'X')
                                    {
                                        e = 'X';
                                        Game();
                                        isEmpty = true;
                                        isFound = true;
                                    }
                                    else
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
                                    break;

                                case 'f': case 'F':
                                    if (f != 'O' && f != 'X')
                                    {
                                        f = 'X';
                                        Game();
                                        isEmpty = true;
                                        isFound = true;
                                    }
                                    else
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
                                    break;

                                case 'g': case 'G':
                                    if (g != 'O' && g != 'X')
                                    {
                                        g = 'X';
                                        Game();
                                        isEmpty = true;
                                        isFound = true;
                                    }
                                    else
                                    {
                                        isEmpty = false;
                                        Console.WriteLine("\n This position is not empty!");
                                        Console.WriteLine("\n Player 1's turn");
                                        Console.Write(" "); ;
                                        Console.WriteLine(new string('=', 17));
                                        Console.Write(" Select a position: ");
                                        posKey = Console.ReadKey();
                                        pos = posKey.KeyChar;
                                    }
                                    break;

                                case 'h': case 'H':
                                    if (h != 'O' && h != 'X')
                                    {
                                        h = 'X';
                                        Game();
                                        isEmpty = true;
                                        isFound = true;
                                    }
                                    else
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
                                    break;

                                case 'i': case 'I':
                                    if (i != 'O' && i != 'X')
                                    {
                                        i = 'X';
                                        Game();
                                        isEmpty = true;
                                        isFound = true;
                                    }
                                    else
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
                                        Game();
                                        isEmpty = true;
                                        isFound = true;
                                    }
                                    else
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
                                    break;

                                case 'b': case 'B':
                                    if (b != 'X' && b != 'O')
                                    {
                                        b = 'O';
                                        Game();
                                        isEmpty = true;
                                        isFound = true;
                                    }
                                    else
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
                                    break;

                                case 'c': case 'C':
                                    if (c != 'X' && c != 'O')
                                    {
                                        c = 'O';
                                        Game();
                                        isEmpty = true;
                                        isFound = true;
                                    }
                                    else
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
                                    break;

                                case 'd': case 'D':
                                    if (d != 'X' && d != 'O')
                                    {
                                        d = 'O';
                                        Game();
                                        isEmpty = true;
                                        isFound = true;
                                    }
                                    else
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
                                    break;

                                case 'e': case 'E':
                                    if (e != 'X' && e != 'O')
                                    {
                                        e = 'O';
                                        Game();
                                        isEmpty = true;
                                        isFound = true;
                                    }
                                    else
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
                                    break;

                                case 'f': case 'F':
                                    if (f != 'X' && f != 'O')
                                    {
                                        f = 'O';
                                        Game();
                                        isEmpty = true;
                                        isFound = true;
                                    }
                                    else
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
                                    break;

                                case 'g': case 'G':

                                    if (g != 'X' && g != 'O')
                                    {
                                        g = 'O';
                                        Game();
                                        isEmpty = true;
                                        isFound = true;
                                    }
                                    else
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
                                    break;

                                case 'h': case 'H':
                                    if (h != 'X' && h != 'O')
                                    {
                                        h = 'O';
                                        Game();
                                        isEmpty = true;
                                        isFound = true;
                                    }
                                    else
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
                                    break;

                                case 'i': case 'I':
                                    if (i != 'X' && i != 'O')
                                    {
                                        i = 'O';
                                        Game();
                                        isEmpty = true;
                                        isFound = true;
                                    }
                                    else
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



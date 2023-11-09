using pr7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr7
{
    internal class Menu
    {

        public static int Cursor(int minstr, int maxstr)
        {

            ConsoleKeyInfo cursor;
            int position = 1;
            do
            {

                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                cursor = Console.ReadKey();

                Console.SetCursorPosition(0, position);
                Console.WriteLine("  ");

                if (cursor.Key == ConsoleKey.DownArrow && position != maxstr)
                {
                    position++;
                }

                if (cursor.Key == ConsoleKey.UpArrow && position != minstr)
                {
                    position--;
                }
                if (cursor.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Comp.drives();
                }
                Console.SetCursorPosition(1, position);

            } while (cursor.Key != ConsoleKey.Enter);
            return position;

        }
    }
}
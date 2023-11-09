using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr7
{
    internal class Comp
    {
        public static void drives()
        {
            try
            {
                Console.WriteLine("Ваши диски: ");
                foreach (var drive in DriveInfo.GetDrives())
                {
                    Console.WriteLine("  " + drive + "Всего места: " + (drive.TotalSize) / 1073741824 + " Доступно: " + (drive.AvailableFreeSpace) / 1073741824);
                }
                int pos = Menu.Cursor(1, DriveInfo.GetDrives().Length);

                if (pos == 1)
                {
                    rasniepapki("C:\\");

                }
                else if (pos == 2)
                {
                    rasniepapki("D:\\");
                }
                else if (pos == 3)
                {
                    rasniepapki("E:\\");
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Ошибка! Нажмите Enter, чтобы продолжить");
                Console.ReadLine();
                Console.Clear();
                drives();
            }
      
        }


        private static void rasniepapki(string pa)
        {
            try
            { 
                Console.Clear(); 
                string[] paths = Directory.GetDirectories(pa);
                string[] pathsFiles = Directory.GetFiles(pa);
                DateTime dt = Directory.GetCreationTime(Environment.CurrentDirectory);
                Console.WriteLine("Путь: " + pa);
                foreach (string path in paths)
                { 
                    Console.WriteLine("  " + path + "\t" + dt);
                }
                foreach (string files in pathsFiles)
                {
                    Console.WriteLine("  " + files + "\t" + dt + "\t" + Path.GetExtension(files));
                    
                }

                int pos = Menu.Cursor(1, paths.Length + pathsFiles.Length);

                rasniepapki(paths[pos - 1]);
                   
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Ошибка! Нажмите Enter, чтобы продолжить");
                Console.ReadLine();
                Console.Clear();
                drives();
            }
        }



        private static void opensht(string files)
        {
            Process.Start(new ProcessStartInfo { FileName = files, UseShellExecute = true });
            //Не работает открытие файла
        }
        

    }
}


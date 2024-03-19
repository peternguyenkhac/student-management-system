using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Utils
{
    public static class ViewHelper
    {
        public static void WriteLine(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void Write(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }

        public static string ReadLine(string label)
        {
            Write($"{label}: ");
            string strResult = Console.ReadLine();
            return strResult;
        }
        
        public static int ReadInt(string label) 
        {
            Write($"{label}: ");
            int intResult = Convert.ToInt32(Console.ReadLine());
            return intResult;
        }
        public static double ReadDouble(string label)
        {
            Write($"{label}: ");
            double intResult = Convert.ToDouble(Console.ReadLine());
            return intResult;
        }

        public static bool ReadBool(string label) 
        {
            Write($"{label} [y/n]: ");
            ConsoleKeyInfo key = Console.ReadKey();
            if(key.KeyChar == 'y' || key.KeyChar == 'Y')
            {
                return true;
            }
            return false;
        }

        public static DateTime ReadDatetime(string label)
        {
            Write($"{label} (dd/mm/yyyy): ");
            DateTime dateTimeResult = Convert.ToDateTime(Console.ReadLine());
            return dateTimeResult;
        }
    }
}

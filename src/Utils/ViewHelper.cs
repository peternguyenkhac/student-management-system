using System;
using System.Collections;
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

        public static void Clear()
        {
            Console.Clear();
        }

        public static string ReadLine(string label, string oldValue = null)
        {
            Write($"{label}: ");
            string strResult = Console.ReadLine();
            if (string.IsNullOrEmpty(strResult) && !string.IsNullOrEmpty(oldValue)) 
            {
                return oldValue;
            }
            return strResult;
        }
        
        public static int ReadInt(string label, int? oldValue = null) 
        {
            Write($"{label}: ");
            string strInput = Console.ReadLine();
            if (string.IsNullOrEmpty(strInput) && oldValue != null)
            {
                return (int)oldValue;
            }
            int intResult = Convert.ToInt32(strInput);
            return intResult;
        }
        public static double ReadDouble(string label, double? oldValue = null)
        {
            Write($"{label}: ");
            string strInput = Console.ReadLine();
            if (string.IsNullOrEmpty(strInput) && oldValue != null)
            {
                return (double)oldValue;
            }
            double intResult = Convert.ToDouble(strInput);
            return intResult;
        }

        public static bool ReadBool(string label, bool? oldValue = null) 
        {
            Write($"{label} [y/n]: ");
            ConsoleKeyInfo key = Console.ReadKey();
            if(key.Key == ConsoleKey.Enter && oldValue != null)
            {
                return (bool)oldValue;
            }
            if(key.KeyChar == 'y' || key.KeyChar == 'Y')
            {
                return true;
            }
            return false;
        }

        public static DateTime ReadDatetime(string label, DateTime? oldValue = null)
        {
            Write($"{label} (dd/mm/yyyy): ");
            string strInput = Console.ReadLine();
            if (string.IsNullOrEmpty(strInput) && oldValue != null)
            {
                return (DateTime)oldValue;
            }
            DateTime dateTimeResult = Convert.ToDateTime(strInput);
            return dateTimeResult;
        }

        public static KeyValuePair<string, object> MenuList(Dictionary<string, object> labels)
        {
            for(int i = 0; i < labels.Count; i++)
            {
                WriteLine($"{i + 1}. {labels.ElementAt(i).Key}"); 
            }
            int cmd = 0;
            do
            {
                cmd = ReadInt(">>");
            } while (cmd < 1 || cmd > labels.Count);
            return labels.ElementAt(cmd - 1);
        }
    }
}

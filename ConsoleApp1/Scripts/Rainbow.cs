﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Scripts
{
    class Rainbow
    {
        int color;
        public Rainbow()
        {
            color = 0;
        }
        public void Next()
        {
            Console.ForegroundColor = Rainbow.toConsoleColor((Color)color);
            color++;
            if (color == Enum.GetValues(typeof(Color)).Length) color = 0;
        }
        static ConsoleColor toConsoleColor(Color c)
        {
            foreach (var color in Enum.GetValues(typeof(ConsoleColor)))
            {
                if (color.ToString() == c.ToString()) return (ConsoleColor)color;
            }
            return ConsoleColor.Red;
        }
        public void PrintRainbow(string s)
        {
            foreach (var letter in s)
            {
                Next();
                Console.Write(letter);
            }
            Console.Write("\n");
            Console.ResetColor();
        }
    }
    enum Color
    {
        Red, Yellow, Green, Cyan, Blue, Magenta
    }
}

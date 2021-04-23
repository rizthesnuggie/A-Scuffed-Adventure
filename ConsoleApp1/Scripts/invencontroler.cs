using System;
using System.Threading;
using System.Threading.Tasks;
using ConsoleApp1.Scripts.Selectors;
using ConsoleApp1.Scripts;

namespace ConsoleApp1.Scripts
{
    public static class invencontroler
    {
        public static async Task Inventorythread()
        {
            await Task.Delay(10);
            while(true)
            {
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("test");
                    Program.playerinteractable = false;
                    invenselect.ivntest();
                }
            }
        }
        public static ConsoleKeyInfo betterreadkey()
        {
            while (!Program.playerinteractable)
            {
                Task.Delay(100);
            }
            return Console.ReadKey();
        }
        public static string betterreadline()
        {
            while (!Program.playerinteractable)
            {
                Task.Delay(100);
            }
            return Console.ReadLine();
        }
    }
}

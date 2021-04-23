using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Scripts.Selectors
{
    public static class invenselect
    {
        public static void ivntest()
        {
            Console.WriteLine("test2");
            for (int i = 0; i < Program.save.player.inventory.storage.Count; i++)
            {
                Console.WriteLine(Program.save.player.inventory.storage[i]);
            }
            Program.playerinteractable = true;

        }
    }
}

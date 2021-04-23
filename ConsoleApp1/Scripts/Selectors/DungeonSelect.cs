using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Scripts.Selectors
{
    class DungeonSelect
    {
        public static void intoDungeon()
        {
            Console.Clear();

            //sets the current player location for the save manager
            Program.save.player.savelocation.currentlocal = "Dungeon";
            Program.save.invsave();
            Console.WriteLine("Dungeon");
        }
    }
}

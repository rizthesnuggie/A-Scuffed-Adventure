using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Scripts;
using ConsoleApp1.Scripts.Selectors;

namespace ConsoleApp1.Scripts
{
    public static class Savemanager
    {
        public static void gotopoint()
        {
            Console.ResetColor();
            Console.Clear();
            if (string.IsNullOrEmpty(Program.save.player.savelocation.currentlocal))
            {
                goto cavesave;
            }
            switch (Program.save.player.savelocation.currentlocal.ToUpper())
            {
                case "CAVE":
                    goto cavesave;
                case "LIVINGROOM":
                    goto LRsave;
                case "DUNGEON":
                    goto Dsave;
                case "ATTIC":
                    goto Asave;
            }
        cavesave: CaveSelect.intocave();
        LRsave: LRSelect.intoLR();
        Dsave: DungeonSelect.intoDungeon();
        Asave: AtticSelector.intoAttic();
        }
    }
}

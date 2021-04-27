using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Scripts.Selectors
{
    public static class AtticSelector
    {
        public static void intoAttic()
        {
            Console.Clear();

            Program.save.player.savelocation.currentlocal = "Attic";
            Program.save.invsave();

            bool intoAttic = true;


            while (intoAttic)
            {
                if (Program.save.player.npc.hasSadiehag)
                {
                    Console.WriteLine(@"Walking up the stairs you find a nice looking attic with the ""Old Hag"" standing over a workbench, along with an opening to the fireplace and a sword sitting on the mantle. There is also a beautiful painting on the opposite wall.");
                }else
                {
                    Console.WriteLine(@"Walking up the stairs you find a nice looking attic with an old muscular women standing over a workbench, along with an opening to the fireplace and a sword sitting on the mantle. There is also a beautiful painting on the opposite wall.");
                }
            }
        }
    }
}

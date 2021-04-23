using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Scripts.Selectors
{
    public static class LRSelect
    {
        public static void intoLR()
        {
            Console.Clear();

            //sets the current player location for the save manager
            Program.save.player.savelocation.currentlocal = "LivingRoom";
            Program.save.invsave();

            bool LRbool = true;

            while (LRbool)
            {
                Console.WriteLine("Entering the Living room of the hosue you see an old women sitting in an old chair with a large cubbard behind her. The centerpeice of the room is a very old brick fireplace that looks like it hasn't been used in a while and across the room there is a spiral staircase leading upstairs.");
                for(int i = 0; i< Program.save.progress.LRoptions.Count; i++)
                {
                    Console.WriteLine((i + 1) + "." + Program.save.progress.LRoptions[i]);
                }
                string response = invencontroler.betterreadline();
                switch (response.ToUpper())
                {
                    case "GO UPSTAIRS":
                        goto AfLR;
                    case "GO DOWNSTAIRS":
                        goto CfLR;
                    case "TALK TO THE OLD WOMEN":
                        SadieManager.SadieConvo();
                        break;
                    case "RAID THE CUBBARD":

                        break;
                    case "CHECK THE FIREPLACE":

                        break;
                }
            }
        AfLR:;
        CfLR: CaveSelect.intocave();
        }
    }
}

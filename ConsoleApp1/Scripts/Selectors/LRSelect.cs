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
                        bool meatpic = true;
                        while (meatpic)
                        {
                            if (!Program.save.player.inventory.storage.Contains("Meat Slab")) //If the player does not have the meat slab in inventory then they can interact
                            {
                                Console.WriteLine("Checking out the old cubbard you find a large slab of meat that looks like it has been there a while. Do you want to take it?[y/n]");
                                string answer = invencontroler.betterreadline();
                                if (answer.ToUpper() == "Y")
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Meat Slab has been added to your inventory");
                                    Program.save.player.inventory.storage.Add("Meat Slab");
                                    Program.save.invsave();
                                    Console.ResetColor();
                                    meatpic = false;
                                }
                                else if (answer.ToUpper() == "N")
                                {
                                    Console.WriteLine("You leave the cubbard");
                                    meatpic = false;
                                }
                            }
                            else if (Program.save.player.inventory.storage.Contains("Meat Slab")) //If they do it leaves the loop
                            {
                                Console.WriteLine("You have already checked out this cubbard");
                                Program.save.invsave();
                                meatpic = false;
                            }
                        }
                        break;
                    case "CHECK THE FIREPLACE":
                        Console.WriteLine("You walk over to the fireplace, It looks like it hasn't been used in years and the bottom is odly made of a flimsy looking plywood");
                        break;
                }
            }
        AfLR: AtticSelector.intoAttic(); ;
        CfLR: CaveSelect.intocave();
        }
    }
}

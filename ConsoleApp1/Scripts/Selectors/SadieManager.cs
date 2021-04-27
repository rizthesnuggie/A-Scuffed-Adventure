using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Scripts.Selectors
{
    public static class SadieManager
    {
        public static void SadieConvo()
        {

            bool sadieconvobool = true;

            while (sadieconvobool)
            {
                Console.WriteLine("You approach the old women");
                for (int i = 0; i < Program.save.progress.SadieConvo.Count; i++)
                {
                    Console.WriteLine((i + 1) + "." + Program.save.progress.SadieConvo[i]);
                }
                string response = invencontroler.betterreadline();
                switch (response.ToUpper())
                {
                    case "GREET HER":
                        if (Program.save.player.species == "Human" || Program.save.player.species == "Dwarf")
                        {
                            PrintSadie("Hello dear, I hope you enjoy your time here");
                        }
                        else if (Program.save.player.species == "Elf")
                        {
                            PrintSadie("Hello");

                        }
                        break;
                    case "ASK ABOUT THE HOUSE":
                        PrintSadie("Well, this house is very old. It was originally built after the last stellar event with only one story. As you can see we've made alot of changes since then.");
                        break;
                    case "ASK ABOUT THE UPSTAIRS":
                        PrintSadie("My parents added that when I was a little girl, Now that old hag stays up there most of the time.");
                        Program.save.player.npc.hasSadiehag = true;
                        break;
                    case "ASK ABOUT THE DOOR DOWNSTAIRS":
                        PrintSadie("Oh that old thing, It is an old bunker made to withstand the next stellar event. Of course I don't think there wil ever be another but having it doesn't hurt");
                        Program.save.player.npc.hasSadieTroll = true;
                        break;
                    case "LEAVE":
                        sadieconvobool = false;
                        break;
                }
            }
        }
       
        public static void  PrintSadie(string s)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(s);
            Console.ResetColor();
        }
    }
}

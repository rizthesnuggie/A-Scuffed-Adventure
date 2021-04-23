using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Scripts.Selectors
{
    public static class SadieManager
    {
        public static bool isSadieok;
        public static bool hasSadieTroll;

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

                        break;
                    case "ASK ABOUT THE HOUSE":

                        break;
                    case "ASK ABOUT THE DOOR DOWNSTAIRS":

                        break;
                    case "LEAVE":
                        sadieconvobool = false;
                        break;
                }
            }
        }
    }
}

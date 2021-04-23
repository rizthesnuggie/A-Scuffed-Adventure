using System;


namespace ConsoleApp1.Scripts.Selectors
{
    public static class CaveSelect
    {
        public static void intocave()
        {
            Console.Clear();

            //sets the current player location for the save manager
            Program.save.player.savelocation.currentlocal = "Cave";
            Program.save.invsave();

            bool intocave = true; //bool to control the text loop of intocave()

            //This sets the cave options for if the player is an elf, removes and re-adds to prevent duplication, run's every time intocave() starts
            if (Program.save.player.species == "Elf")
            {
                Program.save.progress.caveoptions.Remove("Dig in the dirt pile");
                Program.save.progress.caveoptions.Remove("Check the loose board");
                Program.save.progress.caveoptions.Add("Dig in the dirt pile");
                Program.save.progress.caveoptions.Add("Check the loose board");
                Program.save.invsave();
            }
            while (intocave) //main text loop
            {
                if (Program.save.player.species == "Human" || Program.save.player.species == "Dwarf") //Checks of the player is a humman or dwarf and gives species specific intro
                {
                    Console.WriteLine("You are in a dark cave, Looking around you see a stairway with a light at the top and a smooth metal door inlaid into the cave wall");
                }
                else if (Program.save.player.species == "Elf") //Checks of the player is an elf and gives species specific intro
                {
                    Console.WriteLine("You are in a dark cave, thankfully you are an Elf who are known for exceptional vision in dark spaces. Looking around you see a stairway with a light at the top and a smooth metal door inlaid into the cave wall, along with a pile of dirt in a corner and what looks like a loose board underneath the stair supports.");
                }
                for (int i = 0; i < Program.save.progress.caveoptions.Count; i++) //loop that prints the contents of the possible options along with a numbered order, first 3 stay the same while others can change because of my list adding  
                {
                    Console.WriteLine((i + 1) + "." + Program.save.progress.caveoptions[i]);
                }
                string response = invencontroler.betterreadline();
                switch (response.ToUpper()) //checks the response given and acts acordingly
                {
                    case "GO UPSTAIRS":
                        goto LRfC; //takes player to living room, goto to prevent the scripts from piling, STFU you furries idc about the "neatness"(Line 161 for goto link)
                    case "TRY TO OPEN DOOR":
                    case "TRY TO OPEN THE DOOR":
                    case "OPEN DOOR":
                        if (Program.save.player.species == "Human" || Program.save.player.species == "Elf") //If the player species is a human or elf the cannot do anything with the door
                        {
                            Console.WriteLine("You try to open the door but it has no handle and is very heavy. You quickly give up");
                        }
                        else if (Program.save.player.species == "Dwarf") //If the player species is a Dwarf then they can open the door and it add's an option to go to another room
                        {
                            Program.save.progress.caveoptions.Remove("Try to open the door");
                            Program.save.progress.caveoptions.Remove("Enter the dark room");
                            Console.WriteLine("Being a Dwarf you easily remove the door and see a dark room");
                            Program.save.progress.caveoptions.Add("Enter the dark room");
                            Program.save.invsave();
                        }
                        break;
                    case "FEEL AROUND THE ROOM TO FIND MORE STUFF":
                    case "FEEL AROUND":
                        //This leeds to the dagger option at line 69(nice) 
                        Program.save.progress.caveoptions.Remove("Dig in the dirt pile");
                        Console.WriteLine("Feeling around the room you find a small dirt pile");
                        Program.save.progress.caveoptions.Add("Dig in the dirt pile");
                        Program.save.invsave();
                        break;
                    case "ENTER THE DARK ROOM":
                        goto DfC; //Takes player to the dungeon room, goto to prevent the scripts from piling, STFU you furries idc about the "neatness"(Line 160 for goto link)
                    case "DIG IN THE DIRT PILE":
                    case "DIG":
                    case "VISIT THE DAGGER HOLE":
                    case "VISIT":
                        //Allows player to visit the dirt pile/dagger hole,
                        bool dagpic = true; //bool for dagger loop
                        while (dagpic)
                        {
                            if (!Program.save.player.inventory.storage.Contains("Dagger") || !Program.save.player.inventory.weapon.Contains("Dagger")) //Program shows this if the player does not have the dagger in inventory or equiped
                            {
                                Console.WriteLine("Digging in the hole you find a small dagger. Do you wish to take it?[y/n]");
                                string answer = invencontroler.betterreadline();
                                if (answer.ToUpper() == "Y") //If the player says yes then it equips the dagger and saves
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Dagger has been equiped and added to your inventory");
                                    Program.save.player.inventory.weapon = "Dagger";
                                    Console.ResetColor();
                                    Program.save.progress.caveoptions.Remove("Dig in the dirt pile");
                                    Program.save.progress.caveoptions.Add("Visit the Dagger hole");
                                    Program.save.invsave();
                                    if (string.IsNullOrEmpty(Program.save.player.inventory.weapon)) //if the string is null or empty we assume the stats are base for weapon adjustment 
                                    {
                                        Program.playerManager.weapstatman(); //Runs the weapons stat manager
                                    } else
                                    {
                                        Program.playerManager.weapontobe = "Dagger";
                                        Program.playerManager.weaponequiped(); //Sets the weapon that will be equiped and then calls the equiped weapon function which moves things to inventory and adjust's stats
                                    }
                                    dagpic = false;
                                }
                                else if (answer.ToUpper() == "N") //self explanitory honestly
                                {
                                    Program.save.progress.caveoptions.Remove("Dig in the dirt pile");
                                    Program.save.progress.caveoptions.Remove("Visit the Dagger hole");
                                    Console.WriteLine("You leave the dagger");
                                    Program.save.progress.caveoptions.Add("Visit the Dagger hole");
                                    Program.save.invsave();
                                    dagpic = false;
                                }
                            }
                            else if (Program.save.player.inventory.storage.Contains("Dagger") || !Program.save.player.inventory.weapon.Contains("Dagger")) //If the player already has the dagger then it prevents the interaction 
                            {
                                Program.save.progress.caveoptions.Remove("Dig in the dirt pile");
                                Program.save.progress.caveoptions.Remove("Visit the Dagger hole");
                                Console.WriteLine("You already have a Dagger in your inventory. You stop looking at the hole");
                                Program.save.progress.caveoptions.Remove("Dig in the dirt pile");
                                Program.save.progress.caveoptions.Add("Visit the Dagger hole");
                                Program.save.invsave();
                                dagpic = false;
                            }

                        }
                        break;
                    case "CHECK THE LOOSE BOARD":
                        bool medalpic = true; //bool for the medalion picup loop
                        while (medalpic)
                        {
                            Console.Write("You pry off the board and look inside");
                            if (!Program.save.player.inventory.storage.Contains("Silver Medalion")) //If the player does not have the medalion in inventory then they can interact
                            {
                                Console.WriteLine(",you find a small silver medalion. Do you wish to keep it[y/n]");
                                string answer = invencontroler.betterreadline();
                                if (answer.ToUpper() == "Y")
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Silver Medalion has been added to your inventory");
                                    Program.save.player.inventory.storage.Add("Silver Medalion");
                                    Program.save.invsave();
                                    Console.ResetColor();
                                    medalpic = false;
                                }
                                else if (answer.ToUpper() == "N")
                                {
                                    Console.WriteLine("You leave the Silver Medalion");
                                    medalpic = false;
                                }
                            }
                            else if (Program.save.player.inventory.storage.Contains("Silver Medalion")) //If they do it leaves the loop
                            {
                                Console.WriteLine(",you already have a Silver Medalion in your inventory. You leave the empty hole");
                                Program.save.invsave();
                                medalpic = false;
                            }
                        }
                        break;
                }
            }
        DfC: DungeonSelect.intoDungeon();
        LRfC: LRSelect.intoLR();
        }
    }
}

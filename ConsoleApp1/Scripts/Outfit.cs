using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1.Scripts
{
    public class Outfit
    {
        public string name { get; set; }
    }

    public class Character
    {
        public string name { get; set; }
        public string species { get; set; }
        public Outfit outfit {get; set;}
        public Stat stat { get; set; }
        public invenmanager inventory { get; set; }
        public NPC npc { get; set; }
        public Savelocation savelocation { get; set; }
    }

    public class Stat
    {
        private int realhealth;
        private int realstrenght;
        private int realspeed;
        private int realstealth;
        private int realcharisma;
        public int Playerhealth
        {
            get { return realhealth; } 
            set { if (value > 100)
                    realhealth = 100;
                else if (value < 0)
                    realhealth = 0;
                else
                    realhealth = value;
            } 
        }
        public int Playerstrength
        {
            get { return realstrenght; }
            set
            {
                if (value > 30)
                    realstrenght = 30;
                else if (value < 1)
                    realstrenght = 1;
                else
                    realstrenght = value;
            }
        }
        public int Playerspeed
        {
            get { return realspeed; }
            set
            {
                if (value > 30)
                    realspeed = 30;
                else if (value < 1)
                    realspeed = 1;
                else
                    realspeed = value;
            }
        }
        public int Playerstealth
        {
            get { return realstealth; }
            set
            {
                if (value > 30)
                    realstealth = 30;
                else if (value < 1)
                    realstealth = 1;
                else
                    realstealth = value;
            }
        }
        public int Playercharisma
        {
            get { return realcharisma; }
            set
            {
                if (value > 30)
                    realcharisma = 30;
                else if (value < 1)
                    realcharisma = 1;
                else
                    realcharisma = value;
            }
        }
    }
    
    public class invenmanager
    {
        public string weapon { get; set; }
        public string tool { get; set; }

        public List<string> storage { get; set; } = new List<string>();
    }

    public class NPC
    {
        public bool isSadieok { get; set; }
        public bool hasSadieTroll { get; set; }
        public bool hasSadiehag { get; set; }
        public bool hasanneconvo { get; set; }
        public bool istrolldead { get; set; }

    }

    public class Savelocation
    {
        public string currentlocal { get; set; }
    }

    public class Progress
    {
        public List<string> SpeciesDes { get; set; } = new List<string> { "The race of Men are an intresting bunch. They are known for their capacity for incredible violence but also amazing feats of strength and camaraderie and loyalty", "The dawrves are always involded in the talk of the land. Known for their Strength, Charisma, and powerful greed. They can be good friends but also terrible enimies", "Elfs are the most recluse bunch in the land. Known for their Speed, Stealth, and terrible social skills. It's always good to have an elf at your side, even if you can't talk to them", "Press any key to continue" };
        public List<string> OutfitDes { get; set; } = new List<string> { "The Shiny Armor is a good all around armor. It allows you to have a moderate amount of protection with some benifits towards speed *and* stealth.", "The Brute Armor is a tough armor made for only the strongest of warriors. It offers a large amount of protection but at the cost of speed *and* stealth.", "The Shadow Cloak is a Hooded Cloak made in darkness. It allows its wearer to blend into the shadows but to be stealthy you must give up some strength *and* speed", "The Light Armor is the best option for an adventurer always on the go. It's lightness allows for quicker movement but at the cost of strength *and* stealth", "Press any key to continue" };
        public List<string> SadieConvo { get; set; } = new List<string> { "Greet her", "Ask about the house", "Ask about the upstairs", "Ask about the door downstairs", "Leave" };
        public List<string> AnneConvo { get; set; } = new List<string> { };
        public List<string> caveoptions { get; set; } = new List<string> { "Go upstairs", "Try to open the door", "Feel around the room to find more stuff" };
        public List<string> LRoptions { get; set; } = new List<string> { "Go upstairs", "Go downstairs","Talk to the old women","Raid the cubbard","Check the fireplace",};
        public List<string> AtticOptions { get; set; } = new List<string> { };
    }
 }

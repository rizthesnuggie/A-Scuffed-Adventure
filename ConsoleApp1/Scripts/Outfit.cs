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

    public class Savelocation
    {
        public string currentlocal { get; set; }
    }

    public class Progress
    {
        public List<string> SadieConvo { get; set; } = new List<string> {"Greet her","Ask about the house","Ask about the door downstairs", "Leave" };
        public List<string> caveoptions { get; set; } = new List<string> { "Go upstairs", "Try to open the door", "Feel around the room to find more stuff" };
        public List<string> LRoptions { get; set; } = new List<string> { "Go upstairs", "Go downstairs","Talk to the old women","Raid the cubbard","Check the fireplace","Leave" };
    }
 }

namespace ConsoleApp1.Scripts

{
    public class PlayerManager
    {
        Stat stat = new Stat();
        public string weapontobe = "";
        //Used to manage the players health, current stats, levels, and equipt outfits and weapons
        public Stat specstatman() //species stat manager
        {
            stat.Playerhealth = 100;
            switch (Program.save.player.species.ToUpper())
            {
                case "HUMAN":
                    stat.Playerstrength = 10;
                    stat.Playerspeed = 10;
                    stat.Playerstealth = 10;
                    stat.Playercharisma = 10;
                    break;
                case "DWARF":
                    stat.Playerstrength = 12;
                    stat.Playerspeed = 8;
                    stat.Playerstealth = 6;
                    stat.Playercharisma = 12;
                    break;
                case "ELF":
                    stat.Playerstrength = 8;
                    stat.Playerspeed = 12;
                    stat.Playerstealth = 12;
                    stat.Playercharisma = 6;
                    break;
            }
            Program.playerManager.outstatman();
            return stat;
        }
        public void outstatman()
        {
            switch (Program.save.player.outfit.name.ToUpper())
            {
                case "SHINY ARMOR":
                    stat.Playerstrength = stat.Playerstrength + 2;
                    stat.Playerspeed = stat.Playerspeed + 2;
                    stat.Playerstealth = stat.Playerstealth + 2;
                    break;
                case "BRUTE ARMOR":
                    stat.Playerstrength = stat.Playerstrength + 4;
                    stat.Playerspeed = stat.Playerspeed - 2;
                    stat.Playerstealth = stat.Playerstealth - 2;
                    break;
                case "SHADOW CLOAK":
                    stat.Playerstrength = stat.Playerstrength - 2;
                    stat.Playerspeed = stat.Playerspeed - 2;
                    stat.Playerstealth = stat.Playerstealth + 4;
                    break;
                case "LIGHT ARMOR":
                    stat.Playerstrength = stat.Playerstrength - 2;
                    stat.Playerspeed = stat.Playerspeed + 4;
                    stat.Playerstealth = stat.Playerstealth - 2;
                    break;
            }
        }

        public void weapstatman()
        {
            switch (Program.save.player.inventory.weapon.ToUpper())
            {
                case "SWORD":
                    stat.Playerstrength = stat.Playerstrength + 2;
                    break;
                case "AXE":
                    stat.Playerstrength = stat.Playerstrength + 4;
                    stat.Playerspeed = stat.Playerspeed - 2;
                    break;
                case "DAGGER":
                    stat.Playerstrength = stat.Playerstrength + 2;
                    stat.Playerspeed = stat.Playerspeed + 2;
                    break;

            }
        }

        public void weaponequiped()
        {
            switch (Program.save.player.inventory.weapon.ToUpper())
            {
                case "SWORD":
                    stat.Playerstrength = stat.Playerstrength - 2;
                    break;
                case "AXE":
                    stat.Playerstrength = stat.Playerstrength - 4;
                    stat.Playerspeed = stat.Playerspeed + 2;
                    break;
                case "DAGGER":
                    stat.Playerstrength = stat.Playerstrength - 2;
                    stat.Playerspeed = stat.Playerspeed + 2;
                    break;
            }
            Program.save.player.inventory.storage.Add(Program.save.player.inventory.weapon);
            Program.save.player.inventory.weapon = weapontobe;
            weapstatman();
        }
    }


 }

using ConsoleApp1.Scripts;
using ConsoleApp1.Scripts.Selectors;
using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static tosave[] savejr; //Array of the saves that are read from the save file location

        public static string savdir = @"D:\Program\Scuffed Saves"; //string that specificies the begining of the save location(savedirectory)

        public static Menue menu = new Menue(); //Instance of the Menu class
        public static tosave save; //instance of the tosave class
        public static PlayerManager playerManager = new PlayerManager(); //instance of the PlayerManager class
        public static Discordmanager discordmanager = new Discordmanager(); //instance of the Discordmanager class

        public static bool playerinteractable = true; //bool for player's abiliity to interact with the envoirnment, currently serves no purpose

        static void Main(string[] args)
        {
            //This section is for setting the programs size and title settings
            Console.WindowWidth = 191; 
            Console.WindowHeight = 54;                  
            Console.Title = "Scuffed Adventures";

            savejr = tosave.inread(); //Sets the save file array equal to whatever is read from the file location
            save = menu.Menu(); //Honestly no clue
            save.player ??= Characterselctor.charselect(); //if the information is null(no save file) then it will run the player through the character and outfit selector 
            save.player.stat ??= playerManager.specstatman(); //adjusts the players stats through the species statmanager
            save.player.inventory ??= new invenmanager(); //sets inventory 
            save.player.savelocation ??= new Savelocation(); //sets the save location
            save.progress ??= new Progress(); //sets the the progress stuff
            save.invsave();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Save Selected");
            Console.ResetColor();
            Console.WriteLine("Begin?");
            Console.ReadLine();
            var autoupdate = discordmanager.autoupdateRPC(); //Activates the discord rich presence
            //var inventorythread = invencontroler.Inventorythread(); //This in theory controls the inventory system should it change to be at a specific button press
            Savemanager.gotopoint();



            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Scripts
{
    public static class Descriptors
    {

        public static void specdes()
        {
            Console.WriteLine("1. The race of Men are an intresting bunch. They are known for their capacity for incredible violence but also amazing feats of strength and camaraderie and loyalty");
            Console.WriteLine("2. The dawrves are always involded in the talk of the land. Known for their Strength, Charisma, and powerful greed. They can be good friends but also terrible enimies");
            Console.WriteLine("3. Elfs are the most recluse bunch in the land. Known for their Speed, Stealth, and terrible social skills. It's always good to have an elf at your side, even if you can't talk to them");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }

        public static void outdes()
        {
            Console.WriteLine("The Shiny Armor is a good all around armor. It allows you to have a moderate amount of protection with some benifits towards speed *and* stealth. ");
            Console.WriteLine("The Brute Armor is a tough armor made for only the strongest of warriors. It offers a large amount of protection but at the cost of speed *and* stealth.");
            Console.WriteLine("The Shadow Cloak is a Hooded Cloak made in darkness. It allows its wearer to blend into the shadows but to be stealthy you must give up some strength *and* speed");
            Console.WriteLine("The Light Armor is the best option for an adventurer always on the go. It's lightness allows for quicker movement but at the cost of strength *and* stealth");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}

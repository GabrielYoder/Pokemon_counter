using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pokemon_Numbers
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("what generation of pokemon would you like to see the amount of? 1-8 or 9 for all?");

            Console.Write("Enter the generation 1-8 or 9 for all.");

            List<int> Pokemongames = new List<int>();
            double pokemon_generation = Convert.ToDouble(Console.ReadLine());
            int i = 0;
            if (pokemon_generation == 1)
            {
                while (i < 152)
                {
                    Console.WriteLine("new pokemon number = {0}", i);
                    Pokemongames.Add(i);
                    i++;
                }
            }
            if (pokemon_generation == 2)
            {
                while (i < 101)
                {
                    Console.WriteLine("new pokemon number = {0}", i);
                    Pokemongames.Add(i);
                    i++;
                }
            }
            if (pokemon_generation == 3)
            {
                while (i < 136)
                {
                    Console.WriteLine("new pokemon number = {0}", i);
                    Pokemongames.Add(i);
                    i++;
                }
            }
            if (pokemon_generation == 4)
            {
                while (i < 108)
                {
                    Console.WriteLine("new pokemon number = {0}", i);
                    Pokemongames.Add(i);
                    i++;
                }
            }
            if (pokemon_generation == 5)
            {
                while (i < 157)
                {
                    Console.WriteLine("new pokemon number = {0}", i);
                    Pokemongames.Add(i);
                    i++;
                }
            }
            if (pokemon_generation == 6)
            {
                while (i < 73)
                {
                    Console.WriteLine("new pokemon number = {0}", i);
                    Pokemongames.Add(i);
                    i++;
                }
            }
            if (pokemon_generation == 7)
            {
                while (i < 89)
                {
                    Console.WriteLine("new pokemon number = {0}", i);
                    Pokemongames.Add(i);
                    i++;
                }
            }
            if (pokemon_generation == 8)
            {
                while (i < 97)
                {
                    Console.WriteLine("new pokemon number = {0}", i);
                    Pokemongames.Add(i);
                    i++;
                }
            }
            if (pokemon_generation == 9)
            {
                while (i < 906)
                {
                    Console.WriteLine("new pokemon number = {0}", i);
                    Pokemongames.Add(i);
                    i++;
                }
            }
           // List<string> Pokemongames = new List<string>();
                /*
{
    new Pokemongames { Id = 1, Name = "Fire Red and Leaf Green" },
    new Pokemongames { Id = 2, Name = "Gold and Silver" },
    new Pokemongames { Id = 3, Name = "Ruby and Saphire" },
    new Pokemongames { Id = 4, Name = "Diamond and Pearl" },
    new Pokemongames { Id = 5, Name = "Black and White" },
    new Pokemongames { Id = 6, Name = "X and Y" },
    new Pokemongames { Id = 7, Name = "Sun and Moon" },
    new Pokemongames { Id = 8, Name = "Sword and Shield" },
};*/
            using (var writer = new StreamWriter("fileGames.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(Pokemongames);
            }
        }
    }
}

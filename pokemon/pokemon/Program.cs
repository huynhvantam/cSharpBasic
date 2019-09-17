using System;
using System.Collections.Generic;

namespace pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("Menu: pick 1>8");
            Console.WriteLine("1-Add Pokemon");
            Console.WriteLine("2-Show Pokemon");
            Console.WriteLine("3-Find pokemon by name or id");
            Console.WriteLine("4-Edit pokemon");
            Console.WriteLine("5-Show voice pokemon");
            Console.WriteLine("6-Show Raiting");
            Console.WriteLine("7-Printf to file");
            Console.WriteLine("8-Add pokemon to list");
            Console.WriteLine("9-Exit");
            bool check;
            int pick;
            check = int.TryParse(Console.ReadLine(), out pick);
            while (!check || pick < 1 || pick > 9)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("nhap sai, nhap lai di");
                Menu();
                //check = int.TryParse(Console.ReadLine(), out pick);

            }
            switch (pick)
            {
                case 1:
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("|          1-Add Pokemon       |");
                    Console.WriteLine("--------------------------------");
                    Addpokemon();
                    Menu();
                    break;
                case 2:
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("|          2-Show Pokemon      |");
                    Console.WriteLine("--------------------------------");
                    Showpokemon();
                    Menu();
                    break;
                case 3:
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("| 3-Find pokemon by name or id  |");
                    Console.WriteLine("--------------------------------");
                    Searchid();
                    Menu();
                    break;
                case 4:
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("|          4-Edit pokemon      |");
                    Console.WriteLine("--------------------------------");
                    Editpokemon();
                    Menu();
                    break;
                case 5:
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("|          5-Show voice        |");
                    Console.WriteLine("--------------------------------");
                    Showvoice();
                    Menu();
                    break;
                case 6:
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("|          6-Show Raiting      |");
                    Console.WriteLine("--------------------------------");
                    ShowRaiting();
                    Menu();
                    break;
                case 9:
                    break;

            }
        }
        static List<pokemon> PokemonList = new List<pokemon>();
        static void Addpokemon()
        {
            pokemon addpokemon = new pokemon();
            Console.Write("Enter name of Name: ");
            addpokemon.Name = Console.ReadLine();
            Console.Write("Enter name of Attack: ");
            addpokemon.Attack = Int32.Parse(Console.ReadLine());
            Console.Write("Enter name of Defence: ");
            addpokemon.Defence = Int32.Parse(Console.ReadLine());
            Console.Write("Enter name of Speed: ");
            addpokemon.Speed = Int32.Parse(Console.ReadLine());

            List<pokemon> typeList = new List<pokemon>();

            Console.WriteLine("Pick Type PokeMon");
            Console.WriteLine("1- Normal   2- Water   3- Grass   4- Fire   5- Electric   6- exit");
            int pick = int.Parse(Console.ReadLine());
            while (pick > 0 || pick < 7)
            {
                switch (pick)
                {
                    case 1:
                        addpokemon.Type = "Normal";
                        typeList.Add(addpokemon);
                        break;
                    case 2:
                        addpokemon.Type = "Water";
                        typeList.Add(addpokemon);
                        break;
                    case 3:
                        addpokemon.Type = "Grass";
                        typeList.Add(addpokemon);
                        break;
                    case 4:
                        addpokemon.Type = "Electric";
                        typeList.Add(addpokemon);
                        break;
                    case 5:
                        break;
                }
            }


            PokemonList.Add(addpokemon);
        }
        static void Showpokemon()
        {
            foreach (var pokemon in PokemonList)
            {
                pokemon.ShowInfo();
                Console.WriteLine("-----------------------------------------------------");
            }
        }
        static void ShowRaiting()
        {
            foreach (var item in PokemonList)
            {
                item.RaitingPokemon();
                Console.WriteLine("-----------------------------------------------------");
            }
        }
        static void Showvoice()
        {
            foreach (var item in PokemonList)
            {
                item.Sound();
                Console.WriteLine("-----------------------------------------------------");
            }
        }
        static void Searchid()
        {
            Console.WriteLine("tim theo Ten");
            string find = Console.ReadLine();
            foreach (var item in PokemonList)
            {
                if (find == item.Name)
                {
                    item.ShowInfo();
                    Console.WriteLine("-----------------------------------------------------");
                    break;
                }
                else
                {
                    Console.WriteLine("Ten khong tin thay. Chuyen sang tim theo ID");
                    Console.WriteLine("tim theo ID");
                    int findid = int.Parse(Console.ReadLine());
                    if (findid == item.id)
                    {
                        item.ShowInfo();
                        Console.WriteLine("-----------------------------------------------------");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("khong tim thay");
                        Console.WriteLine("-----------------------------------------------------");
                    }

                }

            }

            {

            }
        }
        static void Editpokemon()
        {
            Console.WriteLine("Pick ID of pokemon");
            int findid = int.Parse(Console.ReadLine());
            foreach (var item in PokemonList)
            {
                if (findid == item.Id)
                {
                    Console.WriteLine("1- Change Name   2- Change Attack   3- Change Defence   4- Change Speed");
                    int pick = int.Parse(Console.ReadLine());
                    switch (pick)
                    {
                        case 1:
                            Console.Write("Enter string of Name: ");
                            item.Name = Console.ReadLine();
                            break;
                        case 2:
                            Console.Write("Enter int of Attack: ");
                            item.Attack = Int32.Parse(Console.ReadLine());
                            break;
                        case 3:
                            Console.Write("Enter int of Defence: ");
                            item.Defence = Int32.Parse(Console.ReadLine());
                            break;
                        case 4:
                            Console.Write("Enter int of Speed: ");
                            item.Speed = Int32.Parse(Console.ReadLine());
                            break;
                        default:
                            Console.Write("nhap sai");
                            break;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("khong tim thay");
                }
            }
        }
        static void Type()
        {

        }
    }
}

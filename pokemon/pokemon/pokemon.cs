using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon
{
    class pokemon
    {

        public int id;
        private static int idTemp = 1;
        public int Id { get => id; }
        public static int IdTemp { get => idTemp; set => idTemp = value; }
        public pokemon()
        {
            id = idTemp++;
        }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Speed { get; set; }

        public void RaitingPokemon()
        {
            double raiting = (Attack + Defence + Speed) / 3;
            Console.WriteLine($"Raiting: {raiting}");
            if (raiting >= 90)
            {
                Console.WriteLine("Rank: Perfect");
            }
            else if (raiting >= 60)
            {
                Console.WriteLine("Rank: Good");
            }
            else if (raiting >= 40)
            {
                Console.WriteLine("Rank: Medium");
            }
            else if (raiting >= 0)
            {
                Console.WriteLine("Rank: Bad");
            }
        }
        public void Sound()
        {
            Console.WriteLine($"{Name} say:{Name.Substring(0, 4)} {Name.Substring(0, 4)}");
        }
        public void ShowInfo()
        {
            Console.WriteLine($"ID: {Id}     Name:{Name}    Type:{Type}     Height:{Height}     Weight:{Weight}     HP:{HP}     Attack:{Attack}     Defence:{Defence}     Speed:{Speed}");
        }

    }
}

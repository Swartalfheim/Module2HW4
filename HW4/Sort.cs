using HW4.AnimalHabitats;

namespace HW4
{
    internal class Sort
    {
        public void AllSort()
        {
            Console.WriteLine("\nChoose where you want to sort the animals \n" +
                "animals in this section are automatically sorted by copulation\n" +
                "(you must enter the number of the corresponding section):\n" +
                "1)Aviation, 2) Insectarium, 3)Oceanarium, 4)Range of Mammals, 5)Serpentarium, 6)Terrarium");
            string[,] mass = new string[3, 6];
            string type = Console.ReadLine();
            switch (type)
            {
                case "1":
                    mass = new string[3, 6]
                    {
                        { "1", "Penguin", "Antarctic", "30", "Fish", "0" },
                        { "3", "Heron", "Swamps", "10", "Amphibians", "15" },
                        { "2", "Eagle", "Mountains", "3", "Meat", "10" }
                    };
                    break;
                case "2":
                    mass = new string[3, 6]
                    {
                        { "2", "Wasp", "Middle latitudes", "300", "Sucrose", "15" },
                        { "1", "Cockroach", "Madagascar", "120", "All", "20" },
                        { "3", "Mantis", "Indochina", "50", "Insects", "10" }
                    };
                    break;
                case "3":
                    mass = new string[3, 6]
                    {
                        { "3", "Herring", "Northern seas", "60", "Crustaceans", "5" },
                        { "2", "Gold fish", "Japan", "30", "All", "15" },
                        { "1", "Clown fish", "Reefs", "20", "All", "20" }
                    };
                    break;
                case "4":
                    mass = new string[3, 6]
                    {
                        { "3", "Lama", "Andes", "20", "Grass", "0" },
                        { "2", "Desert fox", "Desert", "15", "Meat", "15" },
                        { "1", "Tiger", "Indochina", "5", "Meat", "5" }
                    };
                    break;
                case "5":
                    mass = new string[3, 6]
                    {
                        { "3", "Viper", "Woodland", "50", "Meat", "20" },
                        { "1", "Python", "Amazon", "25", "Meat", "30" },
                        { "2", "Cobra", "Indochina", "10", "Meat", "35" }
                    };
                    break;
                case "6":
                    mass = new string[3, 6]
                    {
                        { "1", "Turtle", "Oceania", "50", "Meat", "35" },
                        { "3", "Gecko", "Jungle", "35", "Insects", "35" },
                        { "2", "Monitor lizard", "Indochina", "7", "Meat", "35" }
                    };
                    break;
            }

            int height = mass.GetLength(0);
            int width = mass.GetLength(1);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(mass[i, j] + "; ");
                }

                Console.WriteLine();
            }
        }
    }
}

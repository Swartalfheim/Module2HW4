using HW4.AnimalHabitats;
using HW4.Count;

namespace HW4
{
    public class PrintInfo
    {
        private Aviation _aviation;
        private Insectarium _insectarium;
        private Oceanarium _oceanarium;
        private RangeOfMammals _mammals;
        private Serpentarium _serpentarium;
        private Terrarium _terrarium;

        public void PrintAll()
        {
            _aviation = new Aviation();
            _insectarium = new Insectarium();
            _oceanarium = new Oceanarium();
            _mammals = new RangeOfMammals();
            _serpentarium = new Serpentarium();
            _terrarium = new Terrarium();

            int height = _serpentarium.TypeHabitat().GetLength(0);
            int width = _serpentarium.TypeHabitat().GetLength(1);
            Console.WriteLine("Aviation");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(_aviation.TypeHabitat()[i, j] + "; ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nInsectarium");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(_insectarium.TypeHabitat()[i, j] + "; ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nOceanarium");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(_oceanarium.TypeHabitat()[i, j] + "; ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nRangeOfMammals");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(_mammals.TypeHabitat()[i, j] + "; ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nSerpentarium");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(_serpentarium.TypeHabitat()[i, j] + "; ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nTerrarium");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(_terrarium.TypeHabitat()[i, j] + "; ");
                }

                Console.WriteLine();
            }
        }

        public void PrintAllCount()
        {
            CountAviation countAviation = new CountAviation();
            Console.WriteLine($"\ntotal birds in Aviation: {countAviation.CAviation()}");
            int ca = countAviation.CAviation();
            CountInsectarium countInsectarium = new CountInsectarium();
            Console.WriteLine($"total insects in Insectarium: {countInsectarium.CInsectarium()}");
            int ci = countInsectarium.CInsectarium();
            CountMammals countMammals = new CountMammals();
            Console.WriteLine($"total mammals in Range of Mammals: {countMammals.CMammals()}");
            int cm = countMammals.CMammals();
            CountOceanarium countOceanarium = new CountOceanarium();
            Console.WriteLine($"total fish in Oceanarium: {countOceanarium.COceanarium()}");
            int co = countOceanarium.COceanarium();
            CountSerpentarium countSerpentarium = new CountSerpentarium();
            Console.WriteLine($"total snake in Serpentarium: {countSerpentarium.CSerpentarium()}");
            int cs = countSerpentarium.CSerpentarium();
            CountTerrarium countTerrarium = new CountTerrarium();
            Console.WriteLine($"total reptiles in Terrarium: {countTerrarium.CTerrarium()}\n");
            int ct = countTerrarium.CTerrarium();
            Console.WriteLine($"Total animals: {ca + ci + cm + co + cs + ct}");
        }

        public void RezPrintInfo()
        {
            _aviation = new Aviation();
            _insectarium = new Insectarium();
            _oceanarium = new Oceanarium();
            _mammals = new RangeOfMammals();
            _serpentarium = new Serpentarium();
            _terrarium = new Terrarium();
            Console.WriteLine("choose where you want to search\n" +
                "(you must enter the number of the corresponding section)\n" +
                "1)Aviation, 2) Insectarium, 3)Oceanarium, 4)Range of Mammals, 5)Serpentarium, 6)Terrarium\n");
            PrintAllInfo printAllInfo = new PrintAllInfo();
            string type = Console.ReadLine();
            switch (type)
            {
                case "1":
                    printAllInfo.Info(_aviation.TypeHabitat());
                    break;
                case "2":
                    printAllInfo.Info(_insectarium.TypeHabitat());
                    break;
                case "3":
                    printAllInfo.Info(_oceanarium.TypeHabitat());
                    break;
                case "4":
                    printAllInfo.Info(_mammals.TypeHabitat());
                    break;
                case "5":
                    printAllInfo.Info(_serpentarium.TypeHabitat());
                    break;
                case "6":
                    printAllInfo.Info(_terrarium.TypeHabitat());
                    break;
            }
        }
    }
}

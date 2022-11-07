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
    }
}

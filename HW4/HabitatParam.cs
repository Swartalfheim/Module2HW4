using HW4.AnimalHabitats;

namespace HW4
{
    public class HabitatParam
    {
        private Aviation _aviation;
        private Insectarium _insectarium;
        private Oceanarium _oceanarium;
        private RangeOfMammals _mammals;
        private Serpentarium _serpentarium;
        private Terrarium _terrarium;
        public void HParam()
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
            string type = Console.ReadLine();
            switch (type)
            {
                case "1":
                    Find.FindByParameter(_aviation.TypeHabitat());
                    break;
                case "2":
                    Find.FindByParameter(_insectarium.TypeHabitat());
                    break;
                case "3":
                    Find.FindByParameter(_oceanarium.TypeHabitat());
                    break;
                case "4":
                    Find.FindByParameter(_mammals.TypeHabitat());
                    break;
                case "5":
                    Find.FindByParameter(_serpentarium.TypeHabitat());
                    break;
                case "6":
                    Find.FindByParameter(_terrarium.TypeHabitat());
                    break;
            }
        }
    }
}

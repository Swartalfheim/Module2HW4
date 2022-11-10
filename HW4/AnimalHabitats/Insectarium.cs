namespace HW4.AnimalHabitats
{
    public class Insectarium : Habitat
    {
        public override string[,] TypeHabitat()
        {
            string[,] insects = new string[3, 6]
           {
                { "1", "Cockroach", "Madagascar", "120", "All", "20" },
                { "2", "Wasp", "Middle latitudes", "300", "Sucrose", "15" },
                { "3", "Mantis", "Indochina", "50", "Insects", "10" }
           };
            return insects;
        }
    }
}

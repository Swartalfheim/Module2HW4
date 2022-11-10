namespace HW4.AnimalHabitats
{
    public class Serpentarium : Habitat
    {
        public override string[,] TypeHabitat()
        {
            string[,] serpents = new string[3, 6]
            {
                { "1", "Python", "Amazon", "25", "Meat", "30" },
                { "2", "Cobra", "Indochina", "10", "Meat", "35" },
                { "3", "Viper", "Woodland", "50", "Meat", "20" }
            };
            return serpents;
        }
    }
}

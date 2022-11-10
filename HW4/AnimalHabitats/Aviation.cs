namespace HW4.AnimalHabitats
{
    public class Aviation : Habitat
    {
        public override string[,] TypeHabitat()
        {
            string[,] birds = new string[3, 6]
           {
                { "1", "Penguin", "Antarctic", "30", "Fish", "0" },
                { "2", "Eagle", "Mountains", "3", "Meat", "10" },
                { "3", "Heron", "Swamps", "10", "Amphibians", "15" }
           };
            return birds;
        }
    }
}

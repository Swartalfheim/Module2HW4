namespace HW4.AnimalHabitats
{
    public class Oceanarium : Habitat
    {
        public override string[,] TypeHabitat()
        {
            string[,] fish = new string[3, 6]
          {
                { "1", "Clown fish", "Reefs", "20", "All", "20" },
                { "2", "Gold fish", "Japan", "30", "All", "15" },
                { "3", "Herring", "Northern seas", "60", "Crustaceans", "5" }
          };
            return fish;
        }
    }
}

namespace HW4.AnimalHabitats
{
    public class Terrarium : Habitat
    {
        public override string[,] TypeHabitat()
        {
            string[,] reptiles = new string[3, 6]
           {
                { "1", "Turtle", "Oceania", "50", "Meat", "35" },
                { "2", "Monitor lizard", "Indochina", "7", "Meat", "35" },
                { "3", "Gecko", "Jungle", "35", "Insects", "35" }
           };
            return reptiles;
        }
    }
}

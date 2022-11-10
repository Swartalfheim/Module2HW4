namespace HW4.AnimalHabitats
{
    public class RangeOfMammals : Habitat
    {
        public override string[,] TypeHabitat()
        {
            string[,] mammals = new string[3, 6]
         {
                { "1", "Tiger", "Indochina", "5", "Meat", "5" },
                { "2", "Desert fox", "Desert", "15", "Meat", "15" },
                { "3", "Lama", "Andes", "20", "Grass", "0" }
         };
            return mammals;
        }
    }
}

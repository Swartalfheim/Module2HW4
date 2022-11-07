using HW4.AnimalHabitats;

namespace HW4.Count
{
    public class CountMammals : RangeOfMammals
    {
        public int CMammals()
        {
            int num = 0;
            int height = TypeHabitat().GetLength(0);
            int width = TypeHabitat().GetLength(1);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j == 3)
                    {
                        num = num + Convert.ToInt32(TypeHabitat()[i, 3]);
                    }
                }
            }

            return num;
        }
    }
}

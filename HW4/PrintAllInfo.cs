namespace HW4
{
    internal class PrintAllInfo : IAllInfo
    {
        public void Info(string[,] array)
        {
            Console.WriteLine("Welcome to our safari park where you will meet many animals");
            int height = array.GetLength(0);
            int width = array.GetLength(1);
            Console.WriteLine("we have: ");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j == 1)
                    {
                        Console.WriteLine(array[i, 1]);
                    }
                }
            }
        }
    }
}

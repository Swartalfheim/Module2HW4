using HW4.Count;

namespace HW4
{
    public class Starter
    {
        public void Start()
        {
            PrintInfo printInfo = new PrintInfo();
            printInfo.RezPrintInfo();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("In the table below, data about animals are presented as follows:\n" +
                "nnumber, name, promised area, population, diet, comfortable temperature");
            printInfo.PrintAll();
            printInfo.PrintAllCount();
            Sort sort = new Sort();
            sort.AllSort();
            HabitatParam habitat = new HabitatParam();
            habitat.HParam();
        }
    }
}

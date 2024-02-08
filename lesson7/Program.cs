namespace lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inventory = new Inventory();
            int choice;
            while (true)
            {
                Console.WriteLine("Выберите действие (введите 1 - 5)");
                Console.WriteLine("1) Вывести информацию об инвентаре");
                Console.WriteLine("2) Вывести цену всего инвентаря");
                Console.WriteLine("3) Добавить продукт(ы)");
                Console.WriteLine("4) Удалить продукт");
                Console.WriteLine("5) Закончить работу программы");
                if (!int.TryParse(Console.ReadLine(), out choice)) continue;
                switch (choice)
                {
                    case 1:
                        inventory.PrintAllProductsInfo();
                        break;
                    case 2:
                        Console.WriteLine(inventory.SumOfProsucts());
                        break;
                    case 3:
                        inventory.AddProducts();
                        break;
                    case 4:
                        inventory.RemoveProduct();
                        break;
                    case 5: return;
                    default:
                        continue;
                }
            }
        }
    }
}

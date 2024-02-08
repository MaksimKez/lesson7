using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    internal class Product
    {
        public string ID { get; private init; }
        public string Name { get; private init; }

        public double Price { get; private set; }

        public int Quantity { get; private init; }

        public Product()
        {
            Guid TempProdID = Guid.NewGuid();
            ID = TempProdID.ToString();

            while (true)
            {
                Console.WriteLine("Введите название товара");
                Name = Console.ReadLine();
                if (string.IsNullOrEmpty(Name)) continue;

                Console.WriteLine("Введите цену товара");
                if(!double.TryParse(Console.ReadLine(), out double tempPrice) || tempPrice <= 0) continue;
                Price = tempPrice;

                Console.WriteLine("Введите количество единиц товара");
                if(!int.TryParse(Console.ReadLine(), out int tempQuantity) || tempQuantity < 1) continue;
                Quantity = tempQuantity;

                Price = tempPrice;

                break;
            }
        }


        #region useless

        //public Product(string name)
        //{
        //    Name = name;

        //    Guid TempProdID = Guid.NewGuid();
        //    ID = TempProdID.ToString();

        //    while (true)
        //    {
        //        Console.WriteLine("Введите цену товара");
        //        if (!double.TryParse(Console.ReadLine(), out double tempPrice)) continue;
        //        Price = tempPrice;

        //        Console.WriteLine("Введите количество единиц товара");
        //        if (!int.TryParse(Console.ReadLine(), out int tempQuantity)) continue;
        //        Quantity = tempQuantity;

        //        break;
        //    }
        //}

        //public Product(double price)
        //{
        //    Price = price;

        //    Guid TempProdID = Guid.NewGuid();
        //    ID = TempProdID.ToString();
        //    while (true)
        //    {
        //        Console.WriteLine("Введите название товара");
        //        Name = Console.ReadLine();
        //        if (string.IsNullOrEmpty(Name)) continue;

        //        Console.WriteLine("Введите количество единиц товара");
        //        if (!int.TryParse(Console.ReadLine(), out int tempQuantity)) continue;
        //        Quantity = tempQuantity;

        //        break;
        //    }
        //}

        //public Product(int quantity)
        //{
        //    Quantity = quantity;

        //    Guid TempProdID = Guid.NewGuid();
        //    ID = TempProdID.ToString();

        //    while (true)
        //    {
        //        Console.WriteLine("Введите название товара");
        //        Name = Console.ReadLine();
        //        if (string.IsNullOrEmpty(Name)) continue;

        //        Console.WriteLine("Введите цену товара");
        //        if (!double.TryParse(Console.ReadLine(), out double tempPrice)) continue;

        //        Price = tempPrice;

        //        break;
        //    }
        //}

        //public Product(string name, double price)
        //{
        //    Name = name;
        //    Price = price;

        //    Guid TempProdID = Guid.NewGuid();
        //    ID = TempProdID.ToString();

        //    while (true)
        //    {
        //        Console.WriteLine("Введите количество единиц товара");
        //        if (!int.TryParse(Console.ReadLine(), out int tempQuantity)) continue;
        //        Quantity = tempQuantity;

        //        break;
        //    }
        //}

        //public Product(string name, int quantity)
        //{
        //    Name= name;
        //    Quantity = quantity;

        //    Guid TempProdId = Guid.NewGuid();
        //    ID = TempProdId.ToString();

        //    while (true)
        //    {
        //        Console.WriteLine("Введите цену товара");
        //        if (!double.TryParse(Console.ReadLine(), out double tempPrice)) continue;

        //        Price = tempPrice;

        //        break;
        //    }
        //}

        // если я правильно понял задание, то таких вариаций конструктора +- 40
        // есть ли смысл делать все 40 если будет использоваться только один

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    public class Inventory
    {
        private static List<Product> products = new List<Product>();

         public Inventory()
         {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Сколько продуктов добавить? (потом можно будет добавить еще)");
                if (!int.TryParse(Console.ReadLine(), out int numOfProducts) || numOfProducts < 1) continue;
                for (int i = 0; i < numOfProducts; i++)
                {
                    Console.WriteLine();
                    products.Append(new Product());
                    Console.WriteLine();
                }
                break;
            }
         } 

        public void AddProducts()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Сколько продуктов добавить?");
                if (!int.TryParse(Console.ReadLine(), out int numOfProducts) || numOfProducts < 1) continue;
                for (int i = 0; i < numOfProducts; i++)
                {
                    Console.WriteLine();
                    products.Add(new Product());
                    Console.WriteLine();
                }
                break;
            }
        }

        public void RemoveProduct()
        {
            Console.WriteLine();
            PrintAllProductsInfo();
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Введите ID продукта, чтобы его удалить");
                string IDtoDelete = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(IDtoDelete)) continue;
                foreach (Product product in products)
                {
                    if(product.ID ==  IDtoDelete)
                    {
                        Console.WriteLine();
                        products.Remove(product);
                        Console.WriteLine("Продукт успешно удален");
                        Console.WriteLine();
                        return;
                    }
                }
                Console.WriteLine($"Продукт по ID {IDtoDelete} не найден");
                Console.WriteLine();
            }
        }

        public double SumOfProsucts()
        {
            double sum = 0;

            foreach (Product product in products)
            {
                sum += product.Price * product.Quantity;
            }
            return sum;
        }

        public void PrintAllProductsInfo()
        {
            int prodCounter = 1;
            foreach (Product product in products)
            {
                Console.WriteLine();
                Console.WriteLine($"Продукт номер {prodCounter}");
                Console.WriteLine($"Название: {product.Name}");
                Console.WriteLine($"Цена: {product.Price}");
                Console.WriteLine($"Количество: {product.Quantity}");
                Console.WriteLine($"ID: {product.ID}");
                Console.WriteLine();
                prodCounter++;
            }

        }
    }
}

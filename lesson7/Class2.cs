using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    internal class Inventory
    {
        public List<Product> Products { get; private set; }

        public Inventory()
        {
            //List<Product> Products = new List<Product>();
            while (true)
            {
                Console.WriteLine("Сколько продуктов добавить? (потом можно будет добавить еще)");
                if (!int.TryParse(Console.ReadLine(), out int numOfProducts) || numOfProducts < 1) continue;
                for (int i = 0; i < numOfProducts; i++)
                {
                    Products.Add(new Product());
                }
                break;
            }
        } 

        public void AddProducts()
        {
            while (true)
            {
                Console.WriteLine("Сколько продуктов добавить?");
                if (!int.TryParse(Console.ReadLine(), out int numOfProducts) || numOfProducts < 1) continue;
                for (int i = 0; i < numOfProducts; i++)
                {
                    Products.Add(new Product());
                }
                break;
            }
        }

        public void RemoveProduct()
        {
            while (true)
            {
                Console.WriteLine("Введите ID продукта, чтобы его удалить");
                string IDtoDelete = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(IDtoDelete)) continue;
                foreach (Product product in Products)
                {
                    if(product.ID ==  IDtoDelete)
                    {
                        Products.Remove(product);
                        Console.WriteLine("Продукт успешно удален");
                        return;
                    }
                }
                Console.WriteLine($"Продукт по ID {IDtoDelete} не найден");
            }
        }

        public double SumOfProsucts()
        {
            double sum = 0;

            foreach (Product product in Products)
            {
                sum += product.Price * product.Quantity;
            }
            return sum;
        }

        public void PrintAllProductsInfo()
        {
            int prodCounter = 1;
            foreach (Product product in Products)
            {
                Console.WriteLine($"Продукт номер {prodCounter}");
                Console.WriteLine($"Название: {product.Name}");
                Console.WriteLine($"Цена: {product.Price}");
                Console.WriteLine($"Количество: {product.Quantity}");
                Console.WriteLine($"ID: {product.ID}");
                prodCounter++;
            }

        }
    }
}

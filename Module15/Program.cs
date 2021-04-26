using System;
namespace Module15
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Console.WriteLine("Добро пожаловать в наш магазин! Выберите товары, способ доставки и оформляйте заказ!");
            Product p = new Product("Батончик Баунти", (decimal)15.9);

            Console.WriteLine($"Добавлен продукт {p.ProductName}, с ценой {p.ProductPrice}");
            Console.ReadKey();

        }
    }
}


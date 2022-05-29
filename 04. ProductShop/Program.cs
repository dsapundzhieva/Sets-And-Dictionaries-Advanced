using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        string command;

        var shopProducts = new Dictionary<string, Dictionary<string, double>>();

        while ((command = Console.ReadLine()) != "Revision")
        {
            var cmdArgs = command.Split(", ");

            string shop = cmdArgs[0];
            string product = cmdArgs[1];
            double price = double.Parse(cmdArgs[2]);

            if (!shopProducts.ContainsKey(shop))
            {
                shopProducts.Add(shop, new Dictionary<string, double>());
            }
            shopProducts[shop][product] = price;
        }

        foreach (var  (shop, products) in shopProducts.OrderBy(x => x.Key))
        {
            Console.WriteLine(shop + "->");

            foreach (var product in products)
            {
                Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
            }
        }
    }
}

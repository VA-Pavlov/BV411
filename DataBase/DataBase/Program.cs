using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var products = DATABASEEntities.getContext().Products.Where(
            //        line => line.Price < 1000).Select(line =>new {line.Id, line.Name }).ToList();
            //foreach (var product in products) { 
            //        Console.WriteLine(product.Id + " " + product.Name);
            //}
            var products = DATABASEEntities.getContext().Products.Any(p => p.Name == "дети");
            Console.WriteLine(products);
        }
    }
}

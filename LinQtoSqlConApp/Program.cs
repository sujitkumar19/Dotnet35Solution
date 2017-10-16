using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using winCOnsoleApp;

namespace LinQtoSqlConApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataContext context = new DataContext(@"server=M-14; Initial Catalog=Northwind; Integrated Security=true;");
            Table<Catetgory> categoryTable = context.GetTable<Catetgory>();
            Table<Product> ProductTable = context.GetTable<Product>();
            //var result=from c in categoryTable select c;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //var result = categoryTable.Select(c => new { CID = c.CategoryId, CName = c.CategoryName, Desc = c.Descritpion });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //var result = (from p in productTable where p.CategoryID == 2 select new { p.ProductId, p.ProductName, p.UnitPrice, p.CategoryId }).ToList();

            //var result = (from p in ProductTable
            //              join c in categoryTable
            //              on p.CategoryId equals c.CategoryId
            //              select new { p.ProductId, p.ProdcutName, c.CategoryId }).ToList();

            //var result = ProductTable.Join(categoryTable, p => p.CategoryId, c => c.CategoryId, (p, c) => new { p.ProductId, p.ProductName, c.CategoryId, c.CategoryName }).ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //    Console.ReadLine();
            //}

            //var result = (from p in ProductTable
            //              group p by p.CategoryId into g 
            //              select new {CatId=g.Key,NoofProd=g.Count()}).ToList();

            //var result = ProductTable.GroupBy(p => p.CategoryId).Select(p => new { CatID = p.Key, NoofProducts = p.Count() }).ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //    Console.ReadLine();
            //}

            //var result = (from p in ProductTable
            //              join c in categoryTable
            //              on p.CategoryId equals c.CategoryId
            //              group p by c.CategoryName into g
            //              select new { CatId = g.Key, NoofProd = g.Count() }).ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //    Console.ReadLine();
            //}

            //var result = (from p in ProductTable
            //              join c in categoryTable
            //              on p.CategoryId equals c.CategoryId
            //              group p by c.CategoryName)
            //              .ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Key}-- {item.Count()}");
            //    foreach (var gg in item)
            //    {
            //        Console.WriteLine($"{gg.ProductName}");
            //        Console.ReadLine();
            //    }
            //}

            var result = (from p in ProductTable
                          select new { p.ProductName, p.Cat.CategoryName }).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace LinQToSqlORConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthDataContext context = new NorthDataContext();
            context.Log = Console.Out;
            #region Get all customer from London
            //var result = (from c in context.Customers
            //              where c.City == "London"
            //              select new { c.CustomerID, c.Country, c.CompanyName, c.ContactName, c.City }).ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            //Customer cust = new Customer { CustomerID = "AAA", CompanyName = "SpanLabs", ContactName = "Sujit", City = "Mum", Country = "India" };
            //context.Customers.InsertOnSubmit(cust);

            #region delete
            //var cust = context.Customers.FirstOrDefault(c => c.CustomerID == "AAA");
            //Console.WriteLine($"CustomerId :{cust.CustomerID},CompanyName: {cust.CompanyName},city :{cust.City}");
            ////context.Customers.Attach(cust);
            //context.Customers.DeleteOnSubmit(cust);
            //try
            //{
            //    context.SubmitChanges();
            //    Console.WriteLine("New customer inserted");
            //}
            //catch (Exception ex)
            //{ Console.WriteLine("Error customer inserted"); } 
            #endregion

            #region update
            //var cust = context.Customers.FirstOrDefault(c => c.CustomerID == "AAA");
            //Console.WriteLine($"CustomerId :{cust.CustomerID},CompanyName: {cust.CompanyName},city :{cust.City}");

            //cust.City = "Bombay123";
            //Console.ReadKey(true);
            //try
            //{
            //    context.SubmitChanges();
            //    Console.WriteLine(" Rec Updated");
            //}
            //catch (ChangeConflictException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    context.ChangeConflicts.ResolveAll(RefreshMode.KeepChanges);
            //    context.SubmitChanges();
            //    Console.WriteLine("update after the Concurrency");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //} 
            #endregion

            var result = context.CustOrderHist("ALFKI");
            foreach(var item in result)
            {
                Console.WriteLine($"{item.ProductName} - {item.Total}");
            }
        }
    }
}

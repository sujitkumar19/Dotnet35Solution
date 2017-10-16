using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace LinQtoSqlConApp
{
    [Table(Name = "Categories")]
    public class Catetgory
    {
        [Column(IsPrimaryKey =true)]
        public int CategoryId { get; set; }
        [Column]
        public string CategoryName { get; set; }
        [Column]
        public string Descritpion { get; set; }

    }
    [Table(Name = "Products")]
    public class Product
    {
        [Column(IsPrimaryKey =true)]
        public int ProductId { get; set; }
        EntityRef<Catetgory> _cat;
        [Association(Storage = "_cat", ThisKey = "CategoryID")]
        public Catetgory Cat
        {
            get { return _cat.Entity; }
          set { _cat.Entity = value; }

        }

        [Column]
        public string ProductName { get; set; }
        [Column]
        public int CategoryId { get; set; }

        [Column]
        public Decimal UnitPrice { get; set; }

    }
}


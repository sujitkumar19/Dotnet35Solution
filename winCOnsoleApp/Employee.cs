using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winCOnsoleApp
{
   public class Employee
    {
        public int EmpNo { get; set; }

        public String Empname { get; set; }

        public Decimal Salary { get; set; }
        public int age { get; set; }

        public override string ToString()
        {
            return string.Format($"EmpNo: {EmpNo},EmpName: {Empname},Age : {age}, Salary :{Salary}");
        }
       
    }
}

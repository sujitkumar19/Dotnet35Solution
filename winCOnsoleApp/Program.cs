using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winCOnsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Old Object Initilization
            //Employee emp = new Employee();
            //emp.Empname = "Donald";
            //emp.EmpNo = 10;
            //emp.Salary = 1002.45m;
            //emp.age = 21;
            //Console.WriteLine(emp); 
            #endregion

            #region New Intialization
            Employee emp = new Employee
            {
                Empname = "Tin",
                EmpNo = 19,
                Salary = 2910.45m,
                age = 11

            };
            Console.WriteLine(emp);
            Console.ReadLine();
            #endregion

            #region New Collection Initialization
            List<Employee> empList = new List<Employee>()
            {
                  new Employee() {EmpNo=11,Empname="A",Salary=1000,age=11 },
                  new Employee() {EmpNo=21,Empname="B",Salary=2000,age=21 },
                  new Employee() {EmpNo=31,Empname="C",Salary=3000,age=31 },
                  new Employee() {EmpNo=41,Empname="D",Salary=4000,age=41 },
                  new Employee() {EmpNo=51,Empname="E",Salary=5000,age=51 },

                   new Employee() {EmpNo=12,Empname="AA",Salary=1002,age=12 },
                  new Employee() {EmpNo=22,Empname="BB",Salary=2002,age=22 },
                  new Employee() {EmpNo=32,Empname="CC",Salary=3002,age=32 },
                  new Employee() {EmpNo=42,Empname="DD",Salary=4002,age=42 },
                  new Employee() {EmpNo=52,Empname="EE",Salary=5002,age=52 },

                   new Employee() {EmpNo=15,Empname="ACC",Salary=1005,age=15 },
                  new Employee() {EmpNo=25,Empname="BCC",Salary=2005,age=25 },
                  new Employee() {EmpNo=35,Empname="CCC",Salary=3005,age=35 },
                  new Employee() {EmpNo=45,Empname="DCC",Salary=4005,age=45 },
                  new Employee() {EmpNo=55,Empname="ECC",Salary=5005,age=55 },

                   new Employee() {EmpNo=19,Empname="AACC",Salary=1009,age=19 },
                  new Employee() {EmpNo=29,Empname="BBCC",Salary=2009,age=29 },
                  new Employee() {EmpNo=39,Empname="CCCC",Salary=3009,age=39 },
                  new Employee() {EmpNo=49,Empname="DDCC",Salary=4009,age=49 },
                  new Employee() {EmpNo=59,Empname="EECC",Salary=5009,age=59 },
            };


            #endregion

            #region for loop to retrive employee list
            //int ctr = 1;
            //for (int i=0;i<empList.Count;i++)
            //{
            //    Console.WriteLine($"{ctr++} -> {empList[i]}");
            //    Console.ReadLine();

            //} 
            #endregion

            #region  Extension Method
            //string name = "Donald";
            //Console.WriteLine(StringFunctions.Sujit(name));
            //Console.WriteLine(name.Sujit());
            //Console.ReadLine(); 
            #endregion
            #region Get all Emp with sal >1005
            //int ctr = 1;
            //foreach (Employee item in empList.Filter())
            //{
            //    Console.WriteLine($"{ctr++} -> {item}");
            //    Console.ReadLine();

            //} 
            #endregion
            #region using delegate
            //int ctr = 1;
            //foreach (Employee item in empList.Filter(GetByAge))
            //{
            //    Console.WriteLine($"{ctr++} -> {item}");
            //    Console.ReadLine();

            //}
            #endregion

            #region using anonymus delegate function
            //int ctr = 1;
            //foreach (Employee item in empList.Filter(delegate (Employee e) { return e.Salary > 1005; }))
            //{
            //    Console.WriteLine($"{ctr++} -> {item}");
            //    Console.ReadLine();

            //}
            #endregion

            #region Using lamda Expression "lamda Expression is '=>' replaces the key word delegate"
            //int ctr = 1;
            //foreach (Employee item in empList.Filter( (Employee e) =>{ return e.Empname.Contains("a") && e.Salary > 1005; }))
            //{
            //    Console.WriteLine($"{ctr++} -> {item}");
            //    Console.ReadLine();

            //} 
            #endregion

            #region LINQ to Objects
            //List<Employee> newemList = empList.Where(e => e.Salary > 1005).ToList();
            var result = empList.Where(e => e.age < 21).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item);
                Console.ReadLine();

            }

            
            #endregion

        }

        public static bool GetByAge(Employee emp)
        {
            if (emp.age > 21) return true;
            return false;
        }
    }

   


}

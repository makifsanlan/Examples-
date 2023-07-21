using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;
            sayi2 = 100;

            Console.WriteLine("sayi1:"+sayi1);
            //Arraylar referans tiplerdir.referans tip olunca heap kavramı da ortaya çıkar. 
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] {10,20,30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine("Sayilar1[0]="+sayilar1[0]);
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Derin";

            person2 = person1;

            Console.WriteLine(person2.FirstName);
            Console.ReadLine();
            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "23323";
            Employee emp = new Employee();
            Person person3 = new Person();
            Console.WriteLine(person3.FirstName);



        }


    }
    //base class
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Customer:Person
    {
        public string CreditCardNumber{ get; set; }
    }
    class Employee : Person //inheritance
    {
        public int EmployeeNumber { get; set; }

    }

}

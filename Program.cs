/*==========CIT 195 - Spring 2025==============*/
/*==========Michael J. Wildner Sr.=============*/
/*==========wildnem@mail.nmc.edu===============*/
/*========= ClubInterface: Week 5 Lab #1=======*/
/*==========Created: 02/16/2025 ===============*/
/*==========Last Modified: 02/16/2025==========*/


using System;
using System.Runtime.ExceptionServices;
namespace ClubInterface
{
    interface IClub
    {
        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Methods
        public string Fullname() { return ""; }
    }
    class Program
    {
        class Member : IClub 
        { 
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public Boolean Current { get; set; }
            public DateTime ExpDate { get; set; }
            public Member() 
            {
                Id = 0;
                FirstName = string.Empty;
                LastName = string.Empty;
                Current = false;
                ExpDate = new DateTime(2024,12,31);
            }

            public Member(int id, string first,string last, DateTime exp)
            {
                Id = id;
                FirstName = first;
                LastName = last;
                ExpDate = exp;
                Current = CheckExp(exp);
            }

            public Member(int id, string first, string last, bool current, DateTime exp)
            {
                Id = id;
                FirstName = first;
                LastName = last;
                ExpDate = exp;
                Current = current;
            }

            public string Fullname() 
            {
                return FirstName + " " + LastName;
            }

            public bool CheckExp(DateTime exp) 
            {
                DateTime currentDate = DateTime.Today;
                return (currentDate < exp);  
            }

            public void memberData() 
            {
                Console.WriteLine("========================");
                Console.WriteLine("ID#: " + Id);
                Console.WriteLine("Name: " + Fullname());
                Console.WriteLine("Current: " + Current);
                Console.WriteLine("Expiration Date: " + ExpDate);
                Console.WriteLine("========================");
            }
        }

        static void Main(string[] args) 
        {
            Console.WriteLine("Membership Database Testing");
            Console.WriteLine("");
            // test default constructor
            Console.WriteLine("Testing Default Constructor...");
            Member member01 = new Member();
            member01.memberData();
            Console.WriteLine("Testing Parameterized Constructor...");
            Member member02 = new Member(1, "Dan", "Pemonium", DateTime.Parse("12/31/2025"));
            member02.memberData();
        }
    }
}

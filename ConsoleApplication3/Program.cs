using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{

    abstract class  Person
    {
        string name;
        long id;
        int age;


        public Person(string name=null,long id=0,int age=0)
        {
            this.name = name.Length <= 10 ? name : name.Substring(0, 10);
            this.id = id;
            this.age = age;
        }

       public virtual void PrintPerson()
        {
            Console.WriteLine(string.Format("Name: {0}\nId: {1}\nAge: {2}",name,id,age));
        }

    }


    class Student:Person
    {

        int average;
        string institute;
        public Student(string name,long id,int age,int avg = 0, string ins=null):base(name,id,age)
        {
            this.average = avg;
            this.institute = ins.Length<=10? ins:ins.Substring(0,10);
        }
           public override void PrintPerson()
            {
                
               base.PrintPerson();
               Console.WriteLine(string.Format("average: {0}\ninstitute: {1}",average,institute));

            }
    }

    class Employee:Person
    {
        float salary;
       public Employee(string name,long id,int age,float sal):base(name,id,age)
        {
            this.salary = sal;
        }

        public override void PrintPerson()
        {
              base.PrintPerson();
              Console.WriteLine("Salary: "+salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number Persons:");
            int ans = int.Parse(Console.ReadLine());
            Person[] per=new Person[ans];
            for (int i = 0; i < per.Length; i++)
            {
                per[i] = Add();
            }

            for (int i = 0; i < per.Length; i++)
            {
               per[i].PrintPerson();
            }
        }


        static Person Add()
        {
            Person per;
            Console.WriteLine("Select Studnet 1 and Work 2");
            int ans = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name,Id,Age");
            string nam = Console.ReadLine();
            long id = long.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            if(ans==1)
            {
                Console.WriteLine("Enter Average and institute:");
                int aver = int.Parse(Console.ReadLine());
                string ins = Console.ReadLine();
                per = new Student(nam,id,age,aver,ins);
            }
            else
            {
                Console.WriteLine("Enter Salary:");
                float sal = float.Parse(Console.ReadLine());
                per = new Employee(nam,id,age,sal);
            }


            return per;
        }
    }
}

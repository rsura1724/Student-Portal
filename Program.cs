using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal
{
    class Student
    {
        public string name { get; set; }
        public int id { get; set; }
        public String address { get; set; }

        public Student(int Id, String Name, String Address)
        {
            this.id = Id;
            this.name = Name;
            this.address = Address;
        }
        public Student()
        {

        }

    }


    class Program
    {
        int count;

        Student[] studentarray = new Student[2];
        
         
        void readDetails()
        {

            //studentarray[i] = new Student();
            
            Console.WriteLine("Enter the number of Student records you want to enter:");
            String input = Console.ReadLine();
            
            Int32.TryParse(input, out count);
            for(int i = 0; i<count; i++)
            {
                Student o = new Student();
                
                Console.WriteLine("Enter the Student ID:");
                int number = int.Parse(Console.ReadLine());
                



                Console.WriteLine("Enter the Student Name:");
                
                string name1 = Console.ReadLine();

                Console.WriteLine("Enter the Student Address:");

                String addrss = Console.ReadLine();
                // displayDetails();
                studentarray[i] = new Student() {

                id = number,
                name = name1,
                address = addrss};

            }
        }



        void displayDetails()
        {
           
            Console.WriteLine("------STUDENT DETAILS------");
            for (int i = 0; i<count; i++)
            {
                //studentarray[i] = new Student();
                 Console.WriteLine("Student ID:" + studentarray[i].id);
                  Console.WriteLine("Student Name:" + studentarray[i].name);
                  Console.WriteLine("Student Address:" + studentarray[i].address);
                Console.WriteLine("------------------------");
            }
        }


        void startup()
        {
            Program p = new Program();
            Console.WriteLine(" Enter Student Details");
            p.readDetails();
            Console.WriteLine("Do you want to display the details? (y/n)");
            string res = Console.ReadLine();
            if(res.ToLower() == "y")
            {
                p.displayDetails();
            }
            else
            {
                Console.WriteLine("Thank you for Using Student Portal");
                Console.ReadKey();
            }
        }


        static void Main(string[] args)
        {


            Program s = new Program();
            s.startup();

           // p.readDetails();
           // p.displayDetails();
            Console.ReadKey();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using assemblythree;// here i have imported assmbly 3 for using protected internal data member of assembly three in consoleapp1 by inherting 
//the assembly three class which is incedo in new info class for that firstly u have to add the  reference  of assemblythree in consoleapp1 
// by right clicking on solution add new project then add class library name it as assebly3 refrence of consoleapp1 then u will be able to add assembly consoleapp1 by using keyword USING

//   Public:             Anywhere from the class
//   Private :           Only within the class
//   Protected :         Only within that class and the sub classes of that class
//   Internal :          Within the assembly of the class
//   Protected Internal: Within that class, sub classes of that class and and assembly

namespace ConsoleApp1
{
    //..........................................DISCUSSING ACCESS MODIFIERS...........................................................................

    class Program
    {

        static void Main(string[] args)
        {

            emp e1 = new emp();
            e1.get();
            e1.set();
            e1.id = 33;
            //e1.salary //its is not working here as it is declared as private
            //e1.pf //it is also declared as protected so will not work but it will work in subclass of is class even it will not work in 3rd class
            employer1 ee1 = new employer1();
            ee1.set1();

            hod h1 = new hod();
            h1.show();

            info in1 = new info();
            in1.showinfo();
        }
        public class emp
        {
            public Int32 id;
            public string name;
            private Int32 salary;
            protected Int32 personaldetails;
            internal Int32 mobileno = 446376;
            //protected internal string emailid="Smit0946@gmail.com";



            public int MyProperty { get; set; }

            public void get()
            {
                Console.WriteLine("enter the employee id,name and salary");
                id = Convert.ToInt32(Console.ReadLine());
                name = Console.ReadLine();
                salary = Convert.ToInt32(Console.ReadLine());



            }
            public void set()
            {
                Console.WriteLine(id + "  " + name + "  " + salary);
                Console.WriteLine("employee information is here" + "Name" + name + "Salary" + salary + "id" + id + "  ");
                Console.ReadKey();
            }
        }
        public class employer1 : emp
        {

            public void set1()
            {
                this.personaldetails = 5;//here through protected we can use personaldetail property in this inherited class
                Console.WriteLine("personal detail" + personaldetails);
                Console.ReadKey();
            }



        }
        public class hod
        {
            public void show()
            {
                //this.personaldetails = 6;(  here this vraiable will not be worked because its is declared as protected indexer emp class so only inherited class can be accesed throughj this operator)
                emp e1 = new emp();
                Console.WriteLine(e1.mobileno);//internal datatype is used but need to create object of class where this internal datatype is declared
                Console.ReadKey();

            }


        }
        public class info : incedo
        {
            public void showinfo()
            {
                Console.WriteLine("incedo emailid is" + "     " + emailid);
                Console.ReadKey();
            }
        }

        

    }
}

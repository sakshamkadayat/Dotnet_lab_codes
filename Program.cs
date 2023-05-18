using System;
namespace Saksham
{
    class defaultconstructor
    {
        int labno;
        string name;
        int rollno;
        
        public defaultconstructor()
        {
            Console.WriteLine("Default constructor is called");
            labno = 1;
            name = "saksham kadayat";
            rollno = 23980;
        }
        
        static void Main(string[] args)
        {
            defaultconstructor sak = new defaultconstructor();
            Console.WriteLine("labno: " + sak.labno);
            Console.WriteLine("Name: " + sak.name);
            Console.WriteLine("Rollno: " + sak.rollno);
        }
    }
}

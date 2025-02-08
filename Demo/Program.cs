 namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implicitly-type Local Variables [ var - dynamic ]

            //var

            //var Data01 = 1.2;

            //Compiler can detect the datatype of the Local variable  based on initail value
            // must be initialaized 
            //can`t initialaized the local varaible with null
            //can`t Change datatype of the local varaible After initialaiztoin
            // can`t use var as parameter
            //Data="Ali" invaild


            //dynamic : Like var in JS

            //dynamic Data02 = "Ahmed";

            //CLR detect the  datatype of the Local variable  based on Last value , At Runtime
            //Don`t need to be initialaized
            //can initialaized the local varaible with null
            //can Change datatype of the local varaible After initialaiztoin
            // can use var as parameter


            //Data02 = 12;
            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = 1.2;
            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = true;
            //Console.WriteLine(Data02.GetType().Name);

            //Anonymous Type

            // Employee E01 = new Employee() { Id=1,Name="Ahmed",Slaray=12000};

            var E01 = new { Id = 1, Name = "Ahmed", Slaray = 12000.0m };
            var E02 = new { Id = 1, Name = "Ahmed", Slaray =12000.0m };
            //Console.WriteLine(E01.Id); 
            //Console.WriteLine(E01.Name); 
            //Console.WriteLine(E01.Salary); 
            //E01.Id = 12; // Invalid Immutable Can't Change Its Value After Creation 

            Console.WriteLine(E01.GetType().Name); // f_Anonymous Type 3 

            Console.WriteLine(E01.GetType().Name); // <>f__Anonymous Type 3 


            // The Same Anonymous Type As long as: 
             // 1. The Same Property Name [Case Sensitive] 
             // 2. The Same Property Order 
             //Console.WriteLine(E01); // { Id = 1, Name Ahmed, Salary = 12000.0 } 
             // Compiler Will Override On ToString 

              Console.WriteLine(E01.GetHashCode());

            Console.WriteLine(E02.GetHashCode());

            if (E01.Equals(E02))
                Console.WriteLine(value: "E01 == Ε02");
            else
                Console.WriteLine(value: "E01 != Ε02");


        }
    }
}

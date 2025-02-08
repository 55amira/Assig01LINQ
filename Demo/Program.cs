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


        }
    }
}

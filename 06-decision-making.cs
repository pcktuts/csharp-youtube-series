using System; 

namespace myFirstProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /**
             * Decision making
             * 1. if
             * 2. if else
             * 3. if else if else
             * 4. nested if
             * 
             */

             int age = 18;
             bool isBlind = true;
             if(age > 18)
             {
                Console.WriteLine("You can apply for driving license");
             }
             else if( age == 18)
             {
                if (isBlind == true)
                {
                    Console.WriteLine("You cannot drive");

                }
                Console.WriteLine("You can start learning driving");
             }
             else
             {
                Console.WriteLine("You must be atleast 18 to apply for a license");
             }
        }
    }
}

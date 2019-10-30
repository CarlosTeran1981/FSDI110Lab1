using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();

            //single line comment

            /* 

            string name = "Carlos Teran";
            int age = 99;
            float something = 1.90f; // for any floating (number with decimal)
            double somethingD = 1.90; // for lot lot of decimal places
            decimal price = 2.12m; // for currency
            bool crazy = true;

            Console.WriteLine("My name is: " + name);
            */

            /* rules:

                -Should have the same name as the class.
                -It should not have a return type. */

            
        }
        public Program()
        {
            Console.WriteLine("I'm the constructor");

           /*  int result = SayHello();

            Console.WriteLine(result);

            AnotherOne(42);
            AnotherOne(20);

            //Loops();

            task1(); // 0 3 6 9 12 15

            var res = Sum(21,21);
            System.Console.WriteLine(res); //42 */

            int[] numbers = new int[200];
            for(int i=0; i<200; i++){
                numbers[i] = i+1;
            }

            int howMany = CountAndPrintOdds(numbers);
            Console.WriteLine(howMany);

        }

        

        public void Arrays(){
            // declare array
            string[] name = new string[10];
            int[] numbers = new int[10];

            // add values
            name[0] = "Carlos";
            name[1] = "Carlos1";
            name[2] = "Carlos2";
            name[3] = "Carlos3";
            name[4] = "Carlos4";

            numbers[0] = 0;
            numbers[1] = 1;
            numbers[2] = 2;
            numbers[3] = 3;


            // read values from array
            Console.WriteLine(name[0]);
            Console.WriteLine();

            // travel the array with a loop
            Console.WriteLine("Start array + loop");
            for (int i= 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            Console.WriteLine("Start array + loop 2");
            for (int j= 0; j < numbers.Length; j++)
            {
                Console.WriteLine(numbers[j]);
            }



        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
        
        public void task1(){
            for(int i = 0; i < 16; i+=3){
                Console.WriteLine(i);
            }
        }
        public void Loops()
        {

            //For loop
            for(int i = 0; i < 10; i++)
          {
            Console.WriteLine("Inside a loop");
          }

            //Do while
        int j = 0;
        do
        {
            Console.WriteLine("Inside a do-while loop");
            j = j + 1;
        } while(j < 10);


            //While
            int k = 0;
            while(k < 10)
            {
                Console.WriteLine("Inside a while loop");
                k = k + 1;
            }

        }


        public int SayHello(){
            Console.WriteLine("Hello from a fn");

            return 42;

        }

        
        public void AnotherOne(int val)
        {
            if (val < 40)
            {
                Console.WriteLine("Lower than 40");
            }
            else
            {
                Console.WriteLine("Greater than 40");
            }
        }
       

    }
}

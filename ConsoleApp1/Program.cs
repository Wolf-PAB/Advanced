using System;
namespace project1
{
    class test {
        public static void Main() {
            string Input_1 = Console.ReadLine();
            string Input_2 = Console.ReadLine();
            string Out =Input_1 + Input_2;
            int num1=Convert.ToInt32(Input_1);
            int num2=Convert.ToInt32(Input_2);
            int sum=num1 + num2;
            Console.WriteLine(Out);
            Console.WriteLine(sum);
                } 
    }
}
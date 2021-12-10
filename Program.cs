using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int devide = 2;
            int devide2;
            


            //Intro
            Console.WriteLine("Samagarntunka Solver\n\nDisclaimer : Not all answer are correct this is a very poor build console\nDisclaimer2 : this console can only solve within 4 Pahunarm\n\nHow to use : Example 2xgumlung3 - 3xgumlung2 - 7x - 6\nA=2 B=-3 C=-7 D=-6\n\n");


            //asking for input
            Console.WriteLine("Please enter the a value\n");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the b value\n");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the c value\n");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the d value\n");
            int d = Convert.ToInt32(Console.ReadLine());

            //Asking for the x
            Console.WriteLine("Please enter the X value\n");
            int X = Convert.ToInt32(Console.ReadLine());

            //end ask

            Console.WriteLine("\n\nDo you want to add /2 for the calculating?\ntype 1 for yes type 2 for no\n\n");
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 2)
            {
                //calculate 1
                int first = X * X * X;
                int second = X * X;
                int Third = X;

                int result3 = (a * first) + (b * second) + (c * Third) + (d);
                Console.WriteLine("The answer is " + result3 + "\n\n");
                {
                    if (result3 != 0)
                    {
                        Console.WriteLine("\n\nThe ans is incorrect loop begins\nIf you wish to exit the loop please input anynumber that's more than 55");

                        while (result3 != 0)
                        {
                            //Asking for the x
                            Console.WriteLine("\nPlease enter the X value\n");
                            int X2 = Convert.ToInt32(Console.ReadLine());
                            int firstx = X2 * X2 * X2;
                            int secondx = X2 * X2;
                            int Thirdx = X2;
                            int stop = 0;
                            if (X2 > 55){
                                Console.WriteLine("Exit code detected stopping loop");
                                break;
                            }

                            int result5 = (a * firstx) + (b * (secondx)+ (c * Thirdx) + d);
                            Console.WriteLine("The answer is " + result5 + "\n\n");
                            if(result5 == 0)
                            {
                                Console.WriteLine("The ans is clear stopping the loop");
                                break;
                            }
                        }
                    }
                }
            }
            else if (answer == 1)
            {
                //calculate 2
                //calculate 1
                int first = X * X * X;
                int second = X * X;
                int Third = X;

                int result3 = (a * first) + ((b * (second) / devide) + ((c * Third) / devide) + d);
                Console.WriteLine("The answer is " + result3 + "\n\n");
                {
                    if (result3 != 0) { 
                    Console.WriteLine("\n\nThe ans is incorrect loop begins\nIf you wish to exit the loop please input 0");

                    while (result3 != 0)
                    {
                            //Asking for the x
                            Console.WriteLine("\nPlease enter the X value\n");
                            int X2 = Convert.ToInt32(Console.ReadLine());
                            int firstx = X2 * X2 * X2;
                            int secondx = X2 * X2;
                            int Thirdx = X2;
                            int stop = 0;
                            if (X2 > 55)
                            {
                                Console.WriteLine("Exit code detected stopping loop");
                                break;
                            }

                            int result5 = (a * firstx) + ((b * (secondx) / devide) + ((c * Thirdx) / devide) + d);
                            Console.WriteLine("The answer is " + result5 + "\n\n");
                            if (result5 == 0)
                            {
                                Console.WriteLine("The ans is clear stopping the loop");
                                break;
                            }
                        }
                }
                }
            }





            //end task
            Console.WriteLine("Press any key to end");
            Console.ReadLine();



        }
    }
}

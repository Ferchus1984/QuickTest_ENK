using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAcademy_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //MethodsGA("Mike" , 33);
            //MethodsGA("Luis" , 22);
            //MethodsGA("Ricardo" , 56);
            //Console.ReadLine();

            //Console.WriteLine(cube(5));

            //Console.ReadLine();

            //Ifs();
            //Console.ReadLine();

            //Console.WriteLine(GetMax(200, 10, 30));
            //  Console.ReadLine();

            //NewCalc1();
            //Console.ReadLine();

            //Console.WriteLine(GetDay(3));
            //Console.ReadLine();

            Wloop();
            Console.ReadLine();


        }


        static void MethodsGA(string name, int age)  // giraffe academy
        {

            Console.WriteLine("Hi " + name + " you are " + age);


        }


        static int cube(int num)
        {
            int result = num + num + num;
            return result;

        }

        //Dependiendo el tipo de dato del metodo es lo que vas a decarar en el Metodo Main.


        //*******************   IF stainment*****************************//

        /*
         I wake up 
         If i'm hungry
            I eat breakfast

         I look at my  phone 
         if it's about to die
           I charge it

        I leave my house
        if it's cloundy
            I bring an umbrella
            otherwise
                I bring sunglasses

         */

        static void Ifs()
        {
            bool isMale = false;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("you are Male and Tall");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are Male but you are not tall");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are a tall female");
            }

            else
            {
                Console.WriteLine("You are either not male or not tall ");
            }







        }


        /*MORE if Statements */

        static int GetMax(int num1, int num2, int num3)
        {
            int result;

            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;
        }

        static void NewCalc1()
        {

        Console.Write("Enter a number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter a Operator: ");
        string op = Console.ReadLine();


        Console.Write("Enter a number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (op == "+")
        {
            Console.WriteLine(num1 + num2);
        }
        else if (op == "-")
        {
            Console.WriteLine(num1 - num2);
        }

        else if (op == "/")
        {
            Console.WriteLine(num1 / num2);
        }

        else if (op == "*")
        {
            Console.WriteLine(num1 * num2);
        }

        else
        {
            Console.WriteLine("Invalid Operator");
        }

        Console.ReadLine();

       
        }

        /*Swith Statements*/

        static string GetDay(int dayNum)
        {
            string dayName;


            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;

                case 1:
                    dayName = "Monday";
                    break;

                case 2:
                    dayName = "Tuesday";
                    break;

                case 3:
                    dayName = "Wensday";
                    break;

                case 4:
                    dayName = "Thursday";
                    break;

                case 5:
                    dayName = "Friday";
                        break;

                case 6:
                    dayName = "Saturday";
                    break;

                default:
                    dayName = "Invalid Day Number";
                    break;


            }




                return dayName;
        }

        /*While Loops*/

        static void Wloop()
        {
            int index = 1;
            while (index <100000)
            {
                Console.Write(index);
                index++;
    


            }
            Console.ReadLine();
        }


    }





}
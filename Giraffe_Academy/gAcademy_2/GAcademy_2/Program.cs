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
           
          Console.WriteLine(GetMax(2, 10));
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

        static int GetMax(int num1, int num2)
        {
            int result;

            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;

            }

            return result;
        }


    }
}
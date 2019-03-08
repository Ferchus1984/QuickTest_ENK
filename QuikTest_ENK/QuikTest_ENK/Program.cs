using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikTest_ENK
{
    class Program
    {
        static void Main(string[] args)
        {

            //Complete the below the methods and call them.
            //Method: IsNumberEven


            // IsNumberEven(3);


            //IsNumberEven(2);

            //Console.ReadKey();


            //Method: MaxAndMin


            //MaxAndMin();

            //Console.ReadKey();

            //Method: Mode

            //Mode();

            //Console.ReadKey();

            //Method: Average

            //Method: OrderArray

            //Method: ReverseWord

            //ArrayGA();
            //Console.ReadLine();

            MethodsGA();
                Console.ReadLine();



            /*
            //CREATE YOUR OWN METHOD FOR A PLAINDROME
            //Should receive a string and return bool
            //Should return true if the string is a palindrome or false if not a palindome.
            //A palindrome is a word, phrase, or sequence that reads the same backward as forward.
            */






        }

        /// <summary>        
        /// This method will print in screen if the word is even or not.
        /// </summary>
        /// <param name="word">word that will be counted</param>
        public static void IsNumberEven(int number)
        {
            // ************************************************************************************************************************
            //   ADD YOUR CODE HERE
            //    * ***********************************************************************************************************************

            int residuo = (number % 2);


            if (residuo == 0)
                    {
                        Console.WriteLine("El numero es par");
                    }
                    else
                    {
                        Console.WriteLine("El numero no es par");
                    }

            Console.ReadKey();



            // ************************************************************************************************************************

        }

        /// <summary>
        /// This method will print in console the max and min int on the provided array.
        /// </summary>
        public static void MaxAndMin()
        {
            //Array you will iterate and get max and min value
            int[] myArray = { 2, 1, 78, 77, 64, 5 };

            Console.WriteLine("\nInput Array:");

            //The below will print in console the values in the array.
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i].ToString() + ",");
            }
            Console.WriteLine("\n");

            Console.ReadKey();

            //************************************************************************************************************************
            //ADD YOUR CODE HERE
            //************************************************************************************************************************
            int maxValue = 0;
            int minValue = 0;
            //int MAR = myArray.Length - 1;

            for (int i = 0; i < myArray.Length - 1; i++)
            {

                // if (myArray[i] > myArray[i + 1] && MAR > i )
                if (maxValue <= myArray[i])
                {

                    maxValue = myArray[i];


                }
                else
                {
                   



                }


                //Console.Write(myArray[i].ToString() + ",");
            }

            Console.WriteLine("THE MAX VALUES IS: woooww {0}", maxValue);// {0}", maxValue.ToString());





            for (int i = 0; i < myArray.Length - 1; i++)
            {

                if (minValue >= myArray[i])
                {
                    //   minValue = myArray[i];

                    //Console.Write("valor minimo es {0}" );
                    minValue = myArray[i];

                }
                else
                {
                    if (minValue == 0)
                    {
                        minValue = myArray[i];

                    }
                    else
                    {

                    }

                }

                //  Console.Write(myArray[i].ToString() + ",");

            }

            Console.WriteLine("THE MAX VALUES IS: woooww {0}", minValue);// {0}", maxValue.ToString());


            //Console             , minValue.ToString()


            Console.WriteLine("\n");





            Console.ReadKey();





            //************************************************************************************************************************
            //USE THE BELOW TO PRINT MAX AND MIN 
            //  Console.WriteLine("THE MAX VALUES IS: {0}", maxValue.ToString());
            // Console.WriteLine("THE MIN VALUES IS: {0}", minValue.ToString());            
        }

        /// <summary>
        /// This method will print in console the mode of the provided array.
        /// </summary>
        public static void Mode()
        {
            //Array you will iterate and get the mod.
            //Mode is the value that repeats the most.
            int[] myArray = { 7, 4, 7, 77, 4, 7, 5, -4 };

            Console.WriteLine("\nInput Array:");

            //The below will print in console the values in the array.
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i].ToString() + ",");
            }
            Console.WriteLine("\n");

            //************************************************************************************************************************
            //ADD YOUR CODE HERE
            //************************************************************************************************************************
            int modeValue = 0;






            //************************************************************************************************************************
            //USE THE BELOW TO PRINT THE MODE       
            Console.WriteLine("THE MODE IS: {0}", modeValue.ToString());
        }


        /// <summary>
        /// This method will print in console the average of the provided array.         
        /// Average is 9.14
        /// </summary>
        public static void Average()
        {
            //Array you will iterate and get the average            
            int[] myArray = { 10, 10, 9, 8, 10, 9, 8 };

            Console.WriteLine("\nInput Array:");

            //The below will print in console the values in the array.
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i].ToString() + ",");
            }
            Console.WriteLine("\n");

            //************************************************************************************************************************
            //ADD YOUR CODE HERE
            //************************************************************************************************************************
            double average = 0;






            //************************************************************************************************************************
            //USE THE BELOW TO PRINT THE RESULT AVERAGE
            Console.WriteLine("THE MODE IS: {0}", average.ToString());
        }


        /// <summary>
        /// This method will print the array in ascending or descending order. Choose wisely.
        /// </summary>
        public static void OrderArray()
        {
            int[] myArray = { 5, -4, 8, 4, 5, 1, 0 };

            Console.WriteLine("\nInput Array:");

            //The below will print in console the values in the array.
            foreach (int number in myArray)
            {
                Console.Write(number.ToString() + ",");
            }
            Console.WriteLine("\n");
            //************************************************************************************************************************
            //ADD YOUR CODE HERE
            //************************************************************************************************************************




        }


        /// <summary>
        /// This method will receive a word and should be the same but in reverse order.
        /// EXAMPLE:
        /// Input word is Ferchus
        /// Expected output should be suhcreF
        /// </summary>
        /// <param name="word">Word that will be reversed</param>
        public static void ReverseWord(string word)
        {
            //INPUT WORD
            Console.WriteLine("\nInput word to reverse {0}", word);

            //************************************************************************************************************************
            //ADD YOUR CODE HERE
            //************************************************************************************************************************

        }



        public static void ArrayGA()  // giraffe academy
        {
            int[] luckyNumbers = { 4, 8 , 15, 16, 23, 42 };
            //  0  1   2   3    4   5   <---- Posiciones en el Array
            string[] friends = new string[5];
            friends[0] = "Rey";
            friends[1] = "Montse";
            friends[2] = "Pedro";
            friends[3] = "Alvaro";
            friends[4] = "Jaime";

            Console.WriteLine(luckyNumbers[4]);
            Console.WriteLine(friends[2]);


            Console.ReadLine();
        }


        static void MethodsGA()  // giraffe academy
        {

            Console.WriteLine("Hi User");

       
        }



    }
}

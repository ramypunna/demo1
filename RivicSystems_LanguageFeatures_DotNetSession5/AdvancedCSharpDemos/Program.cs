using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdvancedCSharpDemos
{
    class Program
    {
        
        //Declare delegates
        public delegate int CalculateDelegate(int num);
        static void Main(string[] args)
        {
            // #region delegates
            // // using delegates
            // CalculateDelegate p = new CalculateDelegate(Square);
            //// int i = Square(10);
            // int retVal = p(10);



            // //Console.WriteLine("Writing to file [{0}]", retVal);


            // CalculateDelegate p1 = new CalculateDelegate(Addition);
            // retVal = p(5);


            // //Console.WriteLine("Writing to file [{0}]", retVal);

            // int[] resultSquare = Transform(new int[] { 2, 4, 5 }, p);

            // for (int i = 0; i < resultSquare.Length; i++)
            // {
            //     Console.WriteLine(" {0} Value is {1} : ", i, resultSquare[i]);
            // }

            // Console.ReadLine();

            // int[] resultAddition = Transform(new int[] { 2, 4, 5 }, p1);

            // for (int i = 0; i < resultAddition.Length; i++)
            // {
            //     Console.WriteLine(" {0} Value is {1} : ", i, resultAddition[i]);
            // }

            // CalculateDelegate p2 = new CalculateDelegate(CalcSalary);

            // int[] resultSalary = Transform(new int[] { 2, 4, 5 }, p2);

            // Console.ReadLine();
            // #endregion delegates

            // DemoEvents();


            HandleExceptions();
        }

        #region delegate methods
        private static int[] Transform(int[] values, CalculateDelegate objDelegate)
        {
            for(int i=0;i<values.Length;i++)
            {
                values[i] = objDelegate(values[i]);
            }

            return values;
        }

        private static int Square(int num1)
        {
            return num1 * num1;
        }

        private static int Addition(int num2)
        {
            return num2 + num2;
        }

        public static int CalcSalary(int discount)
        {
            return 100;
        }

        #endregion delegate methods

        #region Events Demo
        private static void DemoEvents()
        {
            #region Events Demo
            Account objAcc = new Account(500);

            //subscribe to the event
            objAcc.OverDebitMade += ObjAcc_OverDebitMade;

            objAcc.Debit(1000);
            Console.WriteLine(objAcc.BalanceAmount);
            Console.ReadLine();
            #endregion
        }
        private static void ObjAcc_OverDebitMade(object sender, EventArgs e)
        {
            Console.WriteLine("Warning! Overdraft used");
            Console.ReadLine();
        }
        #endregion

        #region ExceptionHandling
        public static void HandleExceptions()
        {
            try
            {
                // StreamReader s = new StreamReader("C:\\NonexistentFile.txt");
                //StreamReader s1 = null;
                //s1.Peek();

                //if ( User is invalid)
                throw new UserInvalidException("User is invalid, please try to login agian");
            }

            catch(FileNotFoundException ex1)
            {
                Console.WriteLine("File does not exist");
                Console.WriteLine("Message " + ex1.Message);
                Console.WriteLine("Stack trace " + ex1.StackTrace);
                Console.WriteLine("Source " + ex1.Source);
                
                Console.ReadLine();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Sorry, something unexpected occured. please retry or contact customer care");
                Console.WriteLine("Stack trace " + ex.StackTrace);
                Console.WriteLine("Source " + ex.Source);
                Console.WriteLine("Message " + ex.Message);
                Console.ReadLine();
            }

            finally
            {

                Console.WriteLine("Finally block executed");
                Console.ReadLine();
            }

            Console.ReadLine();
        }
        #endregion ExceptionHandling
    }
}

using AndrewTroelsen.Value_Reference_Types;
using System;

namespace AndrewTroelsen
{
    internal class MainClass
    {
        public enum Letters : byte
        {
            A = 10,
            B = 20,
            C = 30
        };

        static void Main(string[] args)
        {
            #region Pointers   

            //object x = 7;
            //GCHandle handle = GCHandle.Alloc(x, GCHandleType.Pinned);
            //IntPtr address = handle.AddrOfPinnedObject();

            //Console.WriteLine("x = {0}", x);
            //Marshal.WriteInt32(address, 10);
            //Console.WriteLine("x = {0}", x);

            //int y = Marshal.ReadInt32(address);
            //Console.WriteLine("y = {0}", y);

            //Marshal.FreeHGlobal(address);

            #endregion

            #region Named Arguments

            //Sum(b: 7, a: 6);

            #endregion

            #region Enums

            //Console.WriteLine(Letters.A);
            //Console.WriteLine((int)Letters.A);

            #endregion

            #region Value/Reference Types

            //Console.WriteLine("***** Passing Person object by value *****");

            //Person fred = new Person("Fred", 12);

            //Console.WriteLine("\nBefore by value call, Person is:");
            //fred.Display();

            //SendAPersonByValue(fred);

            //Console.WriteLine("\nAfter by value call, Person is:");

            //fred.Display();

            #endregion

            #region The Null Coalescing Operator

            //int? age = getNullableInt() ?? 10;

            //Console.WriteLine(age);

            #endregion

            #region The Null Conditional Operator

            //TesterMethod(new string[4]);
            //TesterMethod(null);

            #endregion

            Console.ReadLine();
        }

        #region Value/Reference Types - SendAPersonByValue

        static void SendAPersonByValue(Person p)
        {
            p.personAge = 99;
            p = new Person("Nikki", 88);
        }

        #endregion

        #region The Null Coalescing Operator

        private static int? getNullableInt()
        {
            return null;
        }

        #endregion

        #region The Null Conditional Operator

        static void TesterMethod(string[] args)
        {
            // We should check for null before accessing the array data!
            Console.WriteLine($"You sent me {args?.Length ?? 0} arguments.");
        }

        #endregion
    }
}

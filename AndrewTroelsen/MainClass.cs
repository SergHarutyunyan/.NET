using AndrewTroelsen.Custom_Constructor_Init_Syntax;
using AndrewTroelsen.Has_a_Relationship;
using AndrewTroelsen.Value_Reference_Types;
using System;
using System.Collections;
using System.Collections.Generic;

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

            #region Value/Reference Types (With Method)

            //Console.WriteLine("***** Passing Person object by value *****");

            //Person fred = new Person("Fred", 12);

            //Console.WriteLine("\nBefore by value call, Person is:");
            //fred.Display();

            //SendAPersonByValue(fred);

            //Console.WriteLine("\nAfter by value call, Person is:");

            //fred.Display();

            #endregion

            #region The Null Coalescing Operator (With Method)

            //int? age = getNullableInt() ?? 10;

            //Console.WriteLine(age);

            #endregion

            #region The Null Conditional Operator (With Method)

            //TesterMethod(new string[4]);
            //TesterMethod(null);

            #endregion

            #region Calling Custom Constructors with Initialization Syntax

            //Point GoldPoint = new Point(PointColor.Gold) { X = 90, Y = 20 };
            //GoldPoint.DisplayStats();

            //Console.WriteLine();

            //Point BloodRedPoint = new Point() { X = 90, Y = 20 };
            //BloodRedPoint.DisplayStats();

            #endregion

            #region Inheritance: Has-a Relationship

            //Music music = new Music();
            //music.TurnRadioOn();

            #endregion

            #region Boxing

            //int i = 5;
            //object o = i;  // o is a reference type, it stored on the heap.
            //i = 20;

            //Console.WriteLine($"i = {i}\no = {o}");

            //object a = o;
            //o = 99; // Just switch the reference, now it's pointing to the new object. The previous value - 5 will be garbage collected.

            //Console.WriteLine($"\na = {a}\no = {o}");

            //int temp = (int)o;  // (int)o just returns number 99.

            //// There is no way to edit the created object. We are just creating others by assigning them another value.
            //// So Value inside the box is immutable. It can't be changed.
            //// This same thing is related to all System.ValueTypes (structs).

            //ArrayList arrayList = new ArrayList();      // ArrayList Add method adding object. So it uses boxing.
            //arrayList.Add(5);                           // So it is slowing the work and take more memory on the heap.
            //arrayList.Add(6);
            ////  Arraylist stored on the heap and also it's each member pointing to the boxed object. 

            //List<int> list = new List<int>();           // When generics comes, this problem solved. Now it stored as an int.
            //list.Add(5);
            //list.Add(6);
            //list.Add(7);
            // List stored on the heap but it's members are not boxed.

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

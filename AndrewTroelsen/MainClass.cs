﻿using AndrewTroelsen.Custom_Constructor_Init_Syntax;
using AndrewTroelsen.Has_a_Relationship;
using AndrewTroelsen.Type_Conversion_Operator;
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

            #region Type Object Pointer and Sync block

            /*
                Person p = new Person();
                p.personAge = 7;

                Person p1 = new Person();

                // Object that was created on the heap, containing -
                1. Sync Block
                2. Type Object Pointer
                3. All the stuff that the object include (members)

                1.
                // Sync Block is just a 4 bytes of area, that stores a value, when we lock(p) that specified instance.
                // This was used in Threading.

                2.
                // For every Person object 2. Type Objcet Pointer is just a pointer to the Person Type, 
                // which is only one object on the heap. So that Person Type is shared among all Person instances.                              
            */

            #endregion

            #region Type Conversion Operators

            ///********************************* operator keywoard **************************************/


            ////Car bmw = new Car { Modelname = "X5", ProductionYear = 2007 };
            ////Vehicle vehicle = bmw;

            ////Console.WriteLine(vehicle.productionYear);

            ///********************************* AS operator **************************************/

            //var randy = new Random();
            //bool randomBool = randy.Next() % 2 == 0;

            //Base b = randomBool ? new Base() : new Derived();
            //// In that case we cant write here like below. Because it can be new Base().
            //// Derived d = (Derived)b;

            //// So in that case we are doing like this.
            //Derived d = b as Derived; 
            //// This means - try to cast, if succeded return me new Derived(), if not return me null.

            //if(d == null)
            //    Console.WriteLine("d: Convertion failed.");
            //else
            //    Console.WriteLine("d: Convertion succeded.");

            ///********************************* IS operator **************************************/

            //Derived d2 = null;
            //if (b is Derived)
            //    d2 = (Derived)b;

            //if (d2 == null)
            //    Console.WriteLine("d2: Convertion failed.");
            //else
            //    Console.WriteLine("d2: Convertion succeded.");

            #endregion

            #region All about Static

            /*
                Static variable in that class will be shared among all instances of that class.
                But...
                When we specifying the variable static, it is loaded in memory at compile time, like global variables in C or C++.

                Static variables in compile time, are initialized in static constructer. Even if we haven't created static constructor
                explicitely, and just wrote like static int a = 7;
                Static constructors called in begginning and only once.

                Stack and Heap are called dynamic memory. 
                Static variables stored not in stack, neither in heap. It Stored in static memory.

                Loader Heap:            contains CLR structures and the type system
                High Frequency Heap:    statics, MethodTables, FieldDescs, interface map
                Low Frequency Heap:     EEClass, ClassLoader and lookup tables
                Stub Heap:              stubs for CAS, COM wrappers, PInvoke
                Large Object Heap:      memory allocations that require more than 85k bytes
                GC Heap:                user allocated heap memory private to the app
                JIT Code Heap:          memory allocated by mscoreee (Execution Engine) and the JIT compiler for managed code
                Process/Base Heap:      interop/unmanaged allocations, native memory, etc

                Usually, the “heaps” that most people refer to or know about are the “GC Heap” and the LOH.
                GC Heap is shared among app-domains and GC will work only on that.
                
            */

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

using Learn.Attributes;
using Learn.Interfaces;
using Learn.OperatorOverloading;
using Learn.PartialClass;
using Learn.Structs;
using Learn.Constructor_and_Destructor;
using Learn.Has_a_Relationship;
using Learn.Type_Conversion_Operator;
using Learn.Value_Reference_Types;
using Learn.Polymorphism;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Learn.RefReturns_and_RefLocals;
using Learn.LocalFunctionsWithExceptions;
using Learn.ExtensionMethods;
using static Learn.DelegatesAndEvents.DelegateContainer;
using Learn.DelegatesAndEvents;
using Learn.Exceptions;
using Learn.FileSystemAndIO;
using Microsoft.VisualBasic.FileIO;
using Learn.Indexers;
using System.Linq;

namespace Learn
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

            #region Extension Methods

            //String a = "sa";
            //a = a.changeFirstLettersCase();

            //Console.WriteLine(a);

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

            #region Constructor and Destructor

            //Point GoldPoint = new Point(PointColor.Gold) { X = 90, Y = 20 };
            //GoldPoint.DisplayStats();

            //Console.WriteLine();

            //Point BloodRedPoint = new Point() { X = 90, Y = 20 };
            //BloodRedPoint.DisplayStats();


            // DestructorExample destructorExample = new DestructorExample();
            // Destructors are not called directly in the source code but during garbage collection. 


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

                Static variables in compile time, are initialized in static constructor. Even if we haven't created static constructor
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

            #region Interfaces

            //Example example = new Example();
            //example.fly();
            //example.CallExplicitFly();              // Calling Explicit implementation

            //Console.WriteLine();

            //IExample example1 = new Example();
            //example1.fly();                         // Calling Explicit implementation

            #endregion

            #region Operator Overloading

            //Complex complex1 = new Complex(1, 5);
            //Complex complex2 = new Complex(3, 8);
            //Complex complex3 = new Complex(1, 5);

            //Complex sum = complex1 + complex2;

            //Console.WriteLine(sum.ToString());
            //Console.WriteLine();

            //Console.WriteLine(complex1 == complex2);
            //Console.WriteLine(complex1 == complex3);            // Cause we have explicitely overloaded == and != operators
            //                                                    // complex1 will be equal to complex3 (because of equal real and imaginary values)
            //                                                    // So if we delete overloaded operators, == operator will check the references,
            //                                                    // so it will return false.
            #endregion

            #region Partial Class

            //PartialExample partialExample = new PartialExample();
            //partialExample.method1();
            //partialExample.method2();

            #endregion

            #region Out Parameters

            //int a;
            //int b = 7;

            //OutTest(out a);
            //OutTest(out b);
            //OutTest(out int c);

            //Console.WriteLine($"a = {a}\nb = {b}\nc = {c}");
            //a = c;

            #endregion

            #region Attributes

            //MyClass myClass = new MyClass();
            //myClass.Old();                          // Compile time error - "Don't use Old method, please use New method"

            #endregion

            #region Structs

            //Struct1 struct1 = new Struct1(1, 2);
            //Struct1 struct2 = new Struct1(3, 4);
            //Console.WriteLine(struct1.d);
            //Console.WriteLine(struct1.e);
            //Console.WriteLine(Struct1.b);

            //Console.WriteLine();

            //Console.WriteLine(struct1.Equals(struct2));
            //Console.WriteLine(struct2.d);

            //Console.WriteLine();

            //Struct1? nullableStruct1 = new Struct1?(new Struct1(5,6));
            //Console.WriteLine(nullableStruct1.HasValue);
            //Console.WriteLine(nullableStruct1.Value.d);
            //nullableStruct1 = null;
            //Console.WriteLine(nullableStruct1.HasValue);

            //Console.WriteLine();

            //Struct1 struct3 = new Struct1();
            //Console.WriteLine(struct3.d);
            //Console.WriteLine(struct3.e);

            #endregion

            #region Polymorphism

            //Polymorphism.Base baseClass = new Polymorphism.Base();
            //Polymorphism.Derived derived = new Polymorphism.Derived();
            //Polymorphism.Base baseDerived = new Polymorphism.Derived();

            //Console.Write("Calling baseClass Print - "); baseClass.Print();
            //Console.Write("Calling baseClass PrintVirtual - "); baseClass.PrintVirtual();
            //Console.WriteLine();

            //Console.Write("Calling derived Print - "); derived.Print();
            //Console.Write("Calling derived PrintVirtual - "); derived.PrintVirtual();
            //Console.WriteLine();

            //Console.Write("Calling baseDerived Print - "); baseDerived.Print();
            //Console.Write("Calling baseDerived PrintVirtual - "); baseDerived.PrintVirtual();
            //Console.WriteLine();

            //Polymorphism.DerivingDerived derivingDerived = new Polymorphism.DerivingDerived();
            //Polymorphism.Derived derivedDerivingDerived = new Polymorphism.DerivingDerived();
            //Polymorphism.Base baseDerivingDerived = new Polymorphism.DerivingDerived();

            //Console.Write("Calling derivingDerived Print - "); derivingDerived.Print();
            //Console.Write("Calling derivingDerived PrintVirtual - "); derivingDerived.PrintVirtual();
            //Console.Write("Calling derivingDerived base Print - "); derivingDerived.PrintBase();
            //Console.Write("Calling derivingDerived base PrintVirtual - "); derivingDerived.PrintBaseVirtual();
            //Console.WriteLine();


            //Console.Write("Calling derivedDerivingDerived Print - "); derivedDerivingDerived.Print();
            //Console.Write("Calling derivedDerivingDerived PrintVirtual - "); derivedDerivingDerived.PrintVirtual();
            //Console.WriteLine();

            //Console.Write("Calling baseDerivingDerived Print - "); baseDerivingDerived.Print();
            //Console.Write("Calling baseDerivingDerived PrintVirtual - "); baseDerivingDerived.PrintVirtual();
            //Console.WriteLine();

            //derived.PrintNumber(4);                         // This will call not the overridden method.
            //((Polymorphism.Base)derived).PrintNumber(4);    // This will call the overridden method.

            #endregion

            #region Ref Return Values

            //string[] b = { "a", "b", "c" };
            //RefExample<string> refExampleStr = new RefExample<string>();
            //ref string loc2 = ref refExampleStr.GetIndex(ref b, 1);

            //Console.WriteLine(loc2);
            //loc2 = "d";
            //Console.WriteLine(b[1]);

            #endregion

            #region Local Functions in use with Exceptions

            /*
                 IN THIS EXAMPLE - The exception surfaces only when you iterate the numbers, and not when you retrieve the enumerator
             */

            //IEnumerable<int> ienum =  WithoutLocalFuncExample.OddSequence(50, 110);
            //Console.WriteLine("Retrieved enumerator...");

            //foreach (var i in ienum)
            //{
            //    Console.Write($"{i} ");
            //}


            /*
                 IN THIS EXAMPLE - We can throw an exception when performing validation
                 and before retrieving the iterator by returning the iterator from a local function, as the following example shows.
             */

            //IEnumerable<int> ienum2 = WithLocalFunc.OddSequence(50, 110);
            //Console.WriteLine("Retrieved enumerator...");

            //foreach (var i in ienum2)
            //{
            //    Console.Write($"{i} ");
            //}

            /* Local functions can be used in a similar way to handle exceptions outside of the asynchronous operation. */

            #endregion

            #region Delegates and Events (With Methods)

            //Print print = DelegateMethod;
            //// Because the instantiated delegate is an object, it can be passed as a parameter, or assigned to a property.
            //// This allows a method to accept a delegate as a parameter, and call the delegate at some later time. 

            //print("Hello");        

            //// Passing a delegate to method.
            //MethodWithCallback(3, 4, print);

            //// Wrapping another function to that delegate.
            //print += DelegateMethod2;
            //print("Hello");

            //// To find the number of methods in a delegate's invocation list, you may write:
            //int invocationCount = print.GetInvocationList().GetLength(0);
            //Console.WriteLine(invocationCount);

            //// HISTORY // 

            //// In C# 2.0 and later, it is also possible to use an anonymous method to declare and initialize a delegate,
            //// as shown in the following example.
            //Print del3 = delegate (string name)
            //    { Console.WriteLine("Notification received for: {0}", name); };

            //// In C# 3.0 and later, delegates can also be declared and instantiated by using a lambda expression,
            //// as shown in the following example.
            //Print del4 = name => { Console.WriteLine("Notification received for: {0}", name); };


            /*************** EVENTS ****************/
            //// SIMPLE EXAMPLE 
            //EventContainer eventContainer = new EventContainer();

            //eventContainer.OnKeyEntered += EventSubscriber;
            //eventContainer.OnKeyEntered += delegate (ConsoleKey key)
            //{
            //    Console.WriteLine(key.ToString() + " was entered: Invoked from delegate");
            //};

            //eventContainer.RaiseEvent();

            //// Unsubscribing
            //eventContainer.OnKeyEntered -= EventSubscriber;



            //// ANOTHER EXAMPLE 
            //Publisher pub = new Publisher();
            //Subscriber sub1 = new Subscriber("sub1", pub);
            //Subscriber sub2 = new Subscriber("sub2", pub);

            //// Call the method that raises the event.
            //pub.DoSomething();

            //// Keep the console window open
            //Console.WriteLine("Press Enter to close this window.");
            //Console.ReadLine();

            #endregion

            #region Exceptions

            //ExceptionExample exceptionExample = new ExceptionExample();
            //exceptionExample.TestFinally();

            #endregion

            #region File System and IO

            //// Using recursion
            //RecursiveFileSearch.Run();
            //// Using Stack
            ////StackBasedIteration.Run(":C/");

            //string sourcePath = @"C:\Windows\symbols\";
            //// Choose a destination for the copied files.
            //string destinationPath = @"C:\TestFolder";

            //FileSystem.CopyDirectory(sourcePath, destinationPath,
            //UIOption.AllDialogs);

            #endregion

            #region Indexers

            //SampleCollection<long> sampleCollection = new SampleCollection<long>();
            //sampleCollection[0] = 98;

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

        #region Out Parameters

        public static void OutTest(out int a)
        {
            a = 8;
        }

        #endregion

        #region Delegates 

        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        public static void DelegateMethod2(string message)
        {
            Console.WriteLine(message + " - 2");
        }

        public static void MethodWithCallback(int param1, int param2, Print callback)
        {
            callback("The number is: " + (param1 + param2).ToString());
        }

        #endregion

        #region Events

        public static void EventSubscriber(ConsoleKey key)
        {
            Console.WriteLine(key.ToString() + " was entered");
        }

        #endregion
    }
}

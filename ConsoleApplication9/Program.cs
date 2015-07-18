using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApplication9
{


    class Program
    {

        //        Also note that many numerical data types derive from a class named System.ValueType.
        //Descendents of ValueType are automatically allocated on the stack and, therefore, have a very
        //predictable lifetime and are quite efficient. On the other hand, types that do not have System.ValueType
        //in their inheritance chain (such as System.Type, System.String, System.Array, System.Exception, and
        //System.Delegate) are not allocated on the stack, but on the garbage-collected heap. (More information
        //on this distinction can be found in Chapter 4.)
        static int Main(string[] args)
        {
            //Console.WriteLine("asdasd");
            //Console.WriteLine("asdasd");
            //string a = "asd";
            //Console.WriteLine();
            // Get arguments using System.Environment.
            //alt up ile satiri yukari kaydiriyorduk.
            //shift delete ile satir siliyoruz
            Console.Clear();
            //cw code snippeti baya faydali.
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Beep();

            // The following string is printed verbatim,
            // thus all escape characters are displayed.
            Console.WriteLine(@"C:\MyApp\bin\Debug");
            string[] theArgs = Environment.GetCommandLineArgs();
            foreach (string arg in theArgs)
                Console.WriteLine("Arg: {0}", arg);
            Console.ReadLine();
            NewingDataTypes();
            Action abc = new Action(NewingDataTypes);
            CallbackTest(abc);

            StringEquality();
            return -1;
        }

        static void CallbackTest(Action e)
        {
            e.Invoke();
        }

        static void NewingDataTypes()
        {

            System.ValueType SomeValue = new int();
            Console.WriteLine("=> Using new to create variables:");
            bool b = new bool(); // Set to false.
            int i = new int(); // Set to 0.
            double d = new double(); // Set to 0.
            DateTime dt = new DateTime(); // Set to 1/1/0001 12:00:00 AM
            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
            Console.WriteLine();
            Console.ReadLine();

        }
        static void ParseFromStrings()
        {
            Console.WriteLine("=> Data type parsing:");
            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0}", b);
            double d = double.Parse("99.884");
            Console.WriteLine("Value of d: {0}", d);
            int i = int.Parse("8");
            Console.WriteLine("Value of i: {0}", i);
            char c = Char.Parse("w");
            Console.WriteLine("Value of c: {0}", c);
            Console.WriteLine();
        }

        static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String functionality:");
            string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("firstName has {0} characters.", firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("firstName contains the letter y?: {0}",
            firstName.Contains("y"));
            Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy", ""));
            Console.WriteLine();
        }

        //        However, even though the string data type is indeed a reference type, the equality operators have been
        //redefined to compare the values of string objects, not the object in memory to which they refer.
        static void StringEquality()
        {
            Console.WriteLine("=> String equality:");
            string s1 = "Hello!";
            string s2 = "Yo!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();
            // Test these strings for equality.
            Console.WriteLine("s1 == s2: {0}", s1 == s2);
            Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
            Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
            Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Yo.Equals(s2): {0}", "Yo!".Equals(s2));
            Console.WriteLine();
        }

        //        What is unique about the StringBuilder is that when you call members of this type, you are directly
        //modifying the object’s internal character data (making it more efficient), not obtaining a copy of the data
        //in a modified format. When you create an instance of the StringBuilder, you can supply the object’s
        //initial startup values via one of many constructors. If you are new to the topic of constructors, simply
        //understand that constructors allow you to create an object with an initial state when you apply the new
        //keyword. Consider the following usage of StringBuilder:
        static void FunWithStringBuilder()
        {
            Console.WriteLine("=> Using the StringBuilder:");
            StringBuilder sb = new StringBuilder("**** Fantastic Games ****");
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Morrowind");
            sb.AppendLine("Deus Ex" + "2");
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());
            sb.Replace("2", " Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars.", sb.Length);
            Console.WriteLine();
        }



    }


}

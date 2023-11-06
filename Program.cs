using System;
using System.ComponentModel;
using System.Text;
using System.Xml.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SampleActivities
{
    internal class Program
    {
        // Arrays
        // Indices and Ranges
        // String Builder
        // Ref Modifier
        // Out Modifier
        // Params Modifier

        static void Main(string[] args)
        {
            // Indices Example
            Index last = ^1;
            Index first = 0;
            int[] arr = { 1, 2, 3,4,5,6,7,8,9};

            ArrayPrinter(arr);
            Console.WriteLine(  );
            Console.WriteLine($"First Array: {arr[first]}\n" +
                $"Last Array: {arr[last]}");

            // Indices Example

            //Ranges Example
            int firstMiddle = arr.Length / 2 ;
            int secondMiddle = arr.Length / 2 + 1;


            int[] firstTwo = arr[..2];
            int[] lastTwo = arr[^2..];
            int[] middle = arr[firstMiddle..secondMiddle];
            Console.Write("The First Two Array: ");
            ArrayPrinter(firstTwo);
            Console.Write("The Last Two Array: ");
            ArrayPrinter(lastTwo);
            Console.Write("The Middle Array: ");
            ArrayPrinter(middle);

            Console.WriteLine(  );
            //Ranges Example

            //String Builder Example

            //used a list to more names to print in the string builder
            List<string> listNames = new List<string>();
            listNames.Add("Melanio");
            listNames.Add("Flores");
            listNames.Add("Douppy");
            listNames.Add("Kuting Ting");
            StringBuilder sb = new StringBuilder();
            _StringBuilder(sb,listNames);
            Console.WriteLine(sb.ToString());

            //String Builder Example

            Console.WriteLine();

            // Ref Modifier Example
            string name = "String Container";

            Console.WriteLine(name);
            refX(ref name); // pass the value of the name in refX to the string name
            Console.WriteLine(name);

            // Ref Modifier Example

            // An out argument is like a ref argument except for the following:
            // It need not be assigned before going into the function.
            // It must be assigned before it comes out of the function.
            // Out Modifier Example
            string firstName, lastName;

            SplitTheNameAndLastName(name,out firstName, out lastName);

            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
            // Out Modifier Example

            // Params Modifier Example
            // The params modifier, if applied to the last parameter of a method, allows the
            // method to accept any number of arguments of a particular type.The parameter
            // type must be declared as an (single - dimensional) array
            int total = Sum(1, 2, 3, 4, 5, 6);
            Console.WriteLine(total);
            // Params Modifier Example

        }

        private static int Sum(params int[] ints)
        {
            int sum = 0;

            for (int i = 0; i < ints.Length; i++)
            {
                sum += ints[i];
            }

            return sum;
            
        }

        private static void SplitTheNameAndLastName(string name, out string firstName, out string lastName)
        {
            int lastIndexOfSpace = name.LastIndexOf(' ');
            firstName = name.Substring(0, lastIndexOfSpace);
            lastName = name.Substring(lastIndexOfSpace + 1);

        }

        private static void refX(ref string name)
        {
            name = "Melanio III Flores";
            
        }

        public static void ArrayPrinter(int[] arr)
        {
            
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static void _StringBuilder(StringBuilder someString, List<string> listNames)
        {
            foreach (var item in listNames)
            {
                someString.Append($"{item} ");
            }
            someString = null;

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuckwitharrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("fuck with arrays");
            SimpleArrays();
            ArrayInitialization();
            DeclareImplicitArray();
            ArrayOfObjects();
            RectMultidimArray();
            JaggedArray();
            Console.WriteLine("pass and receive");
            int[] ages = { 10, 20, 22, 0 };
            PrintArray(ages);
            string[] strs = GetstringArray();
            foreach (string s in strs)
                Console.WriteLine(s);
            Console.ReadLine();
        }
        static void PrintArray (int[] myInts)
        {
            for (int i=0;i<myInts.Length; i++)
                Console.WriteLine("item {0} is {1}",i,myInts[i]);
        }
        static string[] GetstringArray()
        {
            string[] theStrings = { "hello", "from", "getstringArray" };
            return theStrings;
        }
        
        static void JaggedArray()
        {
            int[][] myjagArray = new int[5][];
            for (int i = 0; i < myjagArray.Length; i++)
                myjagArray[i] = new int[i + 7];
            for (int i=0;i<5;i++)
            {
                for (int j = 0; j<myjagArray[i].Length; j++)
                    Console.Write(myjagArray[i][j]+" ");
                Console.WriteLine();
            }
        }
        static void RectMultidimArray()
        {
            Console.WriteLine("rect array");
            int[,] myMatrix;
            myMatrix = new int[6, 6];
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 6; j++)
                    myMatrix[i, j] = i * j;
            for (int i = 0;i<6;i++)
            {
                for (int j=0;j<6;j++)
                    Console.Write(myMatrix[i,j]+"\t");
                Console.WriteLine();
            }
        }
        static void ArrayOfObjects()
        {
            Console.WriteLine("array of objects");
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = "true";
            myObjects[3] = new DateTime(1969, 3, 24);
            foreach (object obj in myObjects)
            {
                Console.WriteLine("Type {0},Value {1}", obj.GetType(),obj);
            }
        }
        static void DeclareImplicitArray()
        {
            Console.WriteLine("implicit Array initialisation");
            var a = new[] { 1, 10, 200, 3213 };
            Console.WriteLine("a is {0}", a.ToString());
            var b = new[] { 1.2, 1.5, 5.2 };
            Console.WriteLine("b is {0}", b.ToString());
            var c = new[] { "hello", "hi", "no" };
            Console.WriteLine("c is {0}",c.ToString());
        }
        static void ArrayInitialization()
        {
            Console.WriteLine("array initalisation");
            string[] stringArray = new string[] { "one", "two", "three" };
            Console.WriteLine("stringArray has {0} elements",stringArray.Length);
            bool[] boolArray = { false, true, false };
            Console.WriteLine("boolarray has {0} elements", boolArray.Length);
            int[] intArray = new int[4] { 20, 22, 23, 0 };
            Console.WriteLine("int array has {0} elements", intArray.Length);
        }
        static void SimpleArrays()
        {
            Console.WriteLine("simple array creation");
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;
            foreach (int i in myInts)
            {
                Console.WriteLine(i);
                              
            }
            string[] booksOnDotNet = new string[100];
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysStringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Object o = new Object();

            Object o2 = null;
            Object o3;

            String s = "Hello";
            string s2 = "Hello";
            int[] intArray = { 1, 2, 3 };
            int[] intArray2 = new int[3];

            int[][] tDArray = new int[2][];


            tDArray[0] = intArray;
            tDArray[1] = intArray2;

            foreach (var item in tDArray)
            {
                //Console.WriteLine(item);
                foreach (var item2 in item)
                {
                    Console.Write(item2 + " ");
                }
                Console.WriteLine();
            }

            //My Code

            int[][] tDarray1 = new int[9][];

            for(int i =0; i < tDarray1.Length; i++)
            {
                tDarray1[i] = new int[tDarray1.Length];
            }

            for (int i = 0; i < tDarray1.Length; i++)
            {
                for (int j = 0; j < tDarray1[i].Length; j++)
                {
                    tDarray1[i][j] = (i + 1) * (j + 1);

                    Console.Write((j+1) + " * " + (i+1) +" = "+ tDarray1[i][j]+"\t");
                }
                Console.WriteLine();
            }

            // String s1 = new String("Hello");
            }
    }
}

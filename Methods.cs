using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._03._22
{
    internal class Methods
    {
            public static int Pop(ref int[] array)
            {
            int deleted = array[array.Length - 1];
            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
            return deleted;
             }

            public static int Push(ref int[] array)
            {
            int[] newArray = new int[array.Length + 1];
            Random random = new Random();

            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                if (i < newArray.Length - 1)
                newArray[i] = array[i];
                else
                newArray[i] = random.Next(8); ;
            }
            array = newArray;
           
            return newArray.Length;
            }
        }
    }



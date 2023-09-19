using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_BinarySearch;

public static class ArrayCustomWrapper
{

    public static int binarySearch(int[] arrayofint, int Numbertosearch)
    {
        
        int ArrayStart = 0;
        int LengthofArray = arrayofint.Length - 1;

        
        while (ArrayStart <= LengthofArray)              
        {
            int midofthearray = (ArrayStart + LengthofArray) / 2;    
            if (Numbertosearch < arrayofint[midofthearray])
                LengthofArray = midofthearray - 1;          
                                    
                                    
            else if (Numbertosearch > arrayofint[midofthearray])
                ArrayStart = midofthearray + 1;          
                                    
            else return midofthearray;          
        }
        
        return -1;
    }


    public static int[] ArraySort(int[] arrayofint)
    {
        int temp = 0;
        for (int i = 0; i <= arrayofint.Length - 1; i++)
        {
            for (int j = i + 1; j < arrayofint.Length; j++)
            {
                if (arrayofint[i] > arrayofint[j])
                {
                    temp = arrayofint[i];
                    arrayofint[i] = arrayofint[j];
                    arrayofint[j] = temp;
                }
            }
        }

        return arrayofint;
    }
}

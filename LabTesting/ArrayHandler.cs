using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTesting
{
    struct Answer
    {
        public int[] array;
        public string log;
    }
    class ArrayHandler
    {
        public static Answer GetArray(int[] array, char ratio)
        {
            int[] newArray = new int[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (IsPrime(array[i]) && Compare(ratio, GetFirstDigit(array[i]), GetLastDigit(array[i])))
                {
                    Array.Resize(ref newArray, newArray.Length + 1);
                    newArray[newArray.Length - 1] = array[i];
                }
            }
            Answer answer = new Answer();
            if (newArray.Length > 0)
            {
                answer.array = newArray;
                answer.log = "Successfully";
            }
            else
            {
                answer.log = "Error";
            }
            return answer;
        }

        //Является ли число простым
        public static bool IsPrime(int value)
        {
            for (int i = 2; i <= value / 2; i++)
                if (value % i == 0)
                    return false;
            return true;
        }

        public static int GetFirstDigit(int value)
        {
            return value / 1000;
        }

        public static int GetLastDigit(int value)
        {
            return value % 10;
        }

        public static bool Compare(char ratio, int value1, int value2)
        {
            if (ratio == '>')
            {
                if (value1 > value2)
                    return true;
                else
                    return false;
            }
            else if (ratio == '<')
            {
                if (value1 < value2)
                    return true;
                else
                    return false;
            }
            return false;
        }
    }
}

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
        const int lenght = 10;
        char ratio;
        int[] array;

        public ArrayHandler(int[] array, char ratio)
        {
            this.array = array;
            this.ratio = ratio;
        }
        public Answer GetArray()
        {
            int[] newArray = new int[0];
            for (int i = 0; i < lenght; i++)
            {
                if (IsPrime(array[i]) && Compare(GetFirstDigit(array[i]), GetLastDigit(array[i])))
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
        private bool IsPrime(int value)
        {
            for (int i = 2; i <= value / 2; i++)
                if (value % i == 0)
                    return false;
            return true;
        }

        private int GetFirstDigit(int value)
        {
            return value / 1000;
        }

        private int GetLastDigit(int value)
        {
            return value % 10;
        }

        private bool Compare(int value1, int value2)
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

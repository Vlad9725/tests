using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTesting
{
    class InputOutputHandler
    {
        public static bool isDev = true;

        public static int[] ConvertStringToArray(string numbers, int size)
        {
            int[] data = new int[size];
            string[] values = numbers.Split(' ');

            if (!isDev && values.Length != size)
                throw new Exception("Неверный ввод, вы должны ввести "+size+" чисел!");

            for (int i = 0; i < values.Length; i++)
            {
                try
                {
                    data[i] = int.Parse(values[i]);
                }
                catch
                {
                    throw new Exception("В строке обнаружены недопустимые символы либо она незначащая!");
                }

                if (!isDev)
                {
                    if (data[i] < 0)
                        throw new Exception("Неверный ввод, отрицательные числа запрещены!");
                    else if (data[i] < 1000 || data[i] > 9999)
                        throw new Exception("Неверный ввод, не все числа четырёхзначные!");
                }
            }

            return data;
        }

        public static string ConvertArrayToString(ref int[] array)
        {
            string answer = "";
<<<<<<< HEAD

            if (array == null)
                return answer;

            for (int i = 0; i < array.Length; i++)
            {
                answer += array[i].ToString() + " ";
=======
            for (int i = 0; i < array.Length; i++)
            {
                answer += array[i].ToString() + " "; ;
>>>>>>> 530faa252f919dd2a15ad234253687a439d26c1e
            }
            return answer;
        }
    }
}

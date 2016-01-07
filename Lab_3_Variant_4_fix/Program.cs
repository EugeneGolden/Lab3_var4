using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab_work_3_Var_4
{
    class Program
    {
        public Dictionary<float, int> digitsAmountDict(float[] arr, Dictionary<float, int> dict)
        {
            var returnDict = new Dictionary<float, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!returnDict.ContainsKey(arr[i]))
                {
                    returnDict.Add(arr[i], 1);
                }
                else
                {
                    returnDict[arr[i]]++;
                }
            }
            return returnDict;
        }

        static void Main(string[] args)
        {
            // Даны два неубывающих массива x и y. Найти их пересечение, то есть неубывающий массив z, содержащий их общие элементы,
            //причем кратность каждого элемента в массиве z равна минимуму его кратностей  в массивах x и y.
            const int firstLength = 7;
            const int secondLength = 6;

            float[] firstArray = new float[firstLength] { 1, 3, 4, 4, 5, 5, 5 };
            float[] secondArray = new float[secondLength] { 1, 4, 4, 4, 5, 5 };
            ArrayList thirdArray = new ArrayList();

            //Словари для подсчета количества каждой цифры в соответствующем массиве
            Dictionary<float, int> firstDict = new Dictionary<float, int>();
            Dictionary<float, int> secondDict = new Dictionary<float, int>();

            Program pr = new Program();
            firstDict = pr.digitsAmountDict(firstArray, firstDict);
            secondDict = pr.digitsAmountDict(secondArray, secondDict);

            //Зная количество каждой цифры в обоих массивах, выводим в результирующий массив наименьшее их количество,
            //и только тех, которые существуют в обоих массивах
            for (int i = 0; i < firstDict.Count; i++)
            {
                for (int j = 0; j < secondDict.Count; j++)
                {
                    var itemFirstDict = firstDict.ElementAt(i);
                    var itemSecondDict = secondDict.ElementAt(j);
                    if (itemFirstDict.Key == itemSecondDict.Key)
                    {
                        /*if (itemFirstDict.Value <= itemSecondDict.Value)
                        {
                            for (int k = 0; k < itemFirstDict.Value; k++)
                            {
                                thirdArray.Add(itemFirstDict.Key);
                            } 
                        }
                        else
                        {
                            for (int l = 0; l < itemSecondDict.Value; l++)
                            {
                                thirdArray.Add(itemSecondDict.Key);
                            }
                        }*/
                        for (int k = 0; k < Math.Min(itemFirstDict.Value, itemSecondDict.Value); k++)
                        {
                            thirdArray.Add(itemSecondDict.Key);
                        }
                    }
                }
            }

            Console.WriteLine("Элементы первого массива:");
            for (int m = 0; m < firstArray.Length; m++)
            {
                Console.Write(" " + firstArray[m]);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Элементы второго массива:");
            for (int m = 0; m < secondArray.Length; m++)
            {
                Console.Write(" " + secondArray[m]);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Элементы результирующего массива:");
            for (int m = 0; m < thirdArray.Count; m++)
            {
                Console.Write(" " + thirdArray[m]);
            }
            Console.ReadKey();
        }    
    }
}

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

            //Найдем сколько раз каждая цифра содержится в первом массиве
            for (int i = 0; i < firstLength; i++)
            {
                if (!firstDict.ContainsKey(firstArray[i]))
                {
                    firstDict.Add(firstArray[i], 1);
                }
                else
                {
                    firstDict[firstArray[i]]++;
                }
            }

            //Найдем сколько раз каждая цифра содержится во втором массиве
            for (int i = 0; i < secondLength; i++)
            {
                if (!secondDict.ContainsKey(secondArray[i]))
                {
                    secondDict.Add(secondArray[i], 1);
                }
                else
                {
                    secondDict[secondArray[i]]++;
                }
            }


            //Выведем словарь для просмотра
            foreach (KeyValuePair<float, int> kvp in firstDict)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            Console.WriteLine();

            //Выведем словарь для просмотра
            foreach (KeyValuePair<float, int> kvp in secondDict)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            Console.ReadKey();

            for (int i = 0; i < firstDict.Count; i++)
            {
                for (int j = 0; j < secondDict.Count; j++)
                {
                    var itemFirstDict = firstDict.ElementAt(i);
                    var itemSecondDict = secondDict.ElementAt(j);
                    if (itemFirstDict.Key == itemSecondDict.Key)
                    {
                        if (itemFirstDict.Value <= itemSecondDict.Value)
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
                        }
                    }
                }
            }

            for (int m = 0; m < thirdArray.Count; m++)
            {
                Console.WriteLine("thirdArray is " + thirdArray[m]);
            }
            Console.ReadKey();
        }    
    }
}

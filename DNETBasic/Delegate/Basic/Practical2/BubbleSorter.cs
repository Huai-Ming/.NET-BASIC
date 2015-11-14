using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Basic.Practical2
{
    public class BubbleSorter
    {
        public static void Sort<T>(IList<T> sortArray, Func<T, T, bool> comparision)
        {
            bool swapped = false;
            do
            {
                swapped = false;
                for(int i = 0; i < sortArray.Count() -1; i++)
                {
                    if(comparision(sortArray[i + 1],sortArray[i]))
                    {
                        T temp = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = temp;
                        swapped = true;
                    }
                }

            } while (swapped);
        }
    }
}

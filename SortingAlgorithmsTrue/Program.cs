using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmsTrue
{
    class Program
    {       
        static void Main(string[] args)
        {
            int[] nums = { 5, 2, 1, 7, 6 };
            int temp;

            Console.WriteLine("Before Sort: [{0}]", string.Join(", ", nums));

            ////BUBBLE SORT 
            //for (int counter = 0; counter < nums.Length; counter++)
            //{
            //    for (int index = 0; index < nums.Length-1; index++)
            //    {
            //        if (nums[index] > nums[index + 1])
            //        {
            //            temp = nums[index + 1];
            //            nums[index + 1] = nums[index];
            //            nums[index] = temp;
            //        }
            //    }
            //}

            ////INSERTION SORT 
            //for (int counter = 0; counter < nums.Length-1; counter++)
            //{
            //    for (int index = counter + 1; index > 0; index--)
            //    {
            //        if (nums[index-1] > nums[index])
            //        {
            //            temp = nums[index - 1];
            //            nums[index - 1] = nums[index];
            //            nums[index] = temp;
            //        }
            //    }
            //}

            //SELECTION SORT 
            int minPosition;
            for (int counter = 0; counter < nums.Length-1; counter++)
            {
                minPosition = counter;
                for (int index = counter; index < nums.Length; index++)
                {
                    if (nums[index] < nums[minPosition])
                    {
                        minPosition = index;
                    }
                }
                if (minPosition != counter)
                {
                    temp = nums[counter];
                    nums[counter] = nums[minPosition];
                    nums[minPosition] = temp;
                }
            }

            Console.WriteLine("AFTER Sort: [{0}]", string.Join(", ", nums));
            Console.ReadLine();

        }
    }
}

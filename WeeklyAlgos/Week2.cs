using System;

namespace WeeklyAlgos
{
    public class Week2
    {
        /* EASY ALGO:
        * 
        * Create a function that takes a two digit number 
        * and determine if its the largest 
        * of the two possible combinations of those two digits
        * 
        * Example: 
        * 
        * EasyAlgo(26) -> false
        * 
        * EasyAlgo(61) -> true
        */
        public static bool EasyAlgo(int twoDigitNumber)
        {

            bool isLarger = false;
            int isSmaller = 0;
            int remainder = 0;
            while (twoDigitNumber >= 0)
            {
                 remainder = twoDigitNumber % 10;
                twoDigitNumber = twoDigitNumber / 10;
                isSmaller = (isSmaller * 10) + remainder;

            }

            if (isSmaller !> twoDigitNumber)
            {
                isLarger = true;
            }
            if (twoDigitNumber == isSmaller)
            {
                isLarger = false;
            }
            if (isSmaller <= twoDigitNumber)
            {
                isLarger = true;
            }
           
            return isLarger;

        }

        /* MEDIUM ALGO:
        * 
        * Create a function that takes an array of numbers 
        * and returns the values of the three lowest positive numbers.
        * 
        * Example: MediumAlgo() -> 
        * 
        */
        public static IEnumerable<Double> MediumAlgo(IEnumerable<Double> numsArray)
        {
            IEnumerable<Double> lowestValues = Enumerable.Empty<Double>();

            

            return lowestValues;
        }

        /* HARD ALGO:
        * 
        * You are at the given coordinate of a grid.
        * Given your coordinates and a cartesian coordinate of your destination,
        * return how many moves it will take to arrive, if you can only move 1 integer in any direction at a time.
        * All coordinates will be integers
        * 
        * Example: 
        * 
        * HardAlgo([1,1], [2,-2]) -> 4
        * 
        * Extra Credit: handle when values are larger than the datatype.  
        * I didn't write a unit test so handle however you see fit.
        * Week2.HardAlgo(new int[] { -2147483647, 2147483647 }, new int[] { 48000, -96000 })
        * 
        */
        public static int HardAlgo(int[] origin, int[] destination)
        {
            int moves = 0;

            return moves;
        }

    }
}



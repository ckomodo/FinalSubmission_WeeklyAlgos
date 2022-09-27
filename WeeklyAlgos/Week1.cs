using System;

namespace WeeklyAlgos
{
    public class Week1
    {
        /* EASY ALGO:
        * 
        * Create a function that counts how many R's are in a sentence.
        * It must be case sensitive.
        * 
        * Example: EasyAlgo("There you are") -> 2
        * 
        */
        public static int EasyAlgo(string candidate)
        {

            int count = 0;

            //Add your code here.
            char letterR = 'R';
            char smallLetterR = 'r';


            //organise sentence to individual characters
            //then count the number of occurences of character 'R'

            for (int i = 0; i < candidate.Length; i++)
            {
                char newCandidate = Convert.ToChar(candidate[i]);

                if (newCandidate == letterR || newCandidate == smallLetterR)
                {
                    count++;
                }

            }
            return count;
        }


        /* MEDIUM ALGO:
        * 
        * Create a function that takes a number an argument and 
        * returns a string formatted with commas seperating thousands.
        * 
        * Example: MediumAlgo(2000000) -> "2,000,000"
        * 
        */
        public static string MediumAlgo(int candidate)
        {

            //Add your code here.


            //get number from user then format below

            string number = string.Format("{0:#,###,###}", candidate);

            return number;
        }

        /* HARD ALGO:
        * 
        * Create a function the takes two strings as inputs and 
        * returns the longest common ending.
        * This should be case insensitive.
        * 
        * Example: 
        * 
        * HardAlgo("basketball", "football") -> "tball"
        * 
        * HardAlgo("soccer", "football") -> ""
        * 
        */
        public static string HardAlgo(string stringOne, string stringTwo)
        {
            string commonEnding = "";

            //Add your code here.

            for (int i = 0; i < stringOne.Length; i--)
            {
                for (int j = 0; j < stringTwo.Length; j--)
                {

                    
                    //my idea was to split each string into an array of characters
                    //then make comparison of the characters in the if statement

                    char newString1 = Convert.ToChar(stringOne[i]);
                    char newString2 = Convert.ToChar(stringTwo[j]);
                    if (newString1 == newString2)
                    {
                        //if the characters in both strings match then just pick from one of them

                         commonEnding = commonEnding + newString1;

                    }
                }
            }

            return commonEnding;
        }
    }
}
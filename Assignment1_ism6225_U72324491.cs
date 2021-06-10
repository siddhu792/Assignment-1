using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;



namespace Assignment1_Summer2021

{

    class Program

    {

        static void Main(string[] args)

        {







            //Question 1  - Robot Program

            Console.WriteLine("Q1 : Enter the Moves of Robot:");

            string moves = Console.ReadLine();

            bool pos = JudgeCircle(moves);

            if (pos)

            {

                Console.WriteLine("The Robot return’s to initial Position (0,0)");

            }

            else

            {

                Console.WriteLine("The Robot doesn’t return to the Initial Postion (0,0)");

            }







            Console.WriteLine();







            //Question 2:

            Console.WriteLine(" Q2 : Enter the string to check for pangram:");

            string s = Console.ReadLine();

            bool flag = CheckIfPangram(s);

            if (flag)

            {

                Console.WriteLine("Yes, the given string is a pangram");

            }

            else

            {

                Console.WriteLine("No, the given string is not a pangram");

            }

            Console.WriteLine();







            //Question 3:







            int[] arr = { 1, 2, 3, 1, 1, 3 };

            int gp = NumIdenticalPairs(arr);

            Console.WriteLine("Q3:");

            Console.WriteLine("The number of IdenticalPairs in the array are {0}:", gp);









            //Question 4:

            int[] arr1 = { 3, 1, 4, 1, 5 };

            Console.WriteLine("Q4:");

            int pivot = PivotIndex(arr1);

            if (pivot > 0)

            {

                Console.WriteLine("The Pivot index for the given array is {0}", pivot);

            }

            else

            {

                Console.WriteLine("The given array has no Pivot index");

            }

            Console.WriteLine();







            //Question 5:

            Console.WriteLine("Q5:");

            Console.WriteLine("Enter the First Word:");

            String word1 = Console.ReadLine();

            Console.WriteLine("Enter the Second Word:");

            String word2 = Console.ReadLine();

            String merged = MergeAlternately(word1, word2);

            Console.WriteLine("The Merged Sentence fromed by both words is {0}", merged);









            //Quesiton 6:

            Console.WriteLine("Q6: Enter the sentence to convert:");

            string sentence = Console.ReadLine();

            string goatLatin = ToGoatLatin(sentence);

            Console.WriteLine("Goat Latin for the Given Sentence is {0}", goatLatin);

            Console.WriteLine();







        }







        /*

        <summary>

        /// Input: moves = "UD"

        /// Output: true

        /// Explanation: The robot moves up once, and then down once. All moves have the same ///magnitude, so it ended up at the origin where it started. Therefore, we return true.

        </summary>

        <retunrs>true/False</returns>

        */

        private static bool JudgeCircle(string moves)

        {

            try

            {

                /* <logic>

                /// logic: i have incresed x cordinate increased by + 1 if it is R or decreased by -1 if it is L

                /// i have increased y cordinate increased by +1 if is U or decreased by -1 if it is D

                */







                /* <self refelection>

                /// time complexity O(N) as we loop through moves

                /// space complexity O(1) constant space

                /// i have learnt that this basic code to control the robot, so that it can come back to origin by giving proper instruction

                */







                int x = 0;

                int y = 0;







                foreach (char i in moves)

                {

                    if (i == 'U' || i == 'u')

                    {

                        y = y + 1;

                    }

                    if (i == 'D' || i == 'd')

                    {

                        y = y - 1;

                    }

                    if (i == 'R' || i == 'r')

                    {

                        x = x + 1;

                    }

                    if (i == 'L' || i == 'l')

                    {

                        x = x - 1;

                    }

                }







                if (x == 0 && y == 0)

                {

                    return true;

                }

                else

                {

                    return false;

                }







            }

            catch (Exception)

            {







                throw;

            }







        }







        /*

        <summary>

        A pangram is a sentence where every letter of the English alphabet appears at least once.

        Given a string sentence containing only lowercase English letters, return true if sentence is a pangram, or false otherwise.

        Example 1:

        Input: sentence = "thequickbrownfoxjumpsoverthelazydog"

        Output: true

        Explanation: sentence contains at least one of every letter of the English alphabet.

        </summary>

        </returns> true/false </returns>

        Note: Use of String function (Contains) and hasmap is not allowed, think of other ways how you could the numbers be represented

        */









        private static bool CheckIfPangram(string s)

        {

            try







            /* <logic>

            /// logic:Indexof Reports the zero-based index of the first occurrence of a specified Unicode character or string within this instance. The method returns -1 if the character or string is not found in this instance.

            */







            /* <self refelection>

            /// time complexity O(N2) as we loop once through given string also, we search whether the character is prersent or not by traversing back

            /// space complexity O(1) constant space

            /// we can improve the time complexity by considering the hash_map to O(N) as search time time is O(1)

            /// but space complexity will be increased to O(N), as hash_map will store the characters in it

            /// By doing this question i learnt how to use indexof method in string and i got hands on experience with hash_map

            /// */

            {

                if (s.Length < 26) return false;



                s.ToLower();



                for (var i = 1; i <= 26; i++)

                    if (s.IndexOf((char)(i + 96)) < 0)

                        return false;







                return true;







            }

            catch (Exception)

            {







                throw;

            }







        }









        /*

        <summary>

        Given an array of integers nums

        A pair (i,j) is called good if nums[i] == nums[j] and i < j.

        Return the number of good pairs.

        Example:

        Input: nums = [1,2,3,1,1,3]

        Output: 4

        Explanation: There are 4 good pairs (0,3), (0,4), (3,4), (2,5) 0-indexed.

        return type : int

        </summary>

        <returns>int </returns>

        */







        private static int NumIdenticalPairs(int[] arr)







        /* <logic>

        /// logic: i have used dictionary to store frequency of elements, using frequency of elements and combinations of two i have calucated the count

        */







        /* <self refelection>

        /// time complexity O(N) as we loop once through given array

        /// space complexity O(N) auxillary dictionary was created

        /// By doing this question i got hands on experience with hash_map, i learnt how to store elements in it using key and values

        /// */

        {

            try

            {

                Dictionary<int, int> myDict = new Dictionary<int, int>();

                for (int i = 0; i < arr.Length; i++)

                {

                    if (myDict.ContainsKey(arr[i]))

                    {

                        myDict[arr[i]] += 1;

                    }

                    else

                    {

                        myDict[arr[i]] = 1;

                    }

                }

                int count = 0;

                foreach (KeyValuePair<int, int> kvp in myDict)

                {

                    count += kvp.Value * (kvp.Value - 1) / 2;

                }

                return count;







            }

            catch (Exception)

            {







                throw;

            }

        }

















        /*

        <summary>

        Given an array of integers nums, calculate the pivot index of this array.The pivot index is the index where the sum of all the numbers strictly to the left of the index is equal to the sum of all the numbers strictly to the index's right.

        If the index is on the left edge of the array, then the left sum is 0 because there are no elements to the left. This also applies to the right edge of the array.

        Return the leftmost pivot index. If no such index exists, return -1.

        Example 1:

        Input: nums = [1,7,3,6,5,6]

        Output : 3

        Explanation:

        The pivot index is 3.

        Left sum = nums[0] + nums[1] + nums[2] = 1 + 7 + 3 = 11

        Right sum = nums[4] + nums[5] = 5 + 6 = 11

        /// </summary>

        /// <param name="nums"></param>

        /// <returns>Number the index in the array</returns>

        */

        private static int PivotIndex(int[] nums)







        /* <logic>

        /// logic: i have used dyanmic programming approach, at first i have calucalted the overall sum of the array

        /// in the next i have intilized a constant variable which will calculate the sum from left hand side

        ///i have loop through the array, if leftside sum is eaual to totalsum - leftsum - element, then return the position of element

        ///leftsum is increased by adding current element to it

        /// */







        /* <self refelection>

        /// time complexity O(N) as we loop once through given array

        /// space complexity O(1) constant space was used

        /// By doing this question i got hands on experience with dyanamic programming,

        /// i learnt using the past output how to compare with the future input.

        */

        {

            try

            {

                int sum = 0;

                foreach (int i in nums)

                {

                    sum = sum + i;

                }







                int leftsum = 0;









                for (int j = 0; j < nums.Length; j++)

                {

                    if (leftsum == (sum - leftsum - nums[j]))

                    {

                        return j;

                    }

                    leftsum = leftsum + nums[j];







                }







                return -1;







            }

            catch (Exception e)

            {







                Console.WriteLine("An error occured: " + e.Message);

                throw;

            }







        }







        /*

        /// <summary>

        /// You are given two strings word1 and word2. Merge the strings by adding letters /// in alternating order, starting with word1. If a string is longer than the other,

        /// append the additional letters onto the end of the merged string.

        /// Example 1

        /// Input: word1 = "abc", word2 = "pqr"

        /// Output: "apbqcr"

        /// Explanation: The merged string will be merged as so:

        /// word1: a b c

        /// word2: p q r

        /// merged: a p b q c r

        /// </summary>

        /// <param name="word1"></param>

        ///<param name="word2"></param>

        /// <returns>return the merged string </returns>

        */







        private static string MergeAlternately(string word1, string word2)







        /* <logic>

      /// logic: i have created empty string, while looping through the word 1 and word2, we will append first letter from word1 and next will append next letter from word2

      /// if len(word1)>len(word2), the remaining elements of word1 are append last to the string

      /// */







        /* <self refelection>

        /// time complexity O(N+m) N size of string 1, m size of string 2

        /// space complexity O(N+M) to store the output

        /// By doing this question i learnt, how to loop the string using while loop, also i learnt how to use if statements

        /// the similiar approach can be used to merge two sorted linked list

        */

        {

            try

            {

                string s = "";

                int i = 0;

                int j = 0;

                while (i < word1.Length || j < word2.Length)

                {

                    if (i < word1.Length)

                    {

                        s = s + word1[i];

                        i = i + 1;

                    }

                    if (j < word2.Length)

                    {

                        s = s + word2[j];

                        j = j + 1;

                    }

                }







                return s;

            }

            catch (Exception e)

            {

                Console.WriteLine(e.Message);

                throw;

            }







        }







        /*

        <summary>

        /// A sentence sentence is given, composed of words separated by spaces. Each word consists of lowercase and uppercase letters only.

        We would like to convert the sentence to "Goat Latin" (a made-up language similar to Pig Latin.)

        The rules of Goat Latin are as follows:

        1) If a word begins with a vowel (a, e, i, o, or u), append "ma" to the end of the word.

        For example, the word 'apple' becomes 'applema'.

        2) If a word begins with a consonant (i.e. not a vowel), remove the first letter and append it to the end, then add "ma".

        For example, the word "goat" becomes "oatgma".

        3) Add one letter 'a' to the end of each word per its word index in the sentence, starting with 1.

        For example, the first word gets "a" added to the end, the second word gets "aa" added to the end and so on.

        Hint : think of a string function to divide the sentence on white spaces

        /// </summary>

        /// <param name="sentence"></param>

        /// <returns> string</returns>

        */

        private static string ToGoatLatin(string sentence)

        {/*

/// at first split the sentence using split function

/// check whether firstcharatcer of split array is vowel or not if its is vowel append "ma" to the end of the word

/// plus letter a to be append based on index at last to the word, if index is 2 aa to be appended at last to the word

/// if first character is not vowel word position from ( 1 to end)+first character of the word append "ma" to the end of the word plus letter a to be append based on index at last to the word, if index is 2 aa to be appended at last to the word

/// */







            /* <self refelection>

            /// time complexity O(N)

            /// space complexity O(N)

            /// By doing this question i learnt, how to loop the string using foreach loop, also i learnt inbuilts function like string builder and split, concat,substring etc

            */







            try







            {

                StringBuilder sb = new StringBuilder();

                string[] arr = sentence.Split(" ");

                int index = 1;







                foreach (string str in arr)

                {

                    if ("aeiou".Contains(char.ToLower(str[0])))

                        sb.Append(str + "ma" + string.Concat(Enumerable.Repeat("a", index)).ToString() + " ");

                    else if (!str.Contains("aeiouAEIOU"))

                        sb.Append(str.Substring(1, str.Length - 1) + str.Substring(0, 1) + "ma" + string.Concat(Enumerable.Repeat("a", index)) + " ");

                    index++;

                }

                //removes last space

                sb.Length--;

                return sb.ToString();







            }

            catch (Exception)

            {







                throw;

            }
        }










    }
}












using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Question 1");
            Console.WriteLine("Enter the value for n");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the values of your array, separated by comma");
            var inputQ1 = Console.ReadLine();
            var originalArrayQ1 = inputQ1.Split(',');
            //Create the array for the method to call, based on the user's input
            int[] ar1 = new int[2 * n1];
            for (int i = 0; i < ar1.Length; i++)
            {
                ar1[i] = int.Parse(originalArrayQ1[i]);
            }

            ShuffleArray(ar1, n1);
            Console.WriteLine();

            //Question 2 
            Console.WriteLine("Question 2");
            Console.WriteLine("Enter the values of your array, separated by comma");
            var inputQ2 = Console.ReadLine();
            var originalArrayQ2 = inputQ2.Split(',');
            //Create the array for the method to call, based on the user's input
            int[] ar2 = new int[originalArrayQ2.Length];
            for (int i = 0; i < originalArrayQ2.Length; i++)
            {
                ar2[i] = int.Parse(originalArrayQ2[i]);
            }
            MoveZeroes(ar2);
            Console.WriteLine();

            //Question3
            Console.WriteLine("Question 3");
            Console.WriteLine("Enter the values of your array, separated by comma");
            var inputQ3 = Console.ReadLine();
            var originalArrayQ3 = inputQ3.Split(',');
            //Create the array for the method to call, based on the user's input
            int[] ar3 = new int[originalArrayQ3.Length];
            for (int i = 0; i < originalArrayQ3.Length; i++)
            {
                ar3[i] = int.Parse(originalArrayQ3[i]);
            }
            CoolPairs(ar3);
            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            Console.WriteLine("Enter the values of your array, separated by comma");
            var inputQ4 = Console.ReadLine();
            var originalArrayQ4 = inputQ4.Split(',');
            //Create the array for the method to call, based on the user's input
            int[] ar4 = new int[originalArrayQ4.Length];
            for (int i = 0; i < originalArrayQ4.Length; i++)
            {
                ar4[i] = int.Parse(originalArrayQ4[i]);
            }
            Console.WriteLine("Enter the target number");
            int target = Convert.ToInt32(Console.ReadLine());
            TwoSum(ar4, target);
            Console.WriteLine();

            //Question 5
            Console.WriteLine("Question 5");
            Console.WriteLine("Enter the string");
            string s5 = Console.ReadLine();
            Console.WriteLine("Enter the order of the indices, separated by comma");
            var inputQ5 = Console.ReadLine();
            var originalArrayQ5 = inputQ5.Split(',');
            //Create the array for the method to call, based on the user's input
            int[] indices = new int[originalArrayQ5.Length];
            for (int i = 0; i < originalArrayQ5.Length; i++)
            {
                indices[i] = int.Parse(originalArrayQ5[i]);
            }
            RestoreString(s5, indices);
            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            Console.WriteLine("Enter the first string");
            string s61 = Console.ReadLine();
            Console.WriteLine("Enter the second string");
            string s62 = Console.ReadLine();
            //Call the method, but only if the strings are of equal length
            if (s61.Length == s62.Length)
            {
                if (Isomorphic(s61, s62))
                {
                    Console.WriteLine("Yes the two strings are Isomorphic");
                }
                else
                {
                    Console.WriteLine("No, the given strings are not Isomorphic");
                }
            }
            else
            {
                Console.WriteLine("Ensure that the strings are of equal length.");
            }
            Console.WriteLine();

            //Question 7
            Console.WriteLine("Question 7");
            Console.WriteLine("Enter the total number of items that you have");
            int itemLength = Convert.ToInt32(Console.ReadLine());
            //This is a lengthy way to create a user-input 2D array but I don't know any shorter way.
            int[,] scores = new int[itemLength, 2];
            Console.WriteLine("Enter each ID/Score pair (ex. \"1,91\")");
            for (int i = 0; i < itemLength; i++)
            {
                string inputQ7 = Console.ReadLine();
                var originalArrayQ7 = inputQ7.Split(',');
                int[] newArrayQ7 = new int[2];
                for (int j = 0; j < 2; j++)
                {
                    newArrayQ7[j] = int.Parse(originalArrayQ7[j]);
                }
                scores[i, 0] = newArrayQ7[0];
                scores[i, 1] = newArrayQ7[1];
            }

            HighFive(scores);
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            Console.WriteLine("Enter a value to see if it's a happy number");
            int n8 = Convert.ToInt32(Console.ReadLine());
            if (HappyNumber(n8))
            {
                Console.WriteLine("{0} is a happy number", n8);
            }
            else
            {
                Console.WriteLine("{0} is not a happy number", n8);
            }
            Console.WriteLine();

        }

        private static void ShuffleArray(int[] nums, int n)
        {
            try
            {
                //Creates two separate arrays: one for our x values and one for y values
                //x values come from the first half of the array (length n) and y values from the second half
                int[] xArray = new int[n];
                for (int i = 0; i < n; i++)
                {
                    xArray[i] = nums[i];
                }
                int[] yArray = new int[n];
                for (int i = 0; i < n; i++)
                {
                    yArray[i] = nums[i + n];
                }
                //Creates the final array
                int[] outputArray = new int[2 * n];

                //Assigns the values to the final array
                //If the index is even (ex: 0, 2, 4) then it will take a number from our array of X's
                //If the index is odd (ex: 1, 3, 5) then it will take a number from our array of Y's
                //This will cause the values in the final array to alternate between X's and Y's
                for (int i = 0; i < outputArray.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        outputArray[i] = xArray[i / 2];
                    }
                    else
                    {
                        outputArray[i] = yArray[i / 2];
                    }

                }
                
                Console.WriteLine();
                Console.WriteLine("The final array output is: ");
                for (int i = 0; i < outputArray.Length; i++)
                {
                    Console.Write(outputArray[i] + "  ");
                }
                Console.WriteLine();


            }
            catch (Exception)
            {
                Console.WriteLine("There was an error.");
                //throw;
            }
        }
        private static void MoveZeroes(int[] ar2)
        {
            try
            {
                //This formulates the number of zeroes in the array, which will be needed later.
                int noOfZeroes = 0;
                foreach (int item in ar2)
                {
                    if (item == 0)
                    {
                        noOfZeroes++;
                    }
                }

                for (int i = 0; i < ar2.Length; i++)
                {
                    if (ar2[i] == 0)
                    {
                        //This for-loop shifts each element to the left at the occurence of a zero (in the else statement). 
                        //If it's the last element in the array, it makes sure it's a zero (in the if statement).
                        //It's very important that the nested for-loop starts at i and not back at zero--the shifting only occurs after zeros.
                        for (int j = i; j < ar2.Length; j++)
                        {
                            if (j == (ar2.Length - 1))
                            {
                                ar2[j] = 0;
                            }
                            else
                            {
                                ar2[j] = ar2[j + 1];
                            }

                        }
                        //I need this block of code or else it gets confused by back-to-back/consecutive zeroes.
                        //Without this code, a consecutive zero would be skipped over.
                        //If the element in the updated array is equal to zero (and is NOT one of the zeroes moved to the end of the array),... 
                        //...the for-loop starts again at that zero instead of skipping over it.
                        if ((ar2[i] == 0) && (i < (ar2.Length - noOfZeroes)))
                        {

                            i--;
                        }

                    }
                }
                //Print the array
                Console.WriteLine("The final array output is: ");
                for (int i = 0; i < ar2.Length; i++)
                {
                    Console.Write(ar2[i] + "  ");
                }
                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine("There was an error.");
                //throw;
            }
        }
        private static void CoolPairs(int[] nums)
        {
            try
            {
                //Create our dictionary based off our array argument
                Dictionary<int, int> numsDictionary = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    numsDictionary.Add(i, nums[i]);
                }

                //Print the dictionary to check that it worked
                //I simply used this code during this problem to ensure that I correctly created a dictionary
                //I found it from Professor Clinton's lecture on Canvas

                //int[] keysArray = numsDictionary.Keys.ToArray<int>();
                //for (int i = 0; i < keysArray.Length; i++)
                //{
                //    Console.WriteLine(numsDictionary[keysArray[i]]);
                //}

                //For-loops to search through the dictionary values
                //When I created the dictionary, the values' keys were its position in the array...
                //..Therefore, this nested for-loop can behave like previously created for-loops when searching through arrays
                int coolCount = 0;

                for (int i = 0; i < numsDictionary.Values.Count; i++)
                {
                    //"j + 1" ensures that we only look at pairs where i < j
                    for (int j = i + 1; j < numsDictionary.Values.Count; j++)
                    {
                        if (numsDictionary[i] == numsDictionary[j])
                        {
                            coolCount++;
                        }
                    }
                }
                Console.WriteLine("The number of cool pairs is: " + coolCount);
            }
            catch (Exception)
            {
                Console.WriteLine("There was an error.");
                //throw;
            }
        }
        private static void TwoSum(int[] nums, int target)
        {
            try
            {
                //Create our dictionary based off our array argument
                Dictionary<int, int> twoSumDictionary = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    twoSumDictionary.Add(i, nums[i]);
                }

                //The nested for-loops compare every pair of values in the dictionary and sees if they equal the target
                for (int i = 0; i < twoSumDictionary.Values.Count; i++)
                {
                    //Starting the loop at i + 1 ensures that we dont use the same element twice
                    for (int j = i + 1; j < twoSumDictionary.Values.Count; j++)
                    {
                        if (twoSumDictionary[i] + twoSumDictionary[j] == target)
                        {
                            Console.WriteLine("The solution elements are " + i + " and " + j);
                        }
                    }
                }


            }
            catch (Exception)
            {
                Console.WriteLine("There was an error.");
                //throw;
            }

        }
        private static void RestoreString(string s, int[] indices)
        {
            try
            {
                //Create an array containing each character in the string argument.
                char[] charArray = s.ToCharArray();

                //Create an updated array that will hold the shuffled string.
                char[] updatedLetters = new char[charArray.Length];
                //Initializing variables for later use.
                int newPosition = 0;
                char newLetter = 'x';

                //This for-loop swaps the letters based off indices array.
                for (int i = 0; i < updatedLetters.Length; i++)
                {
                    newPosition = indices[i];
                    newLetter = charArray[i];
                    updatedLetters[newPosition] = newLetter;
                }

                //Print the new arrangement of letters
                Console.WriteLine("The answer is: ");
                foreach (char letter in updatedLetters)
                {
                    Console.Write(letter);
                }
                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine("There was an error.");
                //throw;
            }
        }
        private static bool Isomorphic(string s1, string s2)
        {
            //Create a 2D array
            char[,] letters2D = new char[s1.Length, 2];

            //Separate our strings out into character arrays
            char[] charArray1 = s1.ToCharArray();
            char[] charArray2 = s2.ToCharArray();

            //Populate our 2D array
            for (int i = 0; i < charArray1.Length; i++)
            {
                letters2D[i, 0] = charArray1[i];
            }
            for (int j = 0; j < charArray2.Length; j++)
            {
                letters2D[j, 1] = charArray2[j];
            }

            Console.WriteLine();

            //Create our bool variable. This will be used in our return.
            //If there are no repeated values in the strings (ex: "abcd" and "efgh")...
            //...then we know the strings are isomorphic, so it'll default to true.
            bool check = true;

            //Examine repeats in the first string (first column of 2D array).
            //If there is a repeated pair, it checks to see if there is a repeated pair in the same indices for the other column.
            for (int i = 0; i < letters2D.GetLength(0); i++)
            {
                for (int j = i + 1; j < letters2D.GetLength(0); j++)
                {
                    if (letters2D[i, 0] == letters2D[j, 0])
                    {
                        if (letters2D[i, 1] == letters2D[j, 1])
                        {
                            check = true;
                        }
                        else
                        {
                            check = false;
                        }
                    }
                }
            }

            //Examine repeats in the second string (second column of 2D array).
            //These are the same steps before, but this time it focuses on repeats in the second column and comparing it to the first column.
            for (int i = 0; i < letters2D.GetLength(0); i++)
            {
                for (int j = i + 1; j < letters2D.GetLength(0); j++)
                {
                    if (letters2D[i, 1] == letters2D[j, 1])
                    {
                        if (letters2D[i, 0] == letters2D[j, 0])
                        {
                            check = true;
                        }
                        else
                        {
                            check = false;
                        }
                    }

                }
            }

            if (check == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static void HighFive(int[,] items)
        {
            try
            {
                //Start off with creating our dictionary that will be used later.
                Dictionary<int, int[]> highFiveDict = new Dictionary<int, int[]>();

                //Create an array of the first column, IDs.
                int noOfScores = items.GetLength(0);
                int[] idArray = new int[noOfScores];
                for (int i = 0; i < noOfScores; i++)
                {
                    idArray[i] = items[i, 0];
                }
                //Find the unique values of the IDs array. These will be the keys in our dictionary.
                int[] keysArray = idArray.Distinct().ToArray();

                //This section of code adds the keys and values to our dictionary.
                foreach (int ID in keysArray)
                {
                    //The first loop determines what size the value array should be.
                    //It does this by searching for the number of times that ID appears.
                    int count = 0;
                    for (int i = 0; i < noOfScores; i++)
                    {
                        if (items[i, 0] == ID)
                        {
                            count++;
                        }
                    }
                    //Value array is created:
                    int[] valuesArray = new int[count];

                    //The second loop fills in the value array.
                    int j = 0;
                    for (int i = 0; i < noOfScores; i++)
                    {
                        if (items[i, 0] == ID)
                        {

                            valuesArray[j] = items[i, 1];
                            j++;
                        }
                    }
                    //Now that we have an array containing every value, we can create a new one containing the top 5 scores.
                    int[] finalValuesArray = new int[5];
                    //I will use a selection sort to sort the valuesArray. I will then select the first 5 elements.
                    //int min_position;
                    //int temp;
                    //for (int i = 0; i < valuesArray.Length; i++)
                    //{
                    //    min_position = i;
                    //    for (int x = i + 1; x < valuesArray.Length; x++)
                    //    {
                    //        if (valuesArray[x] < valuesArray[min_position])
                    //        {
                    //            min_position = x;
                    //        }
                    //    }
                    //    if (min_position != i)
                    //    {
                    //        temp = valuesArray[i];
                    //        valuesArray[i] = valuesArray[min_position];
                    //        valuesArray[min_position] = temp;
                    //    }
                    //}

                    //Edit: I now realize I can sort the array much more easily :)
                    Array.Sort(valuesArray);
                    //Add the top 5 values to the final array.
                    for (int i = 0; i < 5; i++)
                    {
                        finalValuesArray[i] = valuesArray[valuesArray.Length - 1 - i];
                    }


                    //Add to our dictionary. The key is the ID and the value is an array of their scores.
                    highFiveDict.Add(ID, finalValuesArray);

                }

                //Test to see that my dictionary was created properly (found on Stackoverflow).
                //Console.WriteLine(string.Join(",",highFiveDict[1]));

                //For each KeyValuePair in the dictionary, we will calculate the average and print.
                foreach (KeyValuePair<int, int[]> entry in highFiveDict)
                {
                    int sum = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        sum += entry.Value[i];
                    }
                    int average = sum / 5;

                    Console.WriteLine();
                    Console.Write("[" + entry.Key + ", " + average + "]  ");
                }
                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine("There was an error.");
                //throw;
            }
        }
        private static bool HappyNumber(int n)
        {
            int iterations = 0;
            int sum = 0;
            int newNumber = n;

            //The while-loop goes up to 9999. This is to avoid the endless loop. 
            //I assume that if it isn't happy through 9999 iterations, then it'll never be happy.
            while (iterations < 9999)
            {
                sum = 0;
                //These next two lines convert our number into a string, then into a array of characters.
                //I know this isn't best practice--I need to use each digit as an integer for part of calculations.
                //However, I had a tough time finding alternative ways to loop through a number's digits.
                //Character arrays are something I knew would work while I couldn't find a better solution.
                string nString = "" + newNumber;
                char[] nCharArray = nString.ToCharArray();
                for (int i = 0; i < nCharArray.Length; i++)
                {
                    //This short line of code was found on Stackoverflow to find a way to convert a char to int.
                    //It looks at the internal number represented by the char number and subtracts it by zero to create the integer.
                    int digit = nCharArray[i] - '0';
                    sum += (digit * digit);
                }
                //The for-loop adds the squares for each digit. The while-loop breaks if this new number = 1 to be happy.
                //If it isn't 1, the while-loop repeats, with a new number to loop through in the for-loop.
                newNumber = sum;

                if (newNumber == 1)
                {
                    break;
                }
                else
                {
                    iterations++;
                }

            }

            //Code to return boolean value.
            bool isHappy;
            if (newNumber == 1)
            {
                isHappy = true;
            }
            else
            {
                isHappy = false;
            }

            if (isHappy == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}


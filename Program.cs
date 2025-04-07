using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);


            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);


            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);

        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                // Write your code here
                HashSet<int> numSet = new HashSet<int>(nums); // Create a HashSet to store unique numbers
                List<int> missingNumbers = new List<int>(); // List to store missing numbers 
                for (int i = 1; i <= nums.Length; i++) // Iterate from 1 to length of array
                {
                    if (!numSet.Contains(i)) // Check if the number is missing
                    {
                        missingNumbers.Add(i); // Add the missing number to the list
                    }
                }
                return missingNumbers; // Return the list of missing numbers
            }
            catch (Exception) // If an exception occurs, throw it
            {
                throw;
            }
        }

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                // Write your code here
                int left = 0, right = nums.Length - 1; // Initialize left and right pointers where left is 0 and right is the last index of the array
                while(left<right) // 
                {
                    if (nums[left] % 2 != 0 && nums[right] % 2 == 0) // Check if number at the left pointer is odd and right is even
                    { 
                        int temp = nums[left]; // Swap the odd number at left pointer with the even number at right pointer
                        nums[left] = nums[right]; // Assign the even number to the left pointer
                        nums[right] = temp; // Assign the odd number to the right pointer
                    }
                    if (nums[left] % 2 == 0) // If the number at left pointer is even, move the left pointer to the right
                    {
                        left++;
                    }
                    if (nums[right] % 2 ==1 ) // If the number at right pointer is odd, move the right pointer to the left
                    {
                        right--;
                    }
                }
                return nums; // Return the sorted array
            }
            catch (Exception) // If an exception occurs, throw it
            {
                throw;
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                // Write your code here
                Dictionary<int, int> numbers = new Dictionary<int, int>(); // Create a dictionary to store numbers and their indices
                for (int i = 0; i < nums.Length; i++) //Iterate through the array
                {
                    int secondNum = target - nums[i]; // Potential second number
                    if (numbers.ContainsKey(secondNum)) //Check if the second numbers exists in the dictionary
                    {
                        return new int[] { numbers[secondNum], i }; // If it exists, return the indices of the two numbers
                    }
                    else
                    {
                        numbers.Add(nums[i], i); // If it doesn't exist, add the number and its index to the dictionary
                    }
                }
                return new int[0]; // Return an empty array if no solution is found
            }
            catch (Exception) // If an exception occurs, throw it
            {
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                // Write your code here
                Array.Sort(nums); // Sort the array
                int n = nums.Length; // Get the length of the array
                int product1 = nums[n - 1] * nums[n - 2] * nums[n - 3]; // Three largest
                int product2 = nums[0] * nums[1] * nums[n - 1];         // Two smallest (negatives) and the largest

                return Math.Max(product1, product2); // Return the bigger one
            }
            catch (Exception) // If an exception occurs, throw it
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                // Write your code here
                string binary = Convert.ToString(decimalNumber, 2); // Convert decimal to binary
                return binary; // Return the binary string
            }
            catch (Exception) // If an exception occurs, throw it
            {
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            {
                // Write your code here 
                int left = 0, right = nums.Length - 1; // Initialize left and right pointers where left is 0 and right is the last index of the array
                while (left < right) // While left pointer is less than right pointer
                {
                    int mid = left + (right - left) / 2; // Calculate the middle index by taking the average of left and right pointers
                    if (nums[mid] > nums[right]) // If middle element is greater than rightmost element
                    {
                        left = mid + 1; // Move left pointer to mid + 1
                    }
                    else
                    {
                        right = mid; // Move right pointer to mid
                    }
                }
                return nums[left]; // Return the minimum element
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {
                // Write your code here
                string str = x.ToString(); // Convert the integer to a string
                string reverStr = new string(str.Reverse().ToArray()); // Reverse the string
                if (str == reverStr) // Check if the original string is equal to the reversed string
                {
                    return true; // If they are equal, it is a palindrome
                }
                return false; // If they are not equal, it is not a palindrome
            }
            catch (Exception) // If an exception occurs, throw it
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                // Write your code here
                if (n <= 1) // Base case: if n is 0 or 1, return n
                {
                    return n; // Return n as the Fibonacci number
                }
                int a = 0, b = 1; // Initialize the first two Fibonacci numbers
                for (int i = 2; i <= n; i++) // Iterate from 2 to n
                {
                    int temp = b; // Store the current Fibonacci number
                    b = a + b; // Calculate the next Fibonacci number
                    a = temp; // Update a to the previous Fibonacci number
                }
                return b; // Return the nth Fibonacci number
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}

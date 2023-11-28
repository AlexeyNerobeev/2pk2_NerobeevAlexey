namespace PZ_12
{
    internal class Program
    {
            static int[] CalculateDigitSums(int[] nums)
            {
                int[] results = new int[nums.Length];

                for (int i = 0; i < nums.Length; i++)
                {
                    int sum = 0;
                    foreach (char c in nums[i].ToString())
                    {
                        int digit = c - '0';
                        sum += digit;
                    }

                    results[i] = sum;
                }

                return results;
            }

            static void Main()
            {
                int[] nums = { 458, 657, 547, 215, 546 };
                int[] results = CalculateDigitSums(nums);

                for (int i = 0; i < results.Length; i++)
                {
                    Console.WriteLine(results[i]);
                }
            }
    }
}


namespace Homeworks_Const_Readonly_Access_Modifiers
{
    internal class CustomMath
    {
        public int GetSumOFArrayItems(int[]nums) => nums.Where(m=>m%2==1).Sum();
        //{
            //return nums.Where(m=>m%2==1).Sum();
        //}

        public string CheckNumberByEvenOdd(int number) => number % 2 == 0 ? "Even" : "Odd";
        //{
        //    return number % 2 == 0 ? "Even" : "Odd";
        //}

        public double SquareOfEvenNumbers(int[] nums)=> Math.Pow(nums.Where(m => m % 2 == 0).Sum(), 2);
        //{
        //    return Math.Pow(nums.Where(m => m % 2 == 0).Sum(), 2);
        //}

        public int MultipleOfNumbers(int n)
        {
            int multiple = 1;
            for (int i = 1; i <= n; i++)
            {
                multiple *= i;
            }
            return multiple;
        }








    }


}

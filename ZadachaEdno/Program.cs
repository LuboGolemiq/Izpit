namespace ZadachaEdno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int broi = 0;
            int broqch = 0;
            for (int i = 0; i < nums.Length; i++)
            {

             for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        broi++;
                        nums[i] += broqch;
                        
                    }
                }
            }
            Console.WriteLine(string.Join(",",broqch,broi));
        }
    }
}

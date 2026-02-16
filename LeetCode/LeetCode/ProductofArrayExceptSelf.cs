namespace LeetCode
{
    public class ProductofArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] leftMulti = new int[nums.Length];
            int[] rightMulti = new int[nums.Length];
            leftMulti[0] = nums[0];
            rightMulti[nums.Length - 1] = nums[nums.Length - 1];
            for (int i = 1; i < nums.Length; ++i)
            {
                leftMulti[i] = nums[i] * leftMulti[i - 1];
                rightMulti[nums.Length - i - 1] = nums[nums.Length - i - 1] * rightMulti[nums.Length - i];
            }
            var result = new int[nums.Length];
            for (int i = 0; i < nums.Length; ++i)
            {
                result[i] = (i > 0 ? leftMulti[i - 1] : 1) * (i < nums.Length - 1 ? rightMulti[i + 1] : 1);
            }
            return result;
        }
    }
}

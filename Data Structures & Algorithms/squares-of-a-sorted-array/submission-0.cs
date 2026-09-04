public class Solution {
    public int[] SortedSquares(int[] nums) {
        int i = 0;
        int j = nums.Length - 1;
        int k = nums.Length - 1;

        int[] res = new int[nums.Length];

        while(i <= j)
        {
            if(Math.Abs(nums[i]) > Math.Abs(nums[j]))
            {
                res[k] = nums[i] * nums[i];
                i++;
            }
            else 
            {
                res[k] = nums[j] * nums[j];
                j--;
            }
            k--;
        }
        return res;
    }
}
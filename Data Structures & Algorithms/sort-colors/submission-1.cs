public class Solution {
    public void SortColors(int[] nums) {
        int i = 0,
            j = nums.Length - 1,
            k = 0;
        
        while(k <= j)
        {
            if(nums[k] == 1)
            {
                k++;
            }
            else if(nums[k] == 2)
            {
                int temp = nums[j];
                nums[j] = nums[k];
                nums[k] = temp;

                j--;                
            }
            else{
                int temp = nums[i];
                nums[i] = nums[k];
                nums[k] = temp;

                i++;
                k++;
            }
        }
    }
}
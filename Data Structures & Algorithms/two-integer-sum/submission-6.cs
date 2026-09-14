public class Solution {
    public int[] TwoSum(int[] nums, int target) {
       Dictionary<int, int> map = new Dictionary<int, int>();
        
       for(int i = 0; i < nums.Length; i++)
       {
        int lookingFor = target - nums[i];
        if(map.TryGetValue(lookingFor, out int val))
        {
            return new int[] {
                val,
                i
            };
        }

       map[nums[i]] = i;
       }
       return new int[] { -1, -1};
    }
}
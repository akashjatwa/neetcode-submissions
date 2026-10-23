class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        setNums = set(nums)
        return len(nums) != len(setNums)

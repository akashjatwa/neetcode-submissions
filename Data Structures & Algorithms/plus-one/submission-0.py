class Solution:
    def plusOne(self, digits: List[int]) -> List[int]:
        nums = 0
        for d in digits:
            nums = nums * 10 + d

        nums += 1
        digits = [int(c) for c in str(nums)]

        return digits
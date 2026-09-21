class Solution:
    def twoSumHelper(self, f: int, nums: List[int], res : list[list[int]]):
        i = f + 1
        j = len(nums) - 1

        while(i < j):
            sum = nums[f] + nums[i] + nums[j]    

            if(sum > 0):
                j -= 1
            elif(sum < 0):
                i += 1
            else:
                res.append([nums[f],nums[i],nums[j]])
                i += 1
                j -= 1

                while(i < j and nums[i] == nums[i - 1]):
                    i += 1
                
                while(i < j and nums[j] == nums[j + 1]):
                    j -= 1


    def threeSum(self, nums: List[int]) -> List[List[int]]:
        nums.sort()
        res = []

        for f in range(len(nums)):
            if(nums[f] > 0):
                break

            if(f == 0 or nums[f] != nums[f - 1]):
                self.twoSumHelper(f, nums, res)

        return res

class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        count = {}
        if len(s) != len(t):
            return False

        for w in s:
            if w not in count:
                count[w] = 0 
            count[w] += 1

        for w in t:
            if w not in count or count[w] == 0:
                return False
            count[w] -= 1

        return True

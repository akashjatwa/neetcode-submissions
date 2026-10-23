class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        count = {}
        if len(s) != len(t):
            return False

        for w in s:
            if w not in count:
                count[w] = 0 
            count[w] += 1

        for t1 in t:
            if t1 not in count or count[t1] == 0:
                return False
            count[t1] -= 1

        return True

public class Solution {
    public bool IsPalindrome(string s) {
        if(String.IsNullOrEmpty(s))
            return true;

        int i = 0,
            j = s.Length - 1;

        while(i < j)
        {
            char left = s[i];
            char right = s[j];

            if(!Char.IsLetterOrDigit(left))
            {
                i++;
                continue;
            }
            else if(!Char.IsLetterOrDigit(right))
            {
                j--;
                continue;
            }
            else
            {
                if(Char.ToLower(left) != Char.ToLower(right))
                {
                    return false;
                }
                i++;
                j--;
            }
        }
        return true;
    }
}

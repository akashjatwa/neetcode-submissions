public class Solution {
    public bool ValidWordAbbreviation(string word, string abbr) {
        int i = 0;
        int j = 0;
        while(i < word.Length && j < abbr.Length)
        {
            char wc = word[i];
            char ac = abbr[j];

            if(Char.IsDigit(ac))
            {
                if(ac == '0')
                {
                    return false;
                }

                int curr = 0;

                while(j < abbr.Length && Char.IsDigit(abbr[j]))
                {
                    curr = curr * 10 + (abbr[j] - '0');
                    j++;
                }    
                i = i + curr;
            }
            else 
            {
                if(wc != ac)
                {
                    return false;
                }
                i++;
                j++;
            }
        }
        return i == word.Length && j == abbr.Length;
    }
}
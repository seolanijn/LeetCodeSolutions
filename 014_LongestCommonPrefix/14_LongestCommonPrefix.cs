public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> romanNumeralOne = new Dictionary<char, int>()
            {
                {'I',1 },
                {'V',5 },
                {'X',10 },
                {'L',50 },
                {'C',100 },
                {'D',500 },
                {'M',1000 }
            };

        Dictionary<string, int> romanNumeralTwo = new Dictionary<string, int>()
            {
                { "IV", 4},
                { "IX", 9},
                { "XL", 40},
                { "XC", 90},
                { "CD", 400},
                { "CM", 900}
            };
        int result = 0;

        for (int i = 0; i < romanNumeralTwo.Count; i++)
        {
            string replacedS = s.Replace(romanNumeralTwo.ElementAt(i).Key, "");
            if (replacedS != s)
            {
                result += romanNumeralTwo.ElementAt(i).Value;
                s = replacedS;
            }
        }

        foreach (char c in s)
        {
            result += romanNumeralOne[c];
        }
        return result;
    }
}
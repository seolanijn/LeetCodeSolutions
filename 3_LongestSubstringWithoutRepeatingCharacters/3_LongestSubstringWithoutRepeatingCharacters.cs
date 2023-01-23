public int LengthOfLongestSubstring(string s)
{
    Dictionary<char, int> presentList = new Dictionary<char, int>();

    string subStr = "";
    string result = "";

    for (int i = 0; i < s.Length; i++)
    {
        if (!presentList.ContainsKey(s[i]))
        {
            subStr += s[i];
            presentList.Add(s[i], i);
        }
        else
        {
            if (result.Length < subStr.Length)
            {
                result = subStr;
            }
            subStr = "";
            i = presentList[s[i]];
            presentList.Clear();
        }
    }

    return result.Length < subStr.Length ? subStr.Length : result.Length;
}
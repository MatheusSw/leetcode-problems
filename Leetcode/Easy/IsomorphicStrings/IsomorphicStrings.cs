namespace Leetcode.Easy.IsomorphicStrings;

public static class IsomorphicStrings
{
    public static bool IsIsomorphic(string s, string t)
    {
        var dictionary = new Dictionary<char, char>();
        var final = s.ToCharArray();

        for (var i = 0; i < s.Length; i++)
        {
            if (dictionary.ContainsKey(s[i]))
            {
                final[i] = dictionary[s[i]];
                continue;
            }

            if (dictionary.ContainsValue(t[i]))
            {
                return false;
            }

            final[i] = dictionary[s[i]] = t[i];
        }

        return new string(final) == t;
    }
}
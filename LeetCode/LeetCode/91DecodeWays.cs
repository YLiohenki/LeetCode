public class DecodeWays
{
    public int NumDecodings(string s)
    {
        if (s.Length == 0 || s == "0" || s[0] == '0')
            return 0;
        var ways = new int[s.Length];
        ways[0] = 1;
        var supportedWith2 = new int[] { '1', '2', '3', '4', '5', '6' };
        for (int i = 1; i < s.Length; ++i)
        {
            if (s[i] == '0' && s[i - 1] == '0')
                return 0;
            else if (s[i - 1] == '1' && s[i] != '0')
            {
                ways[i] = ways[i - 1] + ways[Math.Max(i - 2, 0)];
            }
            else if (supportedWith2.Contains(s[i]) && s[i - 1] == '2')
            {
                ways[i] = ways[i - 1] + ways[Math.Max(i - 2, 0)];
            }
            else if (s[i] == '0')
            {
                if (s[i - 1] > '2')
                    return 0;
                ways[i] = ways[Math.Max(i - 2, 0)];
            }
            else {
                ways[i] = ways[i - 1];
            }
        }
        return ways[s.Length - 1];
    }
}
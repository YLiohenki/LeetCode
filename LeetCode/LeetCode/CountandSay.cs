public class CountAndSayClass
{
    public string CountAndSay(int n)
    {
        if (n == 1)
            return "1";
        var prev = this.CountAndSay(n - 1);
        var result = "";
        var count = 1;
        var ch = prev[0];
        for (int i = 1; i < prev.Length; ++i)
        {
            if (prev[i] == ch)
            {
                count++;
            }
            else
            {
                result += count.ToString() + ch;
                ch = prev[i];
                count = 1;
            }
        }

        result += count.ToString() + ch;
        return result;
    }
}

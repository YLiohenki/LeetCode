namespace LeetCode
{
    public class Solution7
    {
        public int Reverse(int x)
        {
            var l = long.Parse(new string(Math.Abs((long)x).ToString().Reverse().ToArray()));
            if (x >= 0 && l > int.MaxValue)
                return 0;
            if (x < 0 && -l < int.MinValue)
                return 0;
            return (int)(x < 0 ? -l : l);
        }
    }
}

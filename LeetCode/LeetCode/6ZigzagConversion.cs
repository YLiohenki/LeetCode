using System.Text;

namespace LeetCode
{
    public class Solution6
    {
        public string Convert(string s, int numRows)
        {
            int patLength = numRows + Math.Max(0, numRows - 2);
            var result = new StringBuilder();
            for (int rowNum = 0; rowNum < numRows; ++rowNum)
            {
                int index = 0;
                while (index < s.Length)
                {
                    if (index + rowNum < s.Length)
                    {
                        result.Append(s[index + rowNum]);
                    }
                    if (rowNum > 0 && rowNum < numRows - 1)
                    {
                        var toAddIndex = index + (numRows - 1) + (numRows - 2) - (rowNum - 1);
                        if (toAddIndex < s.Length)
                        {
                            result.Append(s[toAddIndex]);
                        }
                    }
                    index += patLength;
                }
            }

            return result.ToString();
        }
    }
}

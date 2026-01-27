public class Solution322
{

    public int CoinChange(int[] coins, int amount)
    {
        if (amount == 0)
            return 0;
        if (coins.Length == 0)
            return -1;

        int max = amount + 1;
        int[] dp = new int[amount + 1];
        Array.Fill(dp, max);
        dp[0] = 0;


        for (long i = 0; i <= amount; i++)
        { 
            foreach (long coin in coins)
            {
                if (i + coin <= amount && dp[i + coin] > dp[i] + 1)
                {
                    dp[i + coin] = dp[i] + 1;
                }
            }
        }

        return dp[amount] > amount ? -1 : dp[amount];
    }
}
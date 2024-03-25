namespace HelloWorld;

class BuySellStock
{

    static int BuySell(int[] stocks)
    {
        int maxProfit = 0;
        int rIndex = 1;
        int lIndex = 0;
        while (lIndex < stocks.Length - 1 && rIndex < stocks.Length)
        {
            var buyValue = stocks[lIndex];
            var sellValue = stocks[rIndex];
            var profitOrLoss = sellValue - buyValue;
            if (profitOrLoss < 0)
            {
                lIndex = rIndex;
                rIndex++;
            }
            else
            {
                maxProfit = Math.Max(maxProfit, profitOrLoss);
                rIndex++;
            }
        }
        return maxProfit;

    }
    public static void Test()
    {
        int res = BuySell(new int[] { 7, 1, 2, 3, 6, 4 });

        Console.WriteLine(res);
    }
}
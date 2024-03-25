namespace HelloWorld;

class Container
{

    static int ContainerMax(int[] height)
    {
        int maxArea = int.MinValue;
        int rIndex = height.Length - 1;
        int lIndex = 0;
        while (lIndex < rIndex)
        {
            var lValue = height[lIndex];
            var rValue = height[rIndex];
            var area = Math.Min(lValue, rValue) * (rIndex - lIndex);
            maxArea = Math.Max(maxArea, area);
            if (lValue < rValue)
            {
                lIndex++;
            }
            else
            {
                rIndex--;
            }
        }
        return maxArea;

    }
    public static void Test()
    {
        int res = ContainerMax(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
        Console.WriteLine(res);
    }
}
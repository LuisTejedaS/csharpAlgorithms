namespace HelloWorld;

class TwoSum
{
    class Res
    {
        public Res(int index1, int index2)
        {
            this.index1 = index1;
            this.index2 = index2;
        }
        public int index1;
        public int index2;
    }
    static List<Res> TwoSumImpl(int[] numbers, int sum)
    {
        List<Res> res = new();
        Dictionary<int, int> map = new();

        for (int index = 0; index < numbers.Length; index++)
        {
            int value = numbers[index];
            int diff = sum - value;

            if (map.TryGetValue(diff, out int foundIndex))
            {
                res.Add(new Res(index, foundIndex));
            }
            else
            {
                map.Add(value, index);
            }
        }
        return res;

    }
    public static void Test()
    {
        List<Res> res = TwoSumImpl(new int[] { 1, 2, 3, 4, 5, 6 }, 8);
        res.ForEach(item =>
        {
            Console.WriteLine(item.index1 + " " + item.index2);
        });
    }
}
namespace HelloWorld;

class LeftRotation
{
    static int[] Rotate(int[] ar, int rotations)
    {
        int[] res = new int[ar.Length];
        int realRotations = rotations % ar.Length;

        for (int index = 0; index < ar.Length; index++)
        {
            int newPoss = index - realRotations;
            if (newPoss < 0)
            {
                newPoss = ar.Length + newPoss;
            }

            res[newPoss] = ar[index];
        }
        return res;

    }
    public static void Test()
    {

        Rotate(new int[] { 1, 2, 3, 4 }, 1).ToList().ForEach(item =>
        {
            Console.Write(item);
        });
        Console.WriteLine("\n");
        Rotate(new int[] { 1, 2, 3, 4 }, 5).ToList().ForEach(item =>
        {
            Console.Write(item);
        });
        Console.WriteLine("\n");
        Rotate(new int[] { 1, 2, 3, 4 }, 13).ToList().ForEach(item =>
        {
            Console.Write(item);
        });
        Console.WriteLine("\n");
        Rotate(new int[] { 1, 2, 3, 4 }, 15).ToList().ForEach(item =>
        {
            Console.Write(item);
        });

    }
}
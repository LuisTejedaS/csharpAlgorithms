namespace HelloWorld;

class Subsequence
{
    static bool IsSubsequence(string world, string part)
    {
        int worldIndex = 0;
        int partIndex = 0;
        while (partIndex < part.Length)
        {
            if (worldIndex >= world.Length)
            {
                return false;
            }
            if (part[partIndex] == world[worldIndex])
            {
                partIndex++;
            }
            worldIndex++;
        }
        return true;

    }
    public static void Test()
    {
        Console.WriteLine(IsSubsequence("abc", "ab"));
        Console.WriteLine(IsSubsequence("abc", "ac"));
        Console.WriteLine(IsSubsequence("abc", "acd"));
        Console.WriteLine(IsSubsequence("abc", "abc"));
        Console.WriteLine(IsSubsequence("abcbc", "acb"));
    }
}
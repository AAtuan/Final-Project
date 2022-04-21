// Lab 3 17 22 - Abel Atuan
// TODO: Complete the steps outlined in the lab description

using System.Diagnostics;

class Program
{

    // returns the position of the given name in the given sorted list of names
    // or -1 if it is not contained in the list
    static int BinarySearch(string[] names, string name)
    {
        // TODO 4
    int minNum = 0;
    int maxNum = names.Length -1;

    while (minNum <= maxNum)
    {
        int mid = (minNum + maxNum)/2;
        if (name == names[mid])
        {
            return = mid -1;
        }
        else if (name.CompareTo(names[mid]) < 0)
        {
            maxNum = mid -1;
        }
        {
            minNum = mid +1;
        }
    }
    return -1;
    }

    static void Test()
    {
        string[] words1 = { "add", "be", "because", "chop", "yes" };
        Debug.Assert(BinarySearch(words1, "add") == 0);
        Debug.Assert(BinarySearch(words1, "be") == 1);
        Debug.Assert(BinarySearch(words1, "because") == 2);
        Debug.Assert(BinarySearch(words1, "chop") == 3);
        Debug.Assert(BinarySearch(words1, "yes") == 4);
        Debug.Assert(BinarySearch(words1, "no") == -1);
        Debug.Assert(BinarySearch(words1, "") == -1);

        string[] words2 = { "be", "chop", "yes" };
        Debug.Assert(BinarySearch(words2, "yes") == 2);
        Debug.Assert(BinarySearch(words2, "be") == 0);
        Debug.Assert(BinarySearch(words2, "chop") == 1);
        Debug.Assert(BinarySearch(words2, "chops") == -1);
        Debug.Assert(BinarySearch(words2, "cho") == -1);
        Console.WriteLine("tests passed.");
    }

    static void Main()
    {
        // Test(); // TODO 3
        string[] names = File.ReadAllLines("RankedNames.txt");
        Array.Sort(names);

        Stopwatch timer = new Stopwatch();
        timer.Start();

        StreamWriter outFile = new StreamWriter("Results.txt");
        foreach (string name in File.ReadAllLines("Requests.txt"))
        {
            // TODO 1, 2, 5
            int position = Array.IndexOf(names, name);
            // int position = Array.BinarySearch(names, name);
            // int position = BinarySearch(names, name);
            outFile.WriteLine($"{name} is at position {position}.");
        }
        outFile.Close();

        timer.Stop();

        Console.WriteLine($"Searching took {timer.ElapsedMilliseconds / 1000.0} seconds.");
    }
}
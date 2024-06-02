
using System.Globalization;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    public static void Main()
    {
        string[] input = File.ReadAllLines("input.txt");
    }
    public static int[] FindValids(string[] Arr)
    {
        int[] RtnArr = [];
        for (int i = 0; i < Arr.Length; i++)
        {
            for (int j = 0; j < Arr[i].Length; j++)
            {
                if (IsSymbol(Arr[i][j]))
                {
                    if (i == 0)
                    {
                        if (char.IsDigit(Arr[i - 1][j]))
                        {
                            RtnArr = [.. RtnArr, GetNumber(Arr[i].Substring([j]))];
                        }
                    }
                }
            }
        }
    }
    public static int FindNumIndex(int Cindex, string line)
    {
        if (Cindex == -1)
        {
            return -1;
        }
        for (int i = Cindex; i < line.Length; i++)
        {
            if (char.IsDigit(line[i - 1]))
            {
                for (int j = i - 1; j < line.Length; j++)
                {
                    
                }
            }
        }
    }
    public static int GetNumber(string Enc)
    {
        string RtnStr = "";
        for (int i = 0; i < Enc.Length; i++)
        {
            if (char.IsDigit(Enc[i]))
            {
                Console.WriteLine($"The char {Enc[i]} is a digit");
                while (char.IsDigit(Enc[i]))
                {
                    RtnStr += Enc[i];
                    i++;
                }

                return int.Parse(RtnStr);
            }
        }
        return 0;
    }
    public static bool IsSymbol(char C)
    {
        char[] chars = ['-', '+', '=', '*', '$', '&', '/', '@', '%',];
        foreach (char var in chars)
        {
            if (C == var)
            {
                return true;
            }
        }
        return false;
    }
}

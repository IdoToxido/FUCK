class Number(int Num, int SIndex, int EIndex)
{
    public int Num = Num;
    public int SIndex = SIndex;
    public int EIndex = EIndex;
}
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
            if (i == 0)
            {

            }
        }
    }
    public static Number GetNumber(string Enc)
    {
        Number rtn = new(-1, 0, -1);
        string RtnStr = "";
        for (int i = 0; i < Enc.Length; i++)
        {
            if (char.IsDigit(Enc[i]))
            {
                Console.WriteLine($"The char {Enc[i]} is a digit");
                rtn.SIndex = i;
                while (char.IsDigit(Enc[i]))
                {
                    RtnStr += Enc[i];
                    i++;
                }
                rtn.EIndex = i;
                rtn.Num = int.Parse(RtnStr);
                return rtn;
            }
        }
        return new(0, 0, 0);
    }
    public static bool IsSymbol(char C)
    {
        char[] chars = ['-', '+', '=', '*', '$', '&', '/', '@', '%',];
        foreach (string var in chars)
        {
            if (C == var)
            {
                return true;
            }
        }
        return false;
    }
}
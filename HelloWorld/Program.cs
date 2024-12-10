namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(AddBinary("1", "111"));
    }
    
    static string AddBinary(string a, string b) 
    {
        int nextRank = 0;
        string result = "";

        if (a.Length < b.Length)
        {
            for (int i = 0; i <= (b.Length - a.Length); i++)
            {
                a = "0" + a;
            }
        }
        else
        {
            for (int i = 0; i <= (a.Length - b.Length); i++)
            {
                b = "0" + b;
            }
        }

        for (int i = a.Length - 1; i >= 0; i--) // 1 
        {
            int tempA = int.Parse(a[i].ToString());
            int tempB = int.Parse(b[i].ToString());
            result = ((tempA + tempB + nextRank) % 2) + result;
            nextRank = (nextRank + tempA + tempB) >= 2 ? 1 : 0;
        }

        if (nextRank != 0)
        {
            result = nextRank + result;
        }

        return result;

    }
}



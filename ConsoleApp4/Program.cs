using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Transactions;

var x = CheckIfNumberIsVerySamllNegativeNumber(-7.576E-05);
//Console.WriteLine(ToLongString(-7.576));
Console.WriteLine(x);
static bool CheckIfNumberIsVerySamllNegativeNumber(double input)
{

    double y = -0.098 / 187487836583756;
    var s = y.ToString();
    string strOrig = input.ToString();
    string str = strOrig.ToUpper();

    // if string representation was collapsed from scientific notation, just return it:
    if (!str.Contains('E')) return false;

    bool negativeNumber = false;

    if (str[0] == '-')
    {
        str = str.Remove(0, 1);
        negativeNumber = true;
    }

    string[] exponentParts = str.Split('E');

    int exponentValue = int.Parse(exponentParts[1]);

    if (negativeNumber && exponentValue <= -5 && str.Contains('E'))
        return true;    

    return false;
}

static string GetZeros(int zeroCount)
{
    if (zeroCount < 0)
        zeroCount = Math.Abs(zeroCount);

    StringBuilder sb = new StringBuilder();

    for (int i = 0; i < zeroCount; i++) sb.Append("0");

    return sb.ToString();
}


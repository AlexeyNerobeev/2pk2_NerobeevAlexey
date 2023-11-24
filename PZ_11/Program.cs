namespace PZ_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num1 = "12";
            string num2 = "13";
            string num3 = "14";
            string num4 = "15";
            string num5 = "16";
            InvertDigits(num1, num2, num3, num4, num5);
        }
        static void InvertDigits(string num1, string num2, string num3, string num4, string num5)
        {
            num1 = "12";
            char[] num11 = num1.ToArray();
            string num111 = Convert.ToString(num11[1]);
            string num1111 = Convert.ToString(num11[0]);
            string num11111 = num111 + num1111;
            num2 = "13";
            char[] num12 = num2.ToArray();
            string num222 = Convert.ToString(num12[1]);
            string num2222 = Convert.ToString(num12[0]);
            string num22222 = num222 + num2222;
            num3 = "14";
            char[] num13 = num3.ToArray();
            string num333 = Convert.ToString(num13[1]);
            string num3333 = Convert.ToString(num13[0]);
            string num33333 = num333 + num3333;
            num4 = "15";
            char[] num14 = num4.ToArray();
            string num444 = Convert.ToString(num14[1]);
            string num4444 = Convert.ToString(num14[0]);
            string num44444 = num444 + num4444;
            num5 = "16";
            char[] num15 = num5.ToArray();
            string num555 = Convert.ToString(num15[1]);
            string num5555 = Convert.ToString(num15[0]);
            string num55555 = num555 + num5555;
            string[] Numbers = { num11111, num22222, num33333, num44444, num55555 };
            foreach (string num in Numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
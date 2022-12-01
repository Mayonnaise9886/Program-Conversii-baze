using System;

namespace anybase
{
    public class TemaOrosConversieBaze
    {
        static int val(char c)
        {
            if (c >= '0' && c <= '9')
                return (int)c - '0';
            else
                return (int)c - 'A' + 10;
        }
        static int toDeci(string str, int bazanr)
        {
            int len = str.Length;

            int puterenr = 1;

            int num = 0;

            for (int i = len - 1; i >= 0; i--)
            {
                if (val(str[i]) >= bazanr)
                {
                    Console.Write("Invalid Number");
                    return -1;
                }

                num += val(str[i]) * puterenr;

                puterenr = puterenr * bazanr;
            }
            return num;
        }

        static char reVal(int num)
        {
            if (num >= 0 && num <= 9)
                return (char)(num + '0');
            else
                return (char)(num - 10 + 'A');
        }

        static string fromDeci(int bazanr, int inputNum)
        {

            string res = "";

            while (inputNum > 0)
            {
                res += reVal(inputNum % bazanr);

                inputNum /= bazanr;
            }

            res = reverse(res);

            return res;
        }

        static void convertbazanr(string s, int a, int b)
        {
            int num = toDeci(s, a);

            string ans = fromDeci(b, num);

            Console.Write(ans);
        }

        static string reverse(string input)
        {
            char[] a = input.ToCharArray();
            int l, r = a.Length - 1;
            for (l = 0; l < r; l++, r--)
            {
                char temp = a[l];
                a[l] = a[r];
                a[r] = temp;
            }
            return new string(a);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti valoarea ce trebuie convertita: ");
            string s = Console.ReadLine().ToUpper();
            Console.WriteLine("Introduceti baza din care se face conversia: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti baza in care trebuie facuta conversia: ");
            int b = Convert.ToInt32(Console.ReadLine());

            convertbazanr(s, a, b);
        }
    }
}
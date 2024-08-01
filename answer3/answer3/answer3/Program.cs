using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace answer3
{
    class Program
    {
        static String pilink(String str,
                                          int k)
        {
            char[] palin = str.ToCharArray();
            String ans = "";

            int l = 0;
            int r = str.Length - 1;

            while (l < r)
            {

                if (str[l] != str[r])
                {
                    palin[l] = palin[r]
                      = (char)Math.Max(str[l], str[r]);
                    k--;
                }
                l++;
                r--;
            }
            if (k < 0)
            {
                return "Errs";
            }

            l = 0;
            r = str.Length - 1;

            while (l <= r)
            {
                if (l == r)
                {
                    if (k > 0)
                    {
                        palin[l] = '9';
                    }
                }
                if (palin[l] < '9')
                {

                    if (k >= 2 && palin[l] == str[l]
                        && palin[r] == str[r])
                    {
                        k -= 2;
                        palin[l] = palin[r] = '9';
                    }

                    else if (k >= 1
                             && (palin[l] != str[l]
                                 || palin[r] != str[r]))
                    {
                        k--;
                        palin[l] = palin[r] = '9';
                    }
                }
                l++;
                r--;
            }
            for (int i = 0; i < palin.Length; i++)
                ans += palin[i];
            return ans;
        }

        public static void Main()
        {
            String str = "73533";
            int k = 3;
            Console.Write(pilink(str, k));
            Console.ReadLine();
        }
    }
}

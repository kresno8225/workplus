using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace answer1
{
    class Program
    {
        static void Main(string[] args)
        {
            testcase();
        }

        public static void testcase()
        {
            int[] ins = { 2, 3, 4, 5 };
            foreach (var item in weightedstring("gigi", ins))
            {
                Console.WriteLine(item.ToString());
            }
            var i = Console.ReadLine();
        }

        public static string[] weightedstring(string inputs, int[] nums)
        {
            int i = 0;
            int indeks = 0;
            List<int> cur_i = new List<int>();
            char prev_c = '\0';
            string[] ret = nums.Select(x => x.ToString()).ToArray();

            foreach (char c in inputs)
            {

                if ((prev_c != '\0') && (c == prev_c))
                {
                    i = i + (char.ToUpper(c) - 64);
                    cur_i[cur_i.Last()] = i;
                }
                else
                {
                    i = char.ToUpper(c) - 64;
                    cur_i.Add(i);
                }

                prev_c = c;
            }

            i = 0;

            foreach (int x in cur_i)
            {
                if (x == nums[i])
                {
                    ret[i] = "yes";
                }
                else
                {
                    ret[i] = "no";
                }
                i++;
            }

            return ret;
        }
    }
}

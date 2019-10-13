using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCount
{
    public class asccII_count
    {
        //统计字符的个数
        public static int ascciicount()
        {
            string str = File.ReadAllText(@file_path.input_path);
            int num_char = Regex.Matches(str, @".").Count;
            if (line_count.lines() == 0)
            {
                return num_char + line_count.lines();
            }
            else
            {
                return num_char + line_count.lines() - 1;
            }
        }
    }
}

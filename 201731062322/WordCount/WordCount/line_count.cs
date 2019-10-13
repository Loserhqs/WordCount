using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCount
{
    public class line_count
    {
        //统计文件的行数
        public static int lines()
        {

            string str = File.ReadAllText(@file_path.input_path);
            int num_line = Regex.Matches(str, @"\r").Count;
            if (num_line != 0)
                num_line = num_line + 1;
            return num_line;
        }
    }
}

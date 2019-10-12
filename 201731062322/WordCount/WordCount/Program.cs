using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        //文件路径 file_path
        //单词总数 word_sum
        //单词频数 word_frequency
        static void Main(string[] args)
        {
            word_len WL1 = new word_len(0);
            word_more WM1 = new word_more(10);
            illustration ill1 = new illustration();
            select_way sw1 = new select_way();
            ill1.illu_way();
            int cmd_num = Convert.ToInt32(Console.ReadLine());
            switch(cmd_num)
            {
                case 1: sw1.instruction(WL1,WM1);
                    break;
                case 2: sw1.nointrction(WL1,WM1);
                    break;
                default: sw1.the_error();
                    break;
            }
            Console.ReadKey();
        }
    }
}

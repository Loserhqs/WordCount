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
            illustration.illu_way();
            int cmd_num = Convert.ToInt32(Console.ReadLine());
            switch (cmd_num)
            {
                case 1: select_way.instruction();
                    break;
                case 2: select_way.nointrction();
                    break;
                default: select_way.the_error();
                    break;
            }
            Console.ReadKey();
        }
    }
}

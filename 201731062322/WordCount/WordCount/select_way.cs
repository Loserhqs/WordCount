using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class select_way
    {
        illustration ill2 = new illustration();
        result re1 = new result();
        ins_process inp1 = new ins_process();

        public void instruction(word_len len,word_more more)
        {
            ill2.illu_function();
            Console.WriteLine("input your instructions");
            string all_char = Console.ReadLine();
            string[] ins_arr = all_char.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            int ind_sum = 0;
            for (int i = 0; i < ins_arr.Length; i = i + 2)
            {
                ind_sum = ind_sum + inp1.ins_select(ins_arr, i,len,more);
            }
            inp1.ins_right(ind_sum,len,more);
        }
        public void nointrction(word_len len,word_more more)
        {
            Console.WriteLine("the input path:");
            string inputpath = Console.ReadLine();
            file_path.input_path = inputpath;
            //result.Word_more = 10;
            //result.Word_len = 0;
            Console.WriteLine("the output path:");
            string outputpath = Console.ReadLine();
            file_path.output_path = outputpath;
            //re1.WM.Wordmore = 10;
            re1.print_char();
            re1.print_word(len);
            re1.print_lines();
            re1.print_wordsort(more.Wordmore,len);
        }
        public void the_error()
        {
            Console.WriteLine("the error instruction");
            Console.ReadKey();
        }
    }
}

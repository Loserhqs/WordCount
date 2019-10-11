using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class select_way
    {
        public static void instruction()
        {
            illustration.illu_function();
            Console.WriteLine("input your instructions");
            string all_char = Console.ReadLine();
            string[] ins_arr = all_char.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            int ind_sum = 0;
            for (int i = 0; i < ins_arr.Length; i = i + 2)
            {
                ind_sum = ind_sum + ins_process.ins_select(ins_arr, i);
            }
            ins_process.ins_right(ind_sum);
        }
        public static void nointrction()
        {
            Console.WriteLine("the input path:");
            string inputpath = Console.ReadLine();
            file_path.input_path = inputpath;
            //result.Word_more = 10;
            //result.Word_len = 0;
            Console.WriteLine("the output path:");
            string outputpath = Console.ReadLine();
            file_path.output_path = outputpath;
            result.Word_more = 10;
            result.print_char();
            result.print_word();
            result.print_lines();
            result.print_wordsort(result.Word_more);
        }
        public static void the_error()
        {
            Console.WriteLine("the error instruction");
            Console.ReadKey();
        }
    }
}

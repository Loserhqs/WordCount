using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class ins_process
    {
        static string str1 = "-l";
        static string str2 = "-m";
        static string str3 = "-n";
        static string str4 = "-o";
        public static int ins_select(string[] array, int i)
        {
            int flag = 0;
            if (array[i].Equals(str1, StringComparison.OrdinalIgnoreCase) == true)
            {
                file_path.input_path = array[i + 1];
                flag = 1;
            }
            else if (array[i].Equals(str2, StringComparison.OrdinalIgnoreCase) == true)
            {
                result.Word_len = Convert.ToInt32(array[i]);
                flag = 2;
            }
            else if (array[i].Equals(str3, StringComparison.OrdinalIgnoreCase) == true)
            {
                result.Word_more = Convert.ToInt32(array[i + 1]);
                flag = 4;
            }
            else if (array[i].Equals(str4, StringComparison.OrdinalIgnoreCase) == true)
            {
                file_path.output_path = array[i + 1];
                flag = 8;
            }
            else
            {
                flag = -16;
            }
            return flag;
        }
        public static void ins_right(int x)
        {
            if (x > 0)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine("need a input file");
                    Console.ReadKey();
                }
                else
                {
                    if (x == 1)
                    {
                        result.Word_more = 10;
                        file_path.output_path = "output.txt";
                        //result.Word_len = 0;
                        result.print_char();
                        result.print_word();
                        result.print_lines();
                        result.print_wordsort(result.Word_more);
                    }
                    else if (x == 3)
                    {
                        result.Word_more = 10;
                        file_path.output_path = "output.txt";
                        result.print_char();
                        result.print_word();
                        result.print_lines();
                        result.print_wordsort(result.Word_more);
                        result.print_selectedlong();
                    }
                    else if (x == 5)
                    {
                        file_path.output_path = "output.txt";
                        //result.Word_len = 0;
                        result.print_char();
                        result.print_word();
                        result.print_lines();
                        result.print_wordsort(result.Word_more);
                    }
                    else if (x == 7)
                    {
                        file_path.output_path = "output.txt";
                        result.print_char();
                        result.print_word();
                        result.print_lines();
                        result.print_wordsort(result.Word_more);
                        result.print_selectedlong();
                    }
                    else if (x == 9)
                    {
                        result.Word_more = 10;
                        //result.Word_len = 0;
                        result.print_char();
                        result.print_word();
                        result.print_lines();
                        result.print_wordsort(result.Word_more);
                    }
                    else if (x == 11)
                    {
                        result.Word_more = 10;
                        result.print_char();
                        result.print_word();
                        result.print_lines();
                        result.print_wordsort(result.Word_more);
                        result.print_selectedlong();
                    }
                    else if (x == 13)
                    {
                        //result.Word_len = 0;
                        result.print_char();
                        result.print_word();
                        result.print_lines();
                        result.print_wordsort(result.Word_more);
                    }
                    else
                    {
                        result.print_char();
                        result.print_word();
                        result.print_lines();
                        result.print_wordsort(result.Word_more);
                        result.print_selectedlong();
                    }
                }
            }
            else
            {
                Console.WriteLine("the wrong instruction");
                Console.ReadKey();
            }
        }
    }
}

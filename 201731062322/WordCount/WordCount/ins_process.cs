using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    public class ins_process
    {
        static string str1 = "-l";
        static string str2 = "-m";
        static string str3 = "-n";
        static string str4 = "-o";
        result re2 = new result();

        public int ins_select(string[] array, int i,word_len len,word_more more)
        {
            int flag = 0;
            if (array[i].Equals(str1, StringComparison.OrdinalIgnoreCase) == true)
            {
                file_path.input_path = array[i + 1];
                flag = 1;
            }
            else if (array[i].Equals(str2, StringComparison.OrdinalIgnoreCase) == true)
            {
                len.Wordlen = Convert.ToInt32(array[i + 1]);
                //result.WL.Wordlen = Convert.ToInt32(array[i+1]);
                flag = 2;
            }
            else if (array[i].Equals(str3, StringComparison.OrdinalIgnoreCase) == true)
            {
                //result.WM.Wordmore = Convert.ToInt32(array[i + 1]);
                more.Wordmore = Convert.ToInt32(array[i + 1]);
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
        public void ins_right(int x,word_len len,word_more more)
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
                        //result.Word_more = 10;
                        file_path.output_path = "output.txt";
                        //result.Word_len = 0;
                        re2.print_char();
                        re2.print_word(len);
                        re2.print_lines();
                        re2.print_wordsort(more.Wordmore,len);
                    }
                    else if (x == 3)
                    {
                        //result.Word_more = 10;
                        file_path.output_path = "output.txt";
                        re2.print_char();
                        re2.print_word(len);
                        re2.print_lines();
                        re2.print_wordsort(more.Wordmore, len);
                        re2.print_selectedlong(len.Wordlen );
                    }
                    else if (x == 5)
                    {
                        file_path.output_path = "output.txt";
                        //result.Word_len = 0;
                        re2.print_char();
                        re2.print_word(len);
                        re2.print_lines();
                        re2.print_wordsort(more.Wordmore, len);
                    }
                    else if (x == 7)
                    {
                        file_path.output_path = "output.txt";
                        re2.print_char();
                        re2.print_word(len);
                        re2.print_lines();
                        re2.print_wordsort(more.Wordmore, len);
                        re2.print_selectedlong(len.Wordlen);
                    }
                    else if (x == 9)
                    {
                        //result.Word_more = 10;
                        //result.Word_len = 0;
                        re2.print_char();
                        re2.print_word(len);
                        re2.print_lines();
                        re2.print_wordsort(more.Wordmore, len);
                    }
                    else if (x == 11)
                    {
                        //result.Word_more = 10;
                        re2.print_char();
                        re2.print_word(len);
                        re2.print_lines();
                        re2.print_wordsort(more.Wordmore, len);
                        re2.print_selectedlong(len.Wordlen);
                    }
                    else if (x == 13)
                    {
                        //result.Word_len = 0;
                        re2.print_char();
                        re2.print_word(len);
                        re2.print_lines();
                        re2.print_wordsort(more.Wordmore, len);
                    }
                    else
                    {
                        re2.print_char();
                        re2.print_word(len);
                        re2.print_lines();
                        re2.print_wordsort(more.Wordmore, len);
                        re2.print_selectedlong(len.Wordlen );
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class result
    {
        /*public int Word_index(int x)
        {
            word_len WL = new word_len(0);
            Dictionary<string, int> frequent = new Dictionary<string, int>();
            //统计单词的频数
            Dictionary<string, int> frequency_temp = word_count.word_frequency(ref frequent, WL.Wordlen);
            Dictionary<string, int> dic1 = frequency_temp.OrderBy(o => o.Key).ToDictionary(o => o.Key, p => p.Value);
            //单词总数量
            int word_index = word_count.word_sum(dic1);
            return word_index;
        }*/
        //public static word_len WL = new word_len(0);
        //public static word_more WM = new word_more(10);
        /*
        static Dictionary<string, int> frequent = new Dictionary<string, int>();
        //统计单词的频数
        static Dictionary<string, int> frequency_temp = word_count.word_frequency(ref frequent, );
        static Dictionary<string, int> dic1 = frequency_temp.OrderBy(o => o.Key).ToDictionary(o => o.Key, p => p.Value);
        //单词总数量
        static int word_index = word_count.word_sum(dic1);
        */
        public void print_char()
        {
            Console.WriteLine("characters:" + asccII_count.ascciicount());
        }
        public void print_word(word_len len)
        {
            Dictionary<string, int> frequent = new Dictionary<string, int>();
            //统计单词的频数
            Dictionary<string, int> frequency_temp = word_count.word_frequency(ref frequent, len.Wordlen);
            Dictionary<string, int> dic1 = frequency_temp.OrderBy(o => o.Key).ToDictionary(o => o.Key, p => p.Value);
            //单词总数量
            int word_index = word_count.word_sum(dic1);
            Console.WriteLine("words:" + word_index);
        }
        public void print_lines()
        {
            Console.WriteLine("lines:" + line_count.lines());
        }
        public void print_wordsort(int word_temp,word_len len)
        {
            int word_sum = 0;
            Dictionary<string, int> frequent = new Dictionary<string, int>();
            Dictionary<string, int> frequency_temp = word_count.word_frequency(ref frequent, len.Wordlen);
            Dictionary<string, int> dic2 = frequency_temp.OrderByDescending(o => o.Value).ThenBy(o => o.Key).ToDictionary(o => o.Key, p => p.Value);
            foreach (KeyValuePair<string, int> entry in dic2)
            {
                if (word_sum == word_temp)
                    break;
                string word = entry.Key;
                int fre_temp = entry.Value;
                word_sum++;
                Console.WriteLine("{0}:{1}", word, fre_temp);
            }
        }
        public void print_selectedlong(int len)
        {
            if (len != 0)
            {
                Console.WriteLine("the selected long word:");
                Dictionary<string, int> frequent = new Dictionary<string, int>();
                Dictionary<string, int> frequency_temp = word_count.word_frequency(ref frequent, len);
                foreach (KeyValuePair<string, int> entry in frequent)
                {
                    string word = entry.Key;
                    Console.WriteLine("{0}:{1}", word, entry.Value);
                }
            }
            else
            {
                Console.WriteLine("It is impossible to have words of that length");
            }
        }
    }
}

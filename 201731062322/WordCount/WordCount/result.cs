using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class result
    {
        //static int word_sum = 0;
        private static int word_more;

        public static int Word_more
        {
            get { return result.word_more; }
            set { result.word_more = value; }
        }
        private static int word_len;
        public static int Word_len
        {
            get { return result.word_len; }
            set { result.word_len = value; }
        }

        static Dictionary<string, int> frequent = new Dictionary<string, int>();
        //统计单词的频数
        static Dictionary<string, int> frequency_temp = word_count.word_frequency(ref frequent, Word_len);
        static Dictionary<string, int> dic1 = frequency_temp.OrderBy(o => o.Key).ToDictionary(o => o.Key, p => p.Value);
        //单词总数量
        static int word_index = word_count.word_sum(dic1);
        public static void print_char()
        {
            Console.WriteLine("characters:" + asccII_count.ascciicount());
        }
        public static void print_word()
        {
            Console.WriteLine("words:" + word_index);
        }
        public static void print_lines()
        {
            Console.WriteLine("lines:" + line_count.lines());
        }
        public static void print_wordsort(int word_temp)
        {
            int word_sum = 0;
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
        public static void print_selectedlong()
        {
            Console.WriteLine("the selected long word:");
            foreach (KeyValuePair<string, int> entry in frequent)
            {
                string word = entry.Key;
                Console.WriteLine("{0}:{1}", word, entry.Value);
            }
        }
    }
}

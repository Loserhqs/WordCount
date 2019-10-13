using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace WordCount
{
    public class word_count
    {
        //打印频数高的单词
        public static int word_sum(Dictionary<string, int> dic)
        {
            StreamWriter sw = new StreamWriter(@file_path.output_path);
            int wordsum = 0;
            foreach (KeyValuePair<string, int> entry in dic)
            {

                string word = entry.Key;
                int frequency = entry.Value;
                sw.Write(word + "\r\n");
                wordsum = wordsum + frequency;
            }
            sw.Close();
            return wordsum;
        }
        //打印该单词的频数
        public static Dictionary<string, int> word_frequency(ref Dictionary<string, int> frequencies, int len)
        {
            int num_word = 0;
            int flag = 0;
            string str = File.ReadAllText(@file_path.input_path);
            Dictionary<string, int> frequency = new Dictionary<string, int>();
            string[] words = Regex.Split(str, @"\W+");
            string[] newword = uniform_character.uncharater(words, ref num_word);
            string[] word1 = new string[num_word];
            string[] word2 = new string[num_word];
            for (int i = 0; i < num_word; i++)
            {
                word1[i] = newword[i];
            }
            foreach (string word in word1)
            {

                if (frequencies.ContainsKey(word))
                {
                    frequencies[word]++;
                }
                else
                {
                    frequencies[word] = 1;
                }
            }
            if (len > 0)
            {
                for (int j = 0; j < num_word - len + 1; j++)
                {

                    for (int z = 0; z < len; z++)
                    {
                        word2[flag] = word2[flag] + " " + word1[j + z];
                    }
                    flag++;
                }
                for (int i = 0; i < flag; i++)
                {
                    if (frequencies.ContainsKey(word2[i]))
                    {
                        frequencies[word2[i]]++;
                    }
                    else
                    {
                        frequencies[word2[i]] = 1;
                    }
                }
            }
            return frequencies;
        }
    }
}

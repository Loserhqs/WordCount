using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    public class uniform_character
    {
        //统一字符
        public static string[] uncharater(string[] words, ref int num_word)
        {
            char[] newword = new char[10000];
            int index = 0;
            string[]  word_all= new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                char[] word = words[i].ToCharArray();
                for (int j = 0; j < word.Length; j++)
                {
                    if (word[j] >= 'A' && word[j] <= 'Z')
                    {
                        word[j] = Convert.ToChar((Convert.ToInt32(word[j]) + 32));
                    }
                }
                if (word.Length >= 4)
                {
                    int flag=0;
                    for (int k = 0; k < 4;k++ )
                    {
                        if(word[k]>='a'&&word[k]<='z')
                        {
                            flag++;
                        }
                    }
                    if(flag==4)
                    {
                        newword = word;
                        string str = String.Join("", newword);
                        word_all[index] = str;
                        index++;
                    }
                    /*if ((word[0] >= 'a' && word[0] <= 'z') && (word[1] >= 'a' && word[1] <= 'z') && (word[2] >= 'a' && word[2] <= 'z') && (word[3] >= 'a' && word[3] <= 'z'))
                    {
                        newword = word;
                        string str = String.Join("", newword);
                        word_all[index] = str;
                        index++;
                    }*/
                }
            }
            num_word = index;
            return word_all;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    public class word_len
    {
        private int wordlen;
        public word_len(int wordlen)
        {
            this.wordlen = wordlen;
        }
        public int Wordlen
        {
            get { return wordlen; }
            set { wordlen = value; }
        }

    }
}

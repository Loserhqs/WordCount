using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    public class word_more
    {
         private int wordmore;
        public word_more(int wordmore)
        {
            this.wordmore=wordmore;
        }
        public int Wordmore
        {
            get { return wordmore; }
            set { wordmore = value; }
        }
    }
}

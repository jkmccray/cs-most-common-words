using System.Collections.Generic;
using System.Linq;

namespace MostCommonWords
{
    public class WordCount
    {
        public WordCount(IGrouping<string, string> wordGroup)
        {
            Dictionary<string, int> wordInfo = new Dictionary<string, int>();
        }
        public Dictionary<string, int> wordInfo {get; set;}

    }
}
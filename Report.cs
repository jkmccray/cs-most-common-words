using System.Collections.Generic;

namespace MostCommonWords
{
    public class Report
    {
        public Report()
        {
            Dictionary<string, int> wordInfo = new Dictionary<string, int>();
        }
        public string  { get; set; }
        public int TotalCount { get; set; }
        public string LowerCaseVersion { get; set; }
        public int LowerCaseCount { get; set; }
        public string UpperCaseVersion { get; set; }
        public int UpperCaseCount { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Razor_TagCloud.Data
{
    public class Tags
    {
        public string Tag { get; set; }
        public int Count { get; set; }
        public string HTMLStyle { get; set; }
        public Tags(string word, int count)
        {
            Tag = word;
            Count = count;
            HTMLStyle = SetHTMLStyle(count);
        }

        private static string SetHTMLStyle(int num)
        {            
            string ret = "xx-large"; // in case things go 'over' the size, use XX-LARGE.

            if (num <= 1)
            {
                ret = "x-small";
            }
            else if (num < 2)
            {
                ret = "small";
            }
            else if (num < 3)
            {
                ret = "medium";
            }
            else if (num < 4)
            {
                ret = "large";
            }
            else if (num < 5)
            {
                ret = "x-large";
            }
            else if (num < 6)
            {
                ret = "xx-large";
            }
            return ret;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Razor_TagCloud.Data
{
    public class DataAccess
    {

        public async Task<List<Tags>> GetTagsAsync()
        {
            List<Tags> tempTags = new List<Tags>();
            return await Task.Run(() =>
            {
                Random random = new Random();
                int max = 7;
                tempTags.Add(new Tags("Lorem", random.Next(max)));
                tempTags.Add(new Tags("Ipsum", random.Next(max)));
                tempTags.Add(new Tags("dolor", random.Next(max)));
                tempTags.Add(new Tags("foo", random.Next(max)));
                tempTags.Add(new Tags("bar", random.Next(max)));
                tempTags.Add(new Tags("consectetur", random.Next(max)));
                tempTags.Add(new Tags("adipiscing", random.Next(max)));
                tempTags.Add(new Tags("elit", random.Next(max)));
                tempTags.Add(new Tags("metus", random.Next(max)));
                tempTags.Add(new Tags("auctor", random.Next(max)));
                tempTags.Add(new Tags("bibendum", random.Next(max)));
                tempTags.Add(new Tags("facilisis", random.Next(max)));

                return tempTags;
            });


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_TagCloud.Data;

namespace Razor_TagCloud.Pages
{
    public class IndexModel : PageModel
    {
        public List<Tags> Tags { get; set; }
        public async void OnGet()
        {
            DataAccess da = new DataAccess();

            Tags = await da.GetTagsAsync();
        }
    }
}

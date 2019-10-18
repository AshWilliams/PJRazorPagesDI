using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Test.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public InputNumber Input { get; set; }
        public void OnGet(int number)
        {
            Input = new InputNumber { Number = number };
        }

        public class InputNumber{
            public int Number { get; set; }
        }
    }
}

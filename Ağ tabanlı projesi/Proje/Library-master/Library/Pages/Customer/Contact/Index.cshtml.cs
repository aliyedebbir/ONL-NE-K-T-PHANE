using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Localization;

namespace Library.Pages.Customer.Contact
{
    public class IndexModel : PageModel
    {
        private readonly IStringLocalizer<SharedResource> sharedResource;

        public int currency;

        public IndexModel(IStringLocalizer<SharedResource> _sharedResource)
        {
            sharedResource = _sharedResource;
        }
        public void OnGet()
        {

        }
    }
}
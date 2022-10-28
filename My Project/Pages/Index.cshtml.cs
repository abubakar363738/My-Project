using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using My_Project.Modals;
using My_Project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Project.Pages
{
    public class IndexModel : PageModel
    {
       public IEnumerable<Book> Books { get; private set; }
        //this variable used to store the service inside in  
        public BookJsonFile fileservice;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger,BookJsonFile Fileservice)
        {
            _logger = logger;
            fileservice = Fileservice;
        }
        //apni service sa data niklva kr yhan store krun ga 
        public void OnGet()
        {
            Books = fileservice.Showbook_record();
        }
    }
}

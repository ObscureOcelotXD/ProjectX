using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectXBusiness;
using System;


namespace ProjectX.Pages
{
    public class IndexModel : PageModel
    {
        //[Inject] private IProjectXBusiness ProjectXBusiness { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public int TestInt { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        //protected override async Task OnInitializedAsync()
        //{
        //    TestInt = ProjectXBusiness.TestMethod();
        //}

        public void OnGet()
        {

        }
    }
}
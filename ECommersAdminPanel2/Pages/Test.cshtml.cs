using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommersAdminPanel2.Pages
{
    public class TestModel : PageModel
    {
        [BindProperty]
        public List<int> AreChecked { get; set; } = new List<int>();

        public void OnGet()
        {
        }
        public void OnPost()
        {
        }
    }
}

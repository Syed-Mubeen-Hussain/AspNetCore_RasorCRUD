using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCRUD.Data;
using RazorCRUD.Models;

namespace RazorCRUD.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;
        public List<Category> CategoryList;
        public IndexModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;       
        }
        public void OnGet()
        {
            CategoryList = _dbContext.Categories.ToList();
        }
    }
}

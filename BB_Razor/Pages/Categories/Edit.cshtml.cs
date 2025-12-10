using BB_Razor.Data;
using BB_Razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BB_Razor.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public Category? Category { get; set; }
        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult OnGet(int? id)
        {

            if (id == 0 || id == null)
            {
                return NotFound();
            }
            Category = _db.CategoriesRazor.Find(id);

            if (Category == null)
            {
                return NotFound();
            }
            return Page();
        }


        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _db.CategoriesRazor.Update(Category);
                _db.SaveChanges();
                TempData["success"] = "Category updated successfully";
                return RedirectToPage("Index");
            }
            return Page();

        }
    }
}

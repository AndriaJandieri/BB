using BB_Razor.Data;
using BB_Razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BB_Razor.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public Category? Category { get; set; }
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            //Categories = _db.Categories.ToList();
        }


        public IActionResult OnPost()
        {
            _db.CategoriesRazor.Add(Category);
            _db.SaveChanges();
            //TempData["success"] = $"Category <u><b>{obj.Name}</b></u> created successfully";
            TempData["success"] = "Category created successfully";
            return RedirectToPage("Index");
            //    if (obj.Name == obj.DisplayOrder.ToString())
            //    {
            //        ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the Name.");
            //    }

            //    if (obj.Name != null && obj.Name.ToLower() == "test")
            //    {
            //        ModelState.AddModelError("", "The Name cannot be 'test'.");
            //    }

            //    if (ModelState.IsValid)
            //    {
            //        _db.CategoriesRazor.Add(Category);
            //        _db.SaveChanges();
            //        //TempData["success"] = $"Category <u><b>{obj.Name}</b></u> created successfully";
            //        TempData["success"] = "Category created successfully";
            //        return RedirectToPage("Index");
            //    }
            //    return Page();
            //}
        }
    }
}

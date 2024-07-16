using WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

public class CategoriesController : Controller
{
    public IActionResult Index()
    {
        var categories = CategoriesRepository.getCategories();

        return View(categories);
    }

    public IActionResult Edit(int? id)
    {
        // creating an instance of a category
        var category  new Category { CategoryId = id.HasValue ? (int)id : 0};

        // passing in the model instance to the view in order to be able to use it in the view
        return View(category);
    }
}

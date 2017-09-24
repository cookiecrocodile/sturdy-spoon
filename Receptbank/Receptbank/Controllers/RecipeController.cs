using Receptbank.Models;
using Receptbank.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Receptbank.Controllers
{
    public class RecipeController : Controller
    {
        // GET: Recipe
        public ActionResult Search()
        {
            RecipeSearchViewModel model = new RecipeSearchViewModel();

            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var categories = context.Categories.ToList();
                model.Categories = categories;
            }

            return View(model);
        }

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }
    }
}
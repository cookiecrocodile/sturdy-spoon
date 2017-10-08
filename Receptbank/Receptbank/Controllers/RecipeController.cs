using Receptbank.Models;
using Receptbank.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;


namespace Receptbank.Controllers
{
    public class RecipeController : Controller
    {
        // GET: Recipe
        public ActionResult Index()
        {


            return View();
        }


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

        [HttpPost]
        public ActionResult SearchResult(string searchText, int? page)
        {
            PagedList<Recipe> model;

            using (ApplicationDbContext context = new ApplicationDbContext())
            {

                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    var recipes = context.Recipes.Where(r => r.Name.ToLower().Contains(searchText.ToLower())).OrderBy(r => r.Name);
                    model = new PagedList<Recipe>(recipes, 1, 2);
                }
                else
                {
                    model = new PagedList<Recipe>(new List<Recipe>(), 1, 2);
                }
                
            }

            return PartialView("_SearchResultPartial", model);
        }


        public ActionResult Add()
        {
            AddRecipeViewModel model = new AddRecipeViewModel();

            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var categories = context.Categories.ToList();
                model.Categories = categories;
            }

            return View(model);
        }

        public ActionResult Edit()
        {
            return View();
        }


        //Fixa en kontroll för vad som händer när man klickat på sök-knappen.
        //Kanske kan resultatet laddas i en partial view? Gärna paginerad (kolla kramprojektet)
    }
}
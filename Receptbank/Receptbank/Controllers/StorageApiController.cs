using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Receptbank.Controllers
{
    public class StorageApiController : Controller
    {
        // GET: StorageApi
        public JsonResult ValidateRecipe(string name, string categories, string url, string tags)
        {
            //Logic here
            bool isValid = true;
            string validationMessage = "";

            //Name with at least three non-whitespace characters
            if (string.IsNullOrWhiteSpace(name) || name.Length < 3)
            {
                isValid = false;
                validationMessage += "<li>Receptets namn måste vara minst tre tecken</li>";
            }
            //Optional: check if exact same name exists

            //At least one category checked
            if (string.IsNullOrWhiteSpace(categories))
            {
                isValid = false;
                validationMessage += "<li>Du måste välja minst en kategori</li>";
            }

            //File chosen
            if (string.IsNullOrEmpty(url))
            {
                isValid = false;
                validationMessage += "<li>Ingen fil är vald</li>";
            }

            //Optional: at least one tag

            if (isValid)
            {
                return Json(new { IsValid = true }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { IsValid = false, ValidationMessage = validationMessage }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult AddToStorage()
        {
            //Create recipe object
            
            //Categories = categories from checkboxes
            
            //Tags
            //Split tag string on comma
            //Get tags from db, see if tags exist, if so, add tag id to list
            //If not, add tags to Tags table, get id and add id to list

            //File
            //Add to blob storage, get url back
            //Add url to recipe object

            //Add recipe to database

            //Return succes-view

            return View();
        }
    }
}
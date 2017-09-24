using Receptbank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Receptbank.ViewModels
{
    public class RecipeSearchViewModel
    {
        public IList<Category> Categories { get; set; }
    }
}
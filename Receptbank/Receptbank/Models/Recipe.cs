using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Receptbank.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Receptet måste ha ett namn")]
        [MinLength(2, ErrorMessage = "Receptnamnet måste ha minst två bokstäver")]
        public string Name { get; set; }

        public string FileLocation { get; set; }

        //optional
        public string ImageUrl { get; set; }

        public virtual IList<Category> Categories { get; set; }

        public virtual IList<Ingredient> Ingredients { get; set; }

        public virtual IList<Note> Notes { get; set; }

        public virtual IList<Tag> Tags { get; set; }

        public virtual ApplicationUser AddedBy { get; set; }
    }
}
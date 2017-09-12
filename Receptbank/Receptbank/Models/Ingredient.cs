using System.Collections.Generic;

namespace Receptbank.Models
{
    public class Ingredient
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual IList<Recipe> IncludedIn { get; set; }
    }
}
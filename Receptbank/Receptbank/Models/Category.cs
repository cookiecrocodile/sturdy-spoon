using System.Collections;
using System.Collections.Generic;

namespace Receptbank.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool IsInclusive { get; set; }

        public virtual IList<Recipe> Recipes { get; set; }
    }
}
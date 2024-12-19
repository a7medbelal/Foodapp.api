﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Core.Entities
{
    public class Recipe:BaseEntity

    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<RecipeTag> Tags { get; set; } = new List<RecipeTag>();
    }
}

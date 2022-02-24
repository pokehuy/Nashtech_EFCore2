using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace efcore2.Models
{
    public class ProductCategoryModel
    {
        public CategoryModel Category {get; set;}
        public ProductModel Product {get; set;}
    }
}
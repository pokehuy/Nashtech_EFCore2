using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace efcore2.Models
{
    public class CategoryModel
    {
        public int CategoryId {get; set;}
        public string CategoryName {get; set;}
    }
}
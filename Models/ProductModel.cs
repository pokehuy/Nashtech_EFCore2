using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace efcore2.Models
{
    public class ProductModel
    {
        public int ProductId {get; set;}
        public string ProductName {get; set;}
        public string Manufacture {get; set;}
        public int CategoryId{get; set;}

    }
}
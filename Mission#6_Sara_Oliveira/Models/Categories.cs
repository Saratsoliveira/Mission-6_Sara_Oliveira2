using System.ComponentModel.DataAnnotations;

namespace Mission_6_Sara_Oliveira.Models
{
    public class Categories
    {

        [Key]
        public int CategoryId {  get; set; }

        public string Category { get; set; }
    }
}

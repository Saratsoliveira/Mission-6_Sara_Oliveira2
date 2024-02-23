using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission_6_Sara_Oliveira.Models
{
    public class Movies
    {
        [Key]
        [Required(ErrorMessage = "Field can't be empty")]
        public int MovieId { get; set; }
        


        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        //public Categories? Category { get; set; }
        [Required(ErrorMessage = "Title can't be empty")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year can't be empty")]
        [Range(1888, 9999, ErrorMessage="Please use a valid Year")]
        public int Year { get; set; }

        public string? Director { get; set; }

        
      
        public string? Rating { get; set; }
        [Required(ErrorMessage = "Edited can't be empty")]

        public bool Edited { get; set; }

        public string? LentTo { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]

        public bool CopiedToPlex { get; set; }

        public string? Notes { get; set; }
        
       




    }
}

using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace Mission_6_Sara_Oliveira.Models
{
    public class Application
    {
        [Key]
        [Required]
        public int ApplicationID { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]



        public string Category { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public string Tittle { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]

        public string Director { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]

        public string Rating { get; set; }

        public Boolean Edited { get; set; }

        public string Lent_To { get; set; }

        public string Notes { get; set; }
        
       




    }
}

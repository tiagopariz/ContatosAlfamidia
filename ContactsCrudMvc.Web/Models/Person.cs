using System.ComponentModel.DataAnnotations;

namespace ContactsCrudMvc.Web.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Telefone")]
        public string Phone { get; set; }

        [Display(Name = "E-Mail")]
        public string Email { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace CursoGeekUniversity.Models
{
    public class ClienteViewModel
    {
        [Required]
        [Display(Name ="Nome e sobrenome")]
        public string Nome { get; set; }
        public string Telefone { get; set; }
        [Required]
        public string Endereço { get; set; }
    }
}

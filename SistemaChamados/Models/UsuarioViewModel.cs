using System.ComponentModel.DataAnnotations;

namespace SistemaChamados.Models
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaChamados.Models
{
    public class ChamadosViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A data de abertura é obrigatória.")]
        public DateTime? dataAbertura { get; set; }

        [Required(ErrorMessage = "A descrição do problema é obrigatória.")]
        public string descricaoProblema { get; set; }

        [Required(ErrorMessage = "A descrição do atendimento é obrigatória.")]
        public string descricaoAtendimento { get; set; }

        [Required(ErrorMessage = "A data de atendimento é obrigatória.")]
        public DateTime? dataAtendimento { get; set; }

        [Required(ErrorMessage = "A situação é obrigatória.")]
        public int? situacao { get; set; }

        [Required(ErrorMessage = "O usuário é obrigatório.")]
        public int? usuarioId { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SistemaChamados.Models
{
    public class ChamadosViewModel
    {
        public int Id { get; set; }
        public DateTime? dataAbertura { get; set; }
        public string descricaoProblema { get; set; }
        public string descricaoAtendimento { get; set; }
        public DateTime? dataAtendimento { get; set; }
        public int? situacao { get; set; }
        public int? usuarioId { get; set; }
    }
}

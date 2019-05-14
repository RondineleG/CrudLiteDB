using System;
using System.ComponentModel.DataAnnotations;

namespace CrudLiteDB.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "O Nome é obrigatório", AllowEmptyStrings = false)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Telefone é obrigatório", AllowEmptyStrings = false)]
        public string Telefone { get; set; }
        public DateTime DataCadastro => DateTime.Now;

    }
}

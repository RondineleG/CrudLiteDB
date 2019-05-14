using System;
using System.ComponentModel.DataAnnotations;

namespace CrudLiteDB.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "O nome é obrigatório", AllowEmptyStrings = false)]
        public string Nome { get; set; }         
        public string Sobrenome { get; set; }
        public string Email { get; set; }

        [StringLength(11, MinimumLength = 11)]
        [Required(ErrorMessage = "O Telefone é obrigatório", AllowEmptyStrings = false)]
        public string Telefone { get; set; }
        public DateTime DataCadastro => DateTime.Now;

    }
}

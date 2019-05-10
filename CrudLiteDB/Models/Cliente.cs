using System;
using System.ComponentModel.DataAnnotations;

namespace CrudLiteDB.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Telefone { get; set; }
        public DateTime DataCadastro => DateTime.Now;

    }
}

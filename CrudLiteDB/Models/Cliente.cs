using System;
using System.ComponentModel.DataAnnotations;

namespace CrudLiteDB.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCadastro => DateTime.Now;

    }
}

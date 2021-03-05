using System;
using System.ComponentModel.DataAnnotations;

namespace MvcCadastro.Models
{
    public class Cadastro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email{ get; set; }
        public string RG { get; set; }
    }
}
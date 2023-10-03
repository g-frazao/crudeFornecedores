using System.ComponentModel.DataAnnotations;

namespace crudeFornecedores.Models
{
    public class Fornecedores
    {
        public int Id { get; set; }

        [Required]
        public string RazaoSocial { get; set; }

        [Required]
        public string NomeFantasia { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Telefone { get; set; }

        [Required]
        public string EnderecoCompleto { get; set; }

        [Required]
        public string PessoaContato { get; set; }
    }
}

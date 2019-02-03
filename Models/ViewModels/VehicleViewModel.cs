using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using vega.Models.Entities;

namespace vega.Models.ViewModels
{
    public class VehicleViewModel
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage="Modelo é obrigatório.")]
        public int ModelId { get; set; }

        [Required(ErrorMessage="Campo registrado é obrigatório.")]
        public string IsRegistered { get; set; } 

        [Required(ErrorMessage="Nome do contato é obrigatório.", AllowEmptyStrings=false)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos no nome.")]
        public string ContactName { get; set; }       

        [Required(ErrorMessage="Telefone do contato é obrigatório.", AllowEmptyStrings=false)]
        [Phone(ErrorMessage="Telefone do contato é inválido.")]
        public string ContactPhone { get; set; }

        [Required(ErrorMessage="E-mail do contato é obrigatório.", AllowEmptyStrings=false)]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage = "E-mail é inválido.")]
        public string ContactEmail { get; set; }

        public List<int> Features { get; set; }
    }
}
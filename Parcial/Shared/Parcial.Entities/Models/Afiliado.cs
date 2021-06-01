using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial.Shared.Parcial.Entities.Models
{
    public class Afiliado : IdentityBase
    {
        [Required]
        public string NombreYApellido { get; set; }
        [Required]
        public string Telefono { get; set; }
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Mail invalido")]
        public string Email { get; set; }
        [Required]
        public string CUIT { get; set; }
    }
}
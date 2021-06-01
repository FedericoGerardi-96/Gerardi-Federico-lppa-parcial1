using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial.Shared.Parcial.Entities.Models
{
    public class IdentityBase
    {
        [Key]
        public int Id { get; set; }
    }

    public class Productos : IdentityBase
    {
        public string Nombre { get; set; }
    }
}
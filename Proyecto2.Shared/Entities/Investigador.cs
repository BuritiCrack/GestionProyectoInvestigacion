using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.Shared.Entities
{
    public class Investigador
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del investigador es obligatorio")]
        public string Name { get; set; } = null;

        [Required(ErrorMessage = "El campo es obligatorio")]
        public string InstitutionalAffiliation { get; set; } = null;

        [Required(ErrorMessage = "El campo es obligatorio")]
        public string Specialization { get; set; } = null;

        [Required(ErrorMessage = "El campo es obligatorio")]
        public string Rol { get; set; } = null;
    }
}

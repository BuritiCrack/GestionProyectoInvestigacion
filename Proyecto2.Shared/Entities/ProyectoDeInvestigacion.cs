using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.Shared.Entities
{
    public class ProyectoDeInvestigacion
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del proyecto es obligatorio")]
        public string ProjectName { get; set; } = null;

        public DateTime StartlDate { get; set; }

        public DateTime EndlDate { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public string ProjectLeader { get; set; } = null;

        [Required(ErrorMessage = "La descripcion del proyecto es obligatorio")]
        public string Description { get; set; } = null;

        [Required(ErrorMessage = "El area de investigacion es obligatorio")]
        public string InvestigationArea { get; set; } = null;
    }
}

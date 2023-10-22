using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketConDetalle.Shared.Models
{
    public  class Tickets
    {
        [Key]
        public int TicketId { get; set; }

        [Required(ErrorMessage = "El compo Fecha es requerido")]
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "El campo Cliente ID  es requerido")]
        public int ClienteId { get; set; }
        [ForeignKey(nameof(ClienteId))]
        public Clientes? Cliente { get; set; }        

        [Required(ErrorMessage = "EL campo Solicitado es requerido")]
        [StringLength(50, ErrorMessage = "El compo Solicitado por supera los 50 caracteres")]
        public string? SolicitadoPor { get; set; }

        [Required(ErrorMessage = "EL campo Asunto es requerido")]
        [StringLength(100, ErrorMessage = "El compo Asunto supera los 100 caracteres")]
        public string? Asunto { get; set; }

        [Required(ErrorMessage = "EL campo Descripción es requerido")]
        [StringLength(100, ErrorMessage = "El compo Decripción supera los 100 caracteres")]
        public string? Descripción { get; set; }

        [ForeignKey("TicketId")]
        public ICollection<TicketsDetalle> TicketsDetalles { get; set; } = new List<TicketsDetalle>();

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketConDetalle.Shared.Models
{
    public class TicketsDetalle
    {
        [Key]
        public int DetalleId { get; set; }
        public int TicketId { get; set; }
        public Clientes Emisor { get; set; }
        public string Mensaje { get; set; }
    }
}

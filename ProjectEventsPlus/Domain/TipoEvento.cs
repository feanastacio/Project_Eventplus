using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectEventsPlus.Domain
{
    [Table("TipoEvento")]
    public class TipoEvento
    {
        [Key]
        public Guid TipoEventoId { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O tipo de evento é obrigatório!")]
        public string? TituloTipoEvento { get; set; }
    }
}

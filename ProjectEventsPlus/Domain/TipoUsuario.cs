using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectEventsPlus.Domain
{
    [Table("TipoUsuario")]
    public class TipoUsuario
    {
        [Key]
        public Guid TipoUsuarioId { get; set; }
        [Column(TypeName = "VARCHAR(30)")]
        [Required(ErrorMessage = "O tipo de usuário é obrigatório!")]
        public string? TipoDeUsuario { get; set; }
    }
}

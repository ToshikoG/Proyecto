using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto.Models
{
    [Table("Jefes")]

    public class Jefe
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido_p { get; set; }

        public string Area { get; set; }

    }
}

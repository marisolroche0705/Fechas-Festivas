using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fecha_Festiva.Dominio.Entidades
{
    [Table("Tipo")]
    public class Tipo
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Tipo")]
        [StringLength(100)]
        public string Nombre { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fecha_Festiva.Dominio.Entidades
{
    [Table("Festivos")]
    public class Seleccion
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Dia")]
        public int Dia { get; set; }

        [Column("Mes")]
        public int Mes { get; set; }
    }
}

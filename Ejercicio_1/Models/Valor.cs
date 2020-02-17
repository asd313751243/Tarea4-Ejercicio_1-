using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    public class Valor
    {
        [Required]
        [Range(10, 99)]
        public int numero { get; set; }
    }
}

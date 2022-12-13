using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class alumnosInformatica
    {
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public int edad { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroArticulo.Entidades
{
    public class Articulos
    {
        [Key]
        public int ArticuloId  { get; set; }
        public string Descripcion { get; set; }
        public string precio { get; set; }
        public int CantidadCotizada { get; set; }
        public DateTime FechaVencimiento { get; set; }

        public Articulos()
        {

            ArticuloId = 0;
            Descripcion = string.Empty;
            precio = string.Empty;
            CantidadCotizada = 0;
            FechaVencimiento = DateTime.Now;

        }
    }
}

using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        public string codigo { get; set; }

        public string nombre { get; set; }

        public string descripcion { get; set;}

        public Marcas marca { get; set; }

        public Categorias categoria { get; set; }

        public float precio { get; set;}

        public string UrlImagen { get; set; }

        public override string ToString()
        {
            return nombre;
        }

    }
}

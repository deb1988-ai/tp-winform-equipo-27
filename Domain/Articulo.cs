﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        /*Código de artículo.
Nombre.
Descripción.
Marca (seleccionable de una lista desplegable).
Categoría (seleccionable de una lista desplegable.
Imagen.
Precio.*/
        public string codigo { get; set; }

        public string nombre { get; set; }

        public string descripcion { get; set;}

        public string marca { get; set; }

        public string categoria { get; set; }

        public string imagen { get; set; }

        public float precio { get; set;}

        public override string ToString()
        {
            return nombre;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Curso
    {
        internal string Id { get; set; }

        public string Titulo { get; set; }

        public string Descripcion { get; set; }

        internal double Duracion { get; set; }

        public byte Nivel { get; set; }
    }
}

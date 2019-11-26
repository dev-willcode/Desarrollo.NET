using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCursosDigitales.Clases
{
    class Matricula
    {
        private string nombreMatriculado;
        private string formaPago;
        private List<Curso> listaCursos;

        public Matricula()
        {
            this.listaCursos = new List<Curso>();
        }

        public string NombreMatriculado { get => nombreMatriculado; set => nombreMatriculado = value; }
        public string FormaPago { get => formaPago; set => formaPago = value; }
        internal List<Curso> ListaCursos { get => listaCursos; set => listaCursos = value; }
    }
}

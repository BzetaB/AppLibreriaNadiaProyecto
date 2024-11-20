using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class CategoriaBE
    {
        public CategoriaBE() { }
        public CategoriaBE(string nombre_Categoria)
        {
            Nombre_Categoria = nombre_Categoria;
        }
        public CategoriaBE(int cod_Categoria, string nombre_Categoria)
        {
            Cod_Categoria = cod_Categoria;
            Nombre_Categoria = nombre_Categoria;
        }

        public int Cod_Categoria { get; set; }
        public string Nombre_Categoria { get; set; }

    }
}

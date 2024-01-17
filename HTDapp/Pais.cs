using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTDapp
{
    public class Pais
    {
        

        public string Sigla { get; set; }
        public string Nome { get; set; }


        public Pais(string sigla, string nome)
        {
            this.Sigla = sigla;
            this.Nome = nome;
        }
        public static List<Pais> Listagem { get; set; }
        static Pais()
        {
            Listagem = new List<Pais>
            {
                new Pais("BR", "Brasil"),
                new Pais("AR", "Argentina"),
                new Pais("EC", "Equador"),
                new Pais("PE", "Peru"),
                new Pais("CL", "Chile"),
                new Pais("BO", "Bolivia"),
                new Pais("PY", "Paraguay"),
                new Pais("VE", "Venezuela"),
                new Pais("CO", "Colômbia"),
                new Pais("OT", "Outros"),
            };
        }

    }

}

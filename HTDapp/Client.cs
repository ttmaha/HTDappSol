using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTDapp
{




    public enum EnumEstadoCivil
    {
        Solteiro,
        Casado,
        Divorciado,
        Viúvo,
    }
   
    public class Client
    {
        

        public int Codigo { get; private set; }
        public string Nome { get; set; }
        public long? CPF { get; set; }
        public DateTime? DataNascimento { get; set; }
        public decimal? Filhos { get; set; }
        public  string Nacionalidade { get; set; }
        public DateTime? PrimeiraConsulta { get; set; }
        public string EncaminhadoPor { get; set; }
        public string Endereco { get; set;}
        public string Profissão { get; set; }
        public string Bairro { get; set; }
        public string Telefone { get; set; }    
        public EnumEstadoCivil EstadoCivil { get; set; }

    
      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagemen
{
    public class Pessoa
    {
        public Pessoa(string nome, string endereco, int idade)
        {
            Nome = nome;
            Endereco = endereco;
            Idade = idade;
        }
        public string Nome {  get; set; }
        public string Endereco { get; set; }
        public int Idade { get; set; }
    }
}
